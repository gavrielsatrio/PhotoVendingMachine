using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Accord.Video.DirectShow;

using MacUI;

namespace PhotoVendingMachine
{
    public partial class OptionsForm : MacUIForm
    {
        public MainForm mainForm;

        public OptionsForm()
        {
            InitializeComponent();
        }

        private void OptionsForm_Load(object sender, EventArgs e)
        {
            lblTitle.Text = this.Text;

            comboCamera.DataSource = AppConfig.cameraList;
            comboCamera.ValueMember = "MonikerString";
            comboCamera.DisplayMember = "Name";

            comboCamera.SelectedValue = AppConfig.cameraList[mainForm.currentCameraIndex].MonikerString;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            BackToMain();
        }

        private void OptionsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            BackToMain();
        }

        private void BackToMain()
        {
            this.Hide();
            new MainForm()
            {
                currentCameraIndex = comboCamera.SelectedIndex
            }.Show();
        }
    }
}
