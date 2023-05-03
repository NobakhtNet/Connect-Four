using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Connect_Four
{
    public partial class HowToPlay : Form
    {
        Point ParentTopLeft;
        Size ParentSize;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );

        public HowToPlay(Point parentTopLeft, Size parentSize)
        {
            InitializeComponent();

            this.TopMost = true;
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 40, 40));
            ParentTopLeft = parentTopLeft;
            ParentSize = parentSize;
        }

        private void HowToPlay_Load(object sender, EventArgs e)
        {
            int tempY = (ParentSize.Height - this.Height) / 2;
            int tempX = (ParentSize.Width - this.Width) / 2;
            int newX = ParentTopLeft.X + tempX;
            int newY = ParentTopLeft.Y + tempY;
            if (newX < 0)
            {
                newX = 0;
            }
            if (newY < 0)
            {
                newY = 0;
            }
            this.Location = new Point(newX, newY);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
