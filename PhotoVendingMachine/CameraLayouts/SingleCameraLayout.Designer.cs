namespace PhotoVendingMachine.CameraLayouts
{
    partial class SingleCameraLayout
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
            this.panelCamera = new System.Windows.Forms.Panel();
            this.picBoxCamera = new System.Windows.Forms.PictureBox();
            this.panelCamera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCamera)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCamera
            // 
            this.panelCamera.Controls.Add(this.picBoxCamera);
            this.panelCamera.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCamera.Location = new System.Drawing.Point(0, 0);
            this.panelCamera.Name = "panelCamera";
            this.panelCamera.Size = new System.Drawing.Size(700, 400);
            this.panelCamera.TabIndex = 0;
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
            // SingleCameraLayout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelCamera);
            this.Name = "SingleCameraLayout";
            this.Size = new System.Drawing.Size(700, 400);
            this.Load += new System.EventHandler(this.SingleCameraLayout_Load);
            this.panelCamera.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCamera)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCamera;
        private System.Windows.Forms.PictureBox picBoxCamera;
    }
}
