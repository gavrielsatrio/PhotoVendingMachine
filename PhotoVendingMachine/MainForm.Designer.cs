using PhotoVendingMachine.Components;

namespace PhotoVendingMachine
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelBottom = new System.Windows.Forms.Panel();
            this.btnCapture = new System.Windows.Forms.PictureBox();
            this.btnOptions = new System.Windows.Forms.Button();
            this.panelCameraLayout = new System.Windows.Forms.Panel();
            this.btnGrid = new PhotoVendingMachine.Components.GradientButton();
            this.btnSingle = new PhotoVendingMachine.Components.GradientButton();
            this.btnFilm = new PhotoVendingMachine.Components.GradientButton();
            this.panelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCapture)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Size = new System.Drawing.Size(684, 24);
            this.lblTitle.Text = "Photo Vending Machine";
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.panelBottom.Controls.Add(this.btnCapture);
            this.panelBottom.Controls.Add(this.btnGrid);
            this.panelBottom.Controls.Add(this.btnSingle);
            this.panelBottom.Controls.Add(this.btnFilm);
            this.panelBottom.Controls.Add(this.btnOptions);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 428);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(700, 52);
            this.panelBottom.TabIndex = 3;
            // 
            // btnCapture
            // 
            this.btnCapture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnCapture.Location = new System.Drawing.Point(329, 5);
            this.btnCapture.Name = "btnCapture";
            this.btnCapture.Size = new System.Drawing.Size(42, 42);
            this.btnCapture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCapture.TabIndex = 23;
            this.btnCapture.TabStop = false;
            this.btnCapture.Click += new System.EventHandler(this.btnCapture_Click);
            this.btnCapture.MouseEnter += new System.EventHandler(this.btnCapture_MouseEnter);
            this.btnCapture.MouseLeave += new System.EventHandler(this.btnCapture_MouseLeave);
            // 
            // btnOptions
            // 
            this.btnOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOptions.BackColor = System.Drawing.Color.White;
            this.btnOptions.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.btnOptions.FlatAppearance.BorderSize = 0;
            this.btnOptions.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOptions.Location = new System.Drawing.Point(580, 16);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(100, 21);
            this.btnOptions.TabIndex = 9;
            this.btnOptions.Text = "Options";
            this.btnOptions.UseVisualStyleBackColor = false;
            this.btnOptions.Click += new System.EventHandler(this.btnOptions_Click);
            // 
            // panelCameraLayout
            // 
            this.panelCameraLayout.BackColor = System.Drawing.Color.Black;
            this.panelCameraLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCameraLayout.Location = new System.Drawing.Point(0, 40);
            this.panelCameraLayout.Name = "panelCameraLayout";
            this.panelCameraLayout.Size = new System.Drawing.Size(700, 388);
            this.panelCameraLayout.TabIndex = 4;
            // 
            // btnGrid
            // 
            this.btnGrid.Color1 = System.Drawing.Color.White;
            this.btnGrid.Color2 = System.Drawing.Color.White;
            this.btnGrid.ColorHovered1 = System.Drawing.Color.White;
            this.btnGrid.ColorHovered2 = System.Drawing.Color.White;
            this.btnGrid.FlatAppearance.BorderSize = 0;
            this.btnGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrid.IconImage = ((System.Drawing.Image)(resources.GetObject("btnGrid.IconImage")));
            this.btnGrid.Location = new System.Drawing.Point(20, 16);
            this.btnGrid.Name = "btnGrid";
            this.btnGrid.Size = new System.Drawing.Size(36, 21);
            this.btnGrid.TabIndex = 20;
            this.btnGrid.UseVisualStyleBackColor = true;
            this.btnGrid.Click += new System.EventHandler(this.btnGrid_Click);
            // 
            // btnSingle
            // 
            this.btnSingle.Color1 = System.Drawing.Color.White;
            this.btnSingle.Color2 = System.Drawing.Color.White;
            this.btnSingle.ColorHovered1 = System.Drawing.Color.White;
            this.btnSingle.ColorHovered2 = System.Drawing.Color.White;
            this.btnSingle.FlatAppearance.BorderSize = 0;
            this.btnSingle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSingle.IconImage = ((System.Drawing.Image)(resources.GetObject("btnSingle.IconImage")));
            this.btnSingle.Location = new System.Drawing.Point(56, 16);
            this.btnSingle.Name = "btnSingle";
            this.btnSingle.Size = new System.Drawing.Size(36, 21);
            this.btnSingle.TabIndex = 19;
            this.btnSingle.UseVisualStyleBackColor = true;
            this.btnSingle.Click += new System.EventHandler(this.btnSingle_Click);
            // 
            // btnFilm
            // 
            this.btnFilm.Color1 = System.Drawing.Color.White;
            this.btnFilm.Color2 = System.Drawing.Color.White;
            this.btnFilm.ColorHovered1 = System.Drawing.Color.White;
            this.btnFilm.ColorHovered2 = System.Drawing.Color.White;
            this.btnFilm.FlatAppearance.BorderSize = 0;
            this.btnFilm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilm.IconImage = ((System.Drawing.Image)(resources.GetObject("btnFilm.IconImage")));
            this.btnFilm.Location = new System.Drawing.Point(92, 16);
            this.btnFilm.Name = "btnFilm";
            this.btnFilm.Size = new System.Drawing.Size(36, 21);
            this.btnFilm.TabIndex = 18;
            this.btnFilm.UseVisualStyleBackColor = true;
            this.btnFilm.Click += new System.EventHandler(this.btnFilm_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(700, 480);
            this.Controls.Add(this.panelCameraLayout);
            this.Controls.Add(this.panelBottom);
            this.Name = "MainForm";
            this.Text = "Photo Vending Machine";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Controls.SetChildIndex(this.panelBottom, 0);
            this.Controls.SetChildIndex(this.panelCameraLayout, 0);
            this.panelBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnCapture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Panel panelCameraLayout;
        private System.Windows.Forms.Button btnOptions;
        private GradientButton btnFilm;
        private GradientButton btnSingle;
        private GradientButton btnGrid;
        private System.Windows.Forms.PictureBox btnCapture;
    }
}

