using PhotoVendingMachine.Components;

namespace PhotoVendingMachine.CameraLayouts
{
    partial class VideoCameraLayout
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VideoCameraLayout));
            this.panelCamera = new System.Windows.Forms.Panel();
            this.lblProcessingVideo = new PhotoVendingMachine.Components.TransparentLabel();
            this.lblLoading = new PhotoVendingMachine.Components.TransparentLabel();
            this.picBoxLoading = new System.Windows.Forms.PictureBox();
            this.lblNowRecording = new PhotoVendingMachine.Components.TransparentLabel();
            this.picBoxRecordIcon = new System.Windows.Forms.PictureBox();
            this.picBoxCamera = new System.Windows.Forms.PictureBox();
            this.timerRecordIcon = new System.Windows.Forms.Timer(this.components);
            this.timerLoading = new System.Windows.Forms.Timer(this.components);
            this.panelCamera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLoading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxRecordIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCamera)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCamera
            // 
            this.panelCamera.Controls.Add(this.lblProcessingVideo);
            this.panelCamera.Controls.Add(this.lblLoading);
            this.panelCamera.Controls.Add(this.picBoxLoading);
            this.panelCamera.Controls.Add(this.lblNowRecording);
            this.panelCamera.Controls.Add(this.picBoxRecordIcon);
            this.panelCamera.Controls.Add(this.picBoxCamera);
            this.panelCamera.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCamera.Location = new System.Drawing.Point(0, 0);
            this.panelCamera.Name = "panelCamera";
            this.panelCamera.Size = new System.Drawing.Size(700, 400);
            this.panelCamera.TabIndex = 1;
            // 
            // lblProcessingVideo
            // 
            this.lblProcessingVideo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblProcessingVideo.BackColor = System.Drawing.Color.Transparent;
            this.lblProcessingVideo.Font = new System.Drawing.Font("SF Pro Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcessingVideo.ForeColor = System.Drawing.Color.White;
            this.lblProcessingVideo.Location = new System.Drawing.Point(3, 195);
            this.lblProcessingVideo.Name = "lblProcessingVideo";
            this.lblProcessingVideo.Size = new System.Drawing.Size(694, 29);
            this.lblProcessingVideo.TabIndex = 13;
            this.lblProcessingVideo.Text = "Processing Video";
            this.lblProcessingVideo.Visible = false;
            // 
            // lblLoading
            // 
            this.lblLoading.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLoading.BackColor = System.Drawing.Color.Transparent;
            this.lblLoading.Font = new System.Drawing.Font("SF Pro Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoading.ForeColor = System.Drawing.Color.White;
            this.lblLoading.Location = new System.Drawing.Point(3, 135);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(694, 30);
            this.lblLoading.TabIndex = 16;
            this.lblLoading.Visible = false;
            // 
            // picBoxLoading
            // 
            this.picBoxLoading.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picBoxLoading.BackColor = System.Drawing.Color.Transparent;
            this.picBoxLoading.Image = ((System.Drawing.Image)(resources.GetObject("picBoxLoading.Image")));
            this.picBoxLoading.Location = new System.Drawing.Point(335, 165);
            this.picBoxLoading.Name = "picBoxLoading";
            this.picBoxLoading.Size = new System.Drawing.Size(30, 30);
            this.picBoxLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxLoading.TabIndex = 17;
            this.picBoxLoading.TabStop = false;
            this.picBoxLoading.Visible = false;
            // 
            // lblNowRecording
            // 
            this.lblNowRecording.AutoSize = true;
            this.lblNowRecording.BackColor = System.Drawing.Color.Transparent;
            this.lblNowRecording.Font = new System.Drawing.Font("SF Pro Display", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNowRecording.ForeColor = System.Drawing.Color.White;
            this.lblNowRecording.Location = new System.Drawing.Point(36, 17);
            this.lblNowRecording.Name = "lblNowRecording";
            this.lblNowRecording.Size = new System.Drawing.Size(84, 13);
            this.lblNowRecording.TabIndex = 9;
            this.lblNowRecording.Text = "Now Recording";
            this.lblNowRecording.Visible = false;
            // 
            // picBoxRecordIcon
            // 
            this.picBoxRecordIcon.BackColor = System.Drawing.Color.Transparent;
            this.picBoxRecordIcon.Location = new System.Drawing.Point(16, 16);
            this.picBoxRecordIcon.Name = "picBoxRecordIcon";
            this.picBoxRecordIcon.Size = new System.Drawing.Size(16, 16);
            this.picBoxRecordIcon.TabIndex = 8;
            this.picBoxRecordIcon.TabStop = false;
            // 
            // picBoxCamera
            // 
            this.picBoxCamera.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBoxCamera.Location = new System.Drawing.Point(0, 0);
            this.picBoxCamera.Name = "picBoxCamera";
            this.picBoxCamera.Size = new System.Drawing.Size(700, 400);
            this.picBoxCamera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxCamera.TabIndex = 7;
            this.picBoxCamera.TabStop = false;
            // 
            // timerRecordIcon
            // 
            this.timerRecordIcon.Interval = 1000;
            this.timerRecordIcon.Tick += new System.EventHandler(this.timerRecordIcon_Tick);
            // 
            // timerLoading
            // 
            this.timerLoading.Tick += new System.EventHandler(this.timerLoading_Tick);
            // 
            // VideoCameraLayout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelCamera);
            this.Name = "VideoCameraLayout";
            this.Size = new System.Drawing.Size(700, 400);
            this.Load += new System.EventHandler(this.VideoCameraLayout_Load);
            this.panelCamera.ResumeLayout(false);
            this.panelCamera.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLoading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxRecordIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCamera)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCamera;
        private System.Windows.Forms.PictureBox picBoxCamera;
        private System.Windows.Forms.Timer timerRecordIcon;
        private System.Windows.Forms.PictureBox picBoxRecordIcon;
        private TransparentLabel lblNowRecording;
        private TransparentLabel lblProcessingVideo;
        private TransparentLabel lblLoading;
        private System.Windows.Forms.PictureBox picBoxLoading;
        private System.Windows.Forms.Timer timerLoading;
    }
}
