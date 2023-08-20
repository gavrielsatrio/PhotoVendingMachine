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

//using AForge.Video;
//using AForge.Video.DirectShow;

using Accord.Video;
using Accord.Video.DirectShow;

namespace PhotoVendingMachine.CameraLayouts
{
    public partial class GridCameraLayout : UserControl
    {
        private VideoCaptureDevice camera;
        private List<PictureBox> picBoxCameraList;
        private int currentCameraNumber = 1;
        private bool countdownDone = false;

        public GridCameraLayout(VideoCaptureDevice cameraParam)
        {
            InitializeComponent();

            this.camera = cameraParam;
        }

        private void GridCameraLayout_Load(object sender, EventArgs e)
        {
            LoadPicBoxCameraList();

            camera.NewFrame += Camera_NewFrame;
            camera.Start();
        }

        private void LoadPicBoxCameraList()
        {
            picBoxCameraList = new List<PictureBox>()
            {
                new PictureBox(),
                picBoxCamera1,
                picBoxCamera2,
                picBoxCamera3,
                picBoxCamera4
            };
        }

        private void Camera_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            var currentPicBoxCamera = picBoxCameraList[currentCameraNumber];

            if (currentPicBoxCamera.Image != null)
            {
                currentPicBoxCamera.Image.Dispose();
            }

            Bitmap newImageFrame = (Bitmap)eventArgs.Frame.Clone();
            currentPicBoxCamera.Image = newImageFrame;
        }

        private void ResetCamera()
        {
            currentCameraNumber = 1;

            picBoxCamera1.Image = null;
            picBoxCamera2.Image = null;
            picBoxCamera3.Image = null;
            picBoxCamera4.Image = null;
        }

        public void TakePhoto()
        {
            if(countdownDone == false)
            {
                countdownDone = true;

                var currentPicBoxCamera = picBoxCameraList[currentCameraNumber];
                new CountdownTimer(this, "TakePhoto").AddAndStartTimer(currentPicBoxCamera, 2000);
            }
            else
            {
                countdownDone = false;

                if(currentCameraNumber == 4)
                {
                    var onePhotoWidth = picBoxCamera1.Image.Width;
                    var onePhotoHeight = picBoxCamera1.Image.Height;
                    var padding = 12;

                    Bitmap image = new Bitmap((onePhotoWidth * 2) + padding, (onePhotoHeight * 2) + padding);
                    Graphics graphics = Graphics.FromImage(image);
                    graphics.SmoothingMode = SmoothingMode.AntiAlias;

                    graphics.DrawImage(picBoxCamera1.Image, 0, 0);
                    graphics.DrawImage(picBoxCamera2.Image, onePhotoWidth + padding, 0);
                    graphics.DrawImage(picBoxCamera3.Image, 0, onePhotoHeight + padding);
                    graphics.DrawImage(picBoxCamera4.Image, onePhotoWidth + padding, onePhotoHeight + padding);

                    graphics.Dispose();

                    image.Save(Application.StartupPath + $"/Result/Grid-{DateTime.Now.ToString("ddMMyyyyHHmmss")}.jpeg", ImageFormat.Jpeg);

                    ResetCamera();
                }
                else
                {
                    currentCameraNumber++;
                    TakePhoto();
                }
            }
        }
    }
}
