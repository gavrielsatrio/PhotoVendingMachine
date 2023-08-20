using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace PhotoVendingMachine.Components
{
    public class GradientButton : Button
    {
        private Color color1 = Color.White;
        private Color color2 = Color.White;
        private Color colorHovered1 = Color.White;
        private Color colorHovered2 = Color.White;
        private Image iconImage = null;
        private bool isHovered = false;

        public GradientButton()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
        }

        [Category("Gradient Properties")]
        public Color Color1
        {
            get
            {
                return color1;
            }
            set
            {
                color1 = value;
                this.Invalidate();
            }
        }

        [Category("Gradient Properties")]
        public Color Color2
        {
            get
            {
                return color2;
            }
            set
            {
                color2 = value;
                this.Invalidate();
            }
        }

        [Category("Gradient Properties")]
        public Color ColorHovered1
        {
            get
            {
                return colorHovered1;
            }
            set
            {
                colorHovered1 = value;
                this.Invalidate();
            }
        }

        [Category("Gradient Properties")]
        public Color ColorHovered2
        {
            get
            {
                return colorHovered2;
            }
            set
            {
                colorHovered2 = value;
                this.Invalidate();
            }
        }

        public Image IconImage
        {
            get
            {
                return iconImage;
            }
            set
            {
                iconImage = value;
                this.Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);

            var canvas = pevent.Graphics;
            canvas.SmoothingMode = SmoothingMode.AntiAlias;

            Color colorStop1 = color1;
            Color colorStop2 = color2;
            if(isHovered == true)
            {
                colorStop1 = colorHovered1;
                colorStop2 = colorHovered2;
            }
            
            using (var brush = new LinearGradientBrush(new Point(0, 0), new Point(0, this.ClientRectangle.Height), colorStop1, colorStop2))
            {
                canvas.FillRectangle(brush, this.ClientRectangle);
            }

            if (this.IconImage != null)
            {
                canvas.DrawImage(this.IconImage, (this.ClientRectangle.Width / 2) - (this.IconImage.Width / 2), (this.ClientRectangle.Height / 2) - (this.IconImage.Height / 2), this.ClientRectangle, GraphicsUnit.Pixel);
            }
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            isHovered = true;

            this.Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            isHovered = false;

            this.Invalidate();
        }
    }
}
