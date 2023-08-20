using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    public partial class SingleCameraLayout : UserControl
    {
        private VideoCaptureDevice camera;
        private bool countdownDone = false;

        public SingleCameraLayout(VideoCaptureDevice cameraParam)
        {
            InitializeComponent();

            this.camera = cameraParam;
        }

        private void SingleCameraLayout_Load(object sender, EventArgs e)
        {
            camera.NewFrame += Camera_NewFrame;
            camera.Start();
        }

        private void Camera_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            if(picBoxCamera.Image != null)
            {
                picBoxCamera.Image.Dispose();
            }

            Bitmap newImageFrame = (Bitmap)eventArgs.Frame.Clone();
            picBoxCamera.Image = newImageFrame;
        }

        public void TakePhoto()
        {
            if(countdownDone == false)
            {
                new CountdownTimer(this, "TakePhoto").AddAndStartTimer(picBoxCamera, 2000);
                countdownDone = true;
            }
            else
            {
                Bitmap imageCaptured = (Bitmap)picBoxCamera.Image.Clone();
                imageCaptured.Save(Application.StartupPath + $"/Result/Single-{DateTime.Now.ToString("ddMMyyyyHHmmss")}.jpeg", ImageFormat.Jpeg);
                countdownDone = false;
            }
        }
    }
}
