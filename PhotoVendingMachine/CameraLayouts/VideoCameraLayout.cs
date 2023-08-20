using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

//using AForge.Video;
//using AForge.Video.DirectShow;

using Accord.Video;
using Accord.Video.DirectShow;
using Accord.Video.VFW;

using CSVideoConverter;

namespace PhotoVendingMachine.CameraLayouts
{
    public partial class VideoCameraLayout : UserControl
    {
        private VideoCaptureDevice camera;
        private AVIWriter videoWriter = new AVIWriter();
        private bool isRecording = false;
        private bool isRecordIconBlink = false;

        private int compressingValue = 2;
        private Color colorRed = Color.FromArgb(254, 16, 44);

        private VideoConverter videoConverter = new VideoConverter();
        private string videoFileName = "";
        private int totalRecordedTime = 0;

        public VideoCameraLayout(VideoCaptureDevice cameraParam)
        {
            InitializeComponent();

            this.camera = cameraParam;
        }

        private void VideoCameraLayout_Load(object sender, EventArgs e)
        {
            lblNowRecording.Parent = picBoxCamera;
            picBoxRecordIcon.Parent = picBoxCamera;
            lblProcessingVideo.Parent = picBoxCamera;
            lblLoading.Parent = picBoxCamera;
            picBoxLoading.Parent = picBoxCamera;

            BlinkRecordIconAndLabel();

            camera.NewFrame += Camera_NewFrame;
            camera.Start();
        }

        private void Camera_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            try
            {
                Bitmap frame = (Bitmap)eventArgs.Frame.Clone();

                if (isRecording == true)
                {
                    var compressedFrame = (Bitmap)eventArgs.Frame.Clone();
                    var compressedBitmap = new Bitmap(compressedFrame, new Size(compressedFrame.Width / compressingValue, compressedFrame.Height / compressingValue));

                    videoWriter.Quality = 0;
                    videoWriter.AddFrame(compressedBitmap);
                }

                picBoxCamera.Image = frame;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message.ToString());
            }
        }

        public void TakeVideo()
        {
            isRecording = true;
            videoFileName = $"Video-{DateTime.Now.ToString("ddMMyyyyHHmmss")}";
            videoWriter.Open(Application.StartupPath + $"/Result/{videoFileName}.avi", picBoxCamera.Image.Width / compressingValue, picBoxCamera.Image.Height / compressingValue);

            timerRecordIcon.Start();

            isRecordIconBlink = true;
            lblNowRecording.Visible = true;
            BlinkRecordIconAndLabel();
        }

        public void StopVideo()
        {
            isRecording = false;
            videoWriter.Close();

            totalRecordedTime = 0;

            isRecordIconBlink = false;
            lblNowRecording.Visible = false;
            BlinkRecordIconAndLabel();

            timerRecordIcon.Stop();

            videoConverter = new VideoConverter()
            {
                VideoResolutionX = picBoxCamera.Image.Width.ToString(),
                VideoResolutionY = picBoxCamera.Image.Height.ToString(),
                VideoBitrate = "2048000",
                FileDestination = Application.StartupPath + $"/Result/{videoFileName}.mp4",
                FileSource = Application.StartupPath + $"/Result/{videoFileName}.avi"
            };
            videoConverter.OperationStart += VideoConverter_OperationStart;
            videoConverter.OperationDone += VideoConverter_OperationDone;
            videoConverter.Run();
        }

        private void VideoConverter_OperationStart(object sender)
        {
            camera.Stop();
            picBoxCamera.Image = null;

            lblProcessingVideo.Visible = true;
            lblLoading.Visible = true;
            picBoxLoading.Visible = true;

            timerLoading.Start();
        }

        private void VideoConverter_OperationDone(object sender, bool aborted = false)
        {
            camera.Start();

            lblProcessingVideo.Visible = false;
            lblLoading.Visible = false;
            picBoxLoading.Visible = false;

            timerLoading.Stop();
            File.Delete(Application.StartupPath + $"/Result/{videoFileName}.avi");
        }

        private void BlinkRecordIconAndLabel()
        {
            Bitmap bitmap = new Bitmap(20, 20);
            Graphics canvas = Graphics.FromImage(bitmap);
            canvas.SmoothingMode = SmoothingMode.AntiAlias;

            if(isRecordIconBlink == true)
            {
                canvas.FillEllipse(new SolidBrush(colorRed), 0, 0, 14, 14);
            }

            lblNowRecording.Text = TimeSpan.FromSeconds(totalRecordedTime).ToString(@"hh\:mm\:ss");
            picBoxRecordIcon.Image = bitmap;
            canvas.Dispose();
        }

        private void timerRecordIcon_Tick(object sender, EventArgs e)
        {
            if(isRecordIconBlink == true)
            {
                isRecordIconBlink = false;
            }
            else
            {
                isRecordIconBlink = true;
            }

            totalRecordedTime++;
            BlinkRecordIconAndLabel();
        }

        private void timerLoading_Tick(object sender, EventArgs e)
        {
            if(picBoxLoading.Location.Y <= lblLoading.Location.Y)
            {
                picBoxLoading.Location = new Point(picBoxLoading.Location.X, lblProcessingVideo.Location.Y);
            }
            else
            {
                picBoxLoading.Location = new Point(picBoxLoading.Location.X, picBoxLoading.Location.Y - 4);
            }
        }
    }
}
