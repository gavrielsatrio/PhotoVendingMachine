using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

using PhotoVendingMachine.CameraLayouts;
using PhotoVendingMachine.Types;

using Accord.Video.DirectShow;

using MacUI;


namespace PhotoVendingMachine
{
    public partial class MainForm : MacUIForm
    {
        public int currentCameraIndex = 0;
        private VideoCaptureDevice currentCamera;

        private string currentCameraType = "Single";
        private string currentMainButtonHoverState = "NotHovered";

        private Dictionary<string, CameraType> cameraTypeList;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lblTitle.Text = this.Text;

            LoadCamera();
            DrawMainButton();
        }

        private void LoadCamera()
        {
            currentCamera = new VideoCaptureDevice(AppConfig.cameraList[currentCameraIndex].MonikerString);

            LoadCameraTypeList();
            SelectCameraType(currentCameraType);
        }
        
        private void LoadCameraTypeList()
        {
            cameraTypeList = new Dictionary<string, CameraType>()
            {
                { 
                    "Grid", new CameraType()
                    {
                        OutputType = "Photo",
                        Btn = btnGrid,
                        Layout = new GridCameraLayout(currentCamera),
                        MethodToCaptureName = "TakePhoto"
                    }
                },
                {
                    "Single", new CameraType()
                    {
                        OutputType = "Photo",
                        Btn = btnSingle,
                        Layout = new SingleCameraLayout(currentCamera),
                        MethodToCaptureName = "TakePhoto"
                    }
                },
                {
                    "Film", new CameraType()
                    {
                        OutputType = "Video",
                        Btn = btnFilm,
                        Layout = new VideoCameraLayout(currentCamera),
                        MethodToCaptureName = "TakeVideo"
                    }
                }
            };
        }

        private void SelectCameraType(string selectedType)
        {
            currentCameraType = selectedType;
            panelCameraLayout.Controls.Clear();

            foreach (var item in cameraTypeList)
            {
                var cameraTypeName = item.Key;
                var button = item.Value.Btn;

                button.Color1 = Color.White;
                button.Color2 = Color.White;
                button.ColorHovered1 = AppConfig.colorLightGray;
                button.ColorHovered2 = AppConfig.colorLightGray;
                button.IconImage = Image.FromFile(Application.StartupPath + $"/Icons/Camera Type/{cameraTypeName}Black.png");
            }

            var selectedCameraType = cameraTypeList[selectedType];

            var chosenButton = selectedCameraType.Btn;
            chosenButton.Color1 = AppConfig.colorLightBlue;
            chosenButton.Color2 = AppConfig.colorBlue;
            chosenButton.ColorHovered1 = AppConfig.colorLightBlue;
            chosenButton.ColorHovered2 = AppConfig.colorDarkBlue;
            chosenButton.IconImage = Image.FromFile(Application.StartupPath + $"/Icons/Camera Type/{selectedType}White.png");

            var cameraLayout = selectedCameraType.Layout;
            cameraLayout.Dock = DockStyle.Fill;

            panelCameraLayout.Controls.Add(cameraLayout);

            DrawMainButton();
        }

        private void DrawMainButton()
        {
            btnCapture.Image = null;

            Bitmap image = new Bitmap(btnCapture.DisplayRectangle.Width, btnCapture.DisplayRectangle.Height);
            Graphics graphics = Graphics.FromImage(image);
            graphics.SmoothingMode = SmoothingMode.AntiAlias;

            if (currentMainButtonHoverState == "Hovered")
            {
                graphics.FillEllipse(new SolidBrush(AppConfig.colorDarkRed), 0, 0, image.Width - 1, image.Height - 1);
            }
            else
            {
                graphics.FillEllipse(new SolidBrush(AppConfig.colorRed), 0, 0, image.Width - 1, image.Height - 1);
            }

            var cameraIcon = Image.FromFile(Application.StartupPath + $"/Icons/{cameraTypeList[currentCameraType].OutputType}.png");
            graphics.DrawImage(cameraIcon, image.Width / 4f, image.Height / 4f, image.Width / 2f, image.Height / 2f);

            btnCapture.Image = image;
            graphics.Dispose();
        }

        private void btnCapture_Click(object sender, EventArgs e)
        {
            var type = cameraTypeList[currentCameraType].Layout.GetType();
            var methodName = cameraTypeList[currentCameraType].MethodToCaptureName;
            var methodToExecute = type.GetMethod(methodName);

            methodToExecute.Invoke(cameraTypeList[currentCameraType].Layout, null);

            if (currentCameraType == "Film")
            {
                if (cameraTypeList[currentCameraType].MethodToCaptureName == "TakeVideo")
                {
                    cameraTypeList[currentCameraType].OutputType = "VideoStop";
                    cameraTypeList[currentCameraType].MethodToCaptureName = "StopVideo";
                }
                else
                {
                    cameraTypeList[currentCameraType].OutputType = "Video";
                    cameraTypeList[currentCameraType].MethodToCaptureName = "TakeVideo";
                }

                DrawMainButton();
            }
        }

        private void btnGrid_Click(object sender, EventArgs e)
        {
            SelectCameraType("Grid");
        }

        private void btnSingle_Click(object sender, EventArgs e)
        {
            SelectCameraType("Single");
        }

        private void btnFilm_Click(object sender, EventArgs e)
        {
            SelectCameraType("Film");
        }

        private void btnCapture_MouseEnter(object sender, EventArgs e)
        {
            currentMainButtonHoverState = "Hovered";
            DrawMainButton();
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            if(currentCamera.IsRunning)
            {
                currentCamera.Stop();
            }

            this.Hide();
            new OptionsForm()
            {
                mainForm = this
            }.Show();

            LoadCamera();
        }

        private void btnCapture_MouseLeave(object sender, EventArgs e)
        {
            currentMainButtonHoverState = "NotHovered";
            DrawMainButton();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(currentCamera.IsRunning)
            {
                currentCamera.Stop();
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(currentCamera.IsRunning)
            {
                currentCamera.Stop();
            }

            Application.Exit();
        }
    }
}
