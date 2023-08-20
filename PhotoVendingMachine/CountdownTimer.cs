using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using PhotoVendingMachine.Components;

namespace PhotoVendingMachine
{
    public class CountdownTimer
    {
        private UserControl cameraLayout;
        private string methodName;

        private Timer timerCountdown;
        private Label lblCountdown;
        private PictureBox pictureBoxCamera;
        private int countdownNumber = 3;

        private Timer timerCountdownOpacity;
        private int countdownOpacityReduction = 15;


        private Timer timerSnappingOpacity = new Timer()
        {
            Interval = 5
        };
        private int snappingOpacityReduction = 20;

        public CountdownTimer(UserControl cameraLayoutParam, string methodNameParam)
        {
            this.cameraLayout = cameraLayoutParam;
            this.methodName = methodNameParam;
        }

        public void AddAndStartTimer(PictureBox picBoxParam, int duration)
        {
            this.pictureBoxCamera = picBoxParam;

            lblCountdown = new TransparentLabel();
            lblCountdown.Size = pictureBoxCamera.Size;
            lblCountdown.TextAlign = ContentAlignment.MiddleCenter;
            lblCountdown.Text = countdownNumber.ToString();
            lblCountdown.Font = new Font("SF Pro Display", 48f, FontStyle.Bold, GraphicsUnit.Pixel);
            lblCountdown.ForeColor = Color.FromArgb(255, 255, 255, 255);
            lblCountdown.BackColor = Color.Transparent;

            picBoxParam.Controls.Add(lblCountdown);

            int timerInterval = duration / 3;
            timerCountdown = new Timer();
            timerCountdown.Interval = timerInterval;
            timerCountdown.Tick += TimerCountdown_Tick;

            timerCountdownOpacity = new Timer();
            timerCountdownOpacity.Interval = timerInterval / (255 / countdownOpacityReduction);
            timerCountdownOpacity.Tick += TimerCountdownOpacity_Tick;

            timerSnappingOpacity.Tick += TimerSnappingOpacity_Tick;

            timerCountdown.Start();
            timerCountdownOpacity.Start();
        }

        private void TimerCountdownOpacity_Tick(object sender, EventArgs e)
        {
            if(lblCountdown.ForeColor.A <= 0 || (lblCountdown.ForeColor.A - countdownOpacityReduction) <= 0)
            {
                timerCountdownOpacity.Stop();
            }
            else
            {
                lblCountdown.ForeColor = Color.FromArgb(lblCountdown.ForeColor.A - countdownOpacityReduction, 255, 255, 255);
            }
        }

        private void TimerCountdown_Tick(object sender, EventArgs e)
        {
            if(countdownNumber == 1)
            {
                lblCountdown.Text = "";
                lblCountdown.BackColor = Color.FromArgb(250, 255, 255, 255);

                var type = cameraLayout.GetType();
                var methodToExecute = type.GetMethod(methodName);
                methodToExecute.Invoke(cameraLayout, null);

                timerSnappingOpacity.Start();

                countdownNumber = 3;
                timerCountdown.Stop();
            }
            else
            {
                countdownNumber--;

                lblCountdown.ForeColor = Color.FromArgb(255, 255, 255, 255);
                lblCountdown.Text = countdownNumber.ToString();

                timerCountdownOpacity.Start();
            }
        }

        private void TimerSnappingOpacity_Tick(object sender, EventArgs e)
        {
            if(lblCountdown.BackColor.A <= 0 || (lblCountdown.BackColor.A - snappingOpacityReduction) <= 0)
            {
                pictureBoxCamera.Controls.Remove(lblCountdown);
                timerSnappingOpacity.Stop();
            }
            else
            {
                lblCountdown.BackColor = Color.FromArgb(lblCountdown.BackColor.A - snappingOpacityReduction, 255, 255, 255);
            }
        }
    }
}
