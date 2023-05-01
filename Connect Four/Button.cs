using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Connect_Four
{
    public class RoundButton : Button
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            GraphicsPath grPath = new GraphicsPath();
            grPath.AddEllipse(0, 0, ClientSize.Width - 1, ClientSize.Height);
            this.Region = new System.Drawing.Region(grPath);
            base.OnPaint(e);
        }
    }
}