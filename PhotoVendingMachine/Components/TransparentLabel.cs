using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoVendingMachine.Components
{
    public class TransparentLabel : Label
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            using (var brush = new SolidBrush(this.ForeColor))
            {
                var stringFormat = new StringFormat(StringFormat.GenericTypographic);
                stringFormat.Alignment = StringAlignment.Center;
                stringFormat.LineAlignment = StringAlignment.Center;

                e.Graphics.DrawString(this.Text, this.Font, brush, this.ClientRectangle, stringFormat);
            }
        }
    }
}
