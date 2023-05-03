using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Connect_Four
{
    public partial class ConnectFour : Form
    {
        Color turn = Color.Red;
        bool redStarts = false;
        int a, b, c, d, f, g, h, R, Y, moveCounter;
        string whoWon = "Yellow";
        bool gameEnded = false;
        HowToPlay how;
        Info info;
        MessageBoxIcon icon = MessageBoxIcon.Error;

        private string ToBgr(Color c) => $"{c.B:X2}{c.G:X2}{c.R:X2}";

        [DllImport("DwmApi")]
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, int[] attrValue, int attrSize);

        const int DWWMA_CAPTION_COLOR = 35;
        void CustomWindow(Color captionColor, IntPtr handle)
        {
            try
            {
                IntPtr hWnd = handle;
                //Change caption color
                int[] caption = new int[] { int.Parse(ToBgr(captionColor), System.Globalization.NumberStyles.HexNumber) };
                DwmSetWindowAttribute(hWnd, DWWMA_CAPTION_COLOR, caption, 4);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to set border color attribute: {ex.Message}");
            }
        }

        public ConnectFour()
        {
            InitializeComponent();

            CustomWindow(Color.Bisque, Handle);
        }

        private void BtnColumn1_Click(object sender, EventArgs g)
        {

        }

        private void BtnColumn2_Click(object sender, EventArgs e)
        {

        }

        private void BtnColumn3_Click(object sender, EventArgs e)
        {

        }

        private void BtnColumn4_Click(object sender, EventArgs e)
        {

        }

        private void BtnColumn5_Click(object sender, EventArgs e)
        {

        }

        private void btnColumn6_Click(object sender, EventArgs e)
        {

        }

        private void btnColumn7_Click(object sender, EventArgs e)
        {

        }

        private void ConnectFour_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D1 || e.KeyCode == Keys.NumPad1)
                b11.PerformClick();

            if (e.KeyCode == Keys.D2 || e.KeyCode == Keys.NumPad2)
                b21.PerformClick();

            if (e.KeyCode == Keys.D3 || e.KeyCode == Keys.NumPad3)
                b31.PerformClick();

            if (e.KeyCode == Keys.D4 || e.KeyCode == Keys.NumPad4)
                b41.PerformClick();

            if (e.KeyCode == Keys.D5 || e.KeyCode == Keys.NumPad5)
                b51.PerformClick();

            if (e.KeyCode == Keys.D6 || e.KeyCode == Keys.NumPad6)
                b61.PerformClick();

            if (e.KeyCode == Keys.D7 || e.KeyCode == Keys.NumPad7)
                b71.PerformClick();

            if (e.KeyCode == Keys.R)
                btnRestart.PerformClick();
        }

        private void changeTurn()
        {
            UpdateStatus();

            if (turn == Color.Red)
                turn = Color.Yellow;
            else
                turn = Color.Red;

            if (whoWon == "Red")
                whoWon = "Yellow";
            else
                whoWon = "Red";
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            foreach (Control c in tblConnect4.Controls)
            {
                c.BackColor = Color.OldLace;
                ((RoundButton)c).FlatAppearance.MouseOverBackColor = Color.OldLace;
                ((RoundButton)c).FlatAppearance.MouseDownBackColor = Color.OldLace;
            }
            a = 0; b = 0; c = 0; d = 0; f = 0; g = 0; h = 0; moveCounter = 0;
            gameEnded = false;

            if (redStarts == false)
            {
                turn = Color.Yellow;
                whoWon = "Red";
                redStarts = true;
            }
            else
            {
                turn = Color.Red;
                whoWon = "Yellow";
                redStarts = false;
            }
            UpdateStatus();
        }

        private void CheckForWinner()
        {
            #region Rows
            if ((b11.BackColor == b21.BackColor && b21.BackColor == b31.BackColor && b31.BackColor == b41.BackColor && b11.BackColor != Color.OldLace) ||
                (b21.BackColor == b31.BackColor && b31.BackColor == b41.BackColor && b41.BackColor == b51.BackColor && b21.BackColor != Color.OldLace) ||
                (b31.BackColor == b41.BackColor && b41.BackColor == b51.BackColor && b51.BackColor == b61.BackColor && b31.BackColor != Color.OldLace) ||
                (b41.BackColor == b51.BackColor && b51.BackColor == b61.BackColor && b61.BackColor == b71.BackColor && b41.BackColor != Color.OldLace) ||
                (b12.BackColor == b22.BackColor && b22.BackColor == b32.BackColor && b32.BackColor == b42.BackColor && b12.BackColor != Color.OldLace) ||
                (b22.BackColor == b32.BackColor && b32.BackColor == b42.BackColor && b42.BackColor == b52.BackColor && b22.BackColor != Color.OldLace) ||
                (b32.BackColor == b42.BackColor && b42.BackColor == b52.BackColor && b52.BackColor == b62.BackColor && b32.BackColor != Color.OldLace) ||
                (b42.BackColor == b52.BackColor && b52.BackColor == b62.BackColor && b62.BackColor == b72.BackColor && b42.BackColor != Color.OldLace) ||
                (b13.BackColor == b23.BackColor && b23.BackColor == b33.BackColor && b33.BackColor == b43.BackColor && b13.BackColor != Color.OldLace) ||
                (b23.BackColor == b33.BackColor && b33.BackColor == b43.BackColor && b43.BackColor == b53.BackColor && b23.BackColor != Color.OldLace) ||
                (b33.BackColor == b43.BackColor && b43.BackColor == b53.BackColor && b53.BackColor == b63.BackColor && b33.BackColor != Color.OldLace) ||
                (b43.BackColor == b53.BackColor && b53.BackColor == b63.BackColor && b63.BackColor == b73.BackColor && b43.BackColor != Color.OldLace) ||
                (b14.BackColor == b24.BackColor && b24.BackColor == b34.BackColor && b34.BackColor == b44.BackColor && b14.BackColor != Color.OldLace) ||
                (b24.BackColor == b34.BackColor && b34.BackColor == b44.BackColor && b44.BackColor == b54.BackColor && b24.BackColor != Color.OldLace) ||
                (b34.BackColor == b44.BackColor && b44.BackColor == b54.BackColor && b54.BackColor == b64.BackColor && b34.BackColor != Color.OldLace) ||
                (b44.BackColor == b54.BackColor && b54.BackColor == b64.BackColor && b64.BackColor == b74.BackColor && b44.BackColor != Color.OldLace) ||
                (b15.BackColor == b25.BackColor && b25.BackColor == b35.BackColor && b35.BackColor == b45.BackColor && b15.BackColor != Color.OldLace) ||
                (b25.BackColor == b35.BackColor && b35.BackColor == b45.BackColor && b45.BackColor == b55.BackColor && b25.BackColor != Color.OldLace) ||
                (b35.BackColor == b45.BackColor && b45.BackColor == b55.BackColor && b55.BackColor == b65.BackColor && b35.BackColor != Color.OldLace) ||
                (b45.BackColor == b55.BackColor && b55.BackColor == b65.BackColor && b65.BackColor == b75.BackColor && b45.BackColor != Color.OldLace) ||
                (b16.BackColor == b26.BackColor && b26.BackColor == b36.BackColor && b36.BackColor == b46.BackColor && b16.BackColor != Color.OldLace) ||
                (b26.BackColor == b36.BackColor && b36.BackColor == b46.BackColor && b46.BackColor == b56.BackColor && b26.BackColor != Color.OldLace) ||
                (b36.BackColor == b46.BackColor && b46.BackColor == b56.BackColor && b56.BackColor == b66.BackColor && b36.BackColor != Color.OldLace) ||
                (b46.BackColor == b56.BackColor && b56.BackColor == b66.BackColor && b66.BackColor == b76.BackColor && b46.BackColor != Color.OldLace) ||
            #endregion
            #region Columns
                (b11.BackColor == b12.BackColor && b12.BackColor == b13.BackColor && b13.BackColor == b14.BackColor && b11.BackColor != Color.OldLace) ||
                (b12.BackColor == b13.BackColor && b13.BackColor == b14.BackColor && b14.BackColor == b15.BackColor && b12.BackColor != Color.OldLace) ||
                (b13.BackColor == b14.BackColor && b14.BackColor == b15.BackColor && b15.BackColor == b16.BackColor && b13.BackColor != Color.OldLace) ||
                (b21.BackColor == b22.BackColor && b22.BackColor == b23.BackColor && b23.BackColor == b24.BackColor && b21.BackColor != Color.OldLace) ||
                (b22.BackColor == b23.BackColor && b23.BackColor == b24.BackColor && b24.BackColor == b25.BackColor && b22.BackColor != Color.OldLace) ||
                (b23.BackColor == b24.BackColor && b24.BackColor == b25.BackColor && b25.BackColor == b26.BackColor && b23.BackColor != Color.OldLace) ||
                (b31.BackColor == b32.BackColor && b32.BackColor == b33.BackColor && b33.BackColor == b34.BackColor && b31.BackColor != Color.OldLace) ||
                (b32.BackColor == b33.BackColor && b33.BackColor == b34.BackColor && b34.BackColor == b35.BackColor && b32.BackColor != Color.OldLace) ||
                (b33.BackColor == b34.BackColor && b34.BackColor == b35.BackColor && b35.BackColor == b36.BackColor && b33.BackColor != Color.OldLace) ||
                (b41.BackColor == b42.BackColor && b42.BackColor == b43.BackColor && b43.BackColor == b44.BackColor && b41.BackColor != Color.OldLace) ||
                (b42.BackColor == b43.BackColor && b43.BackColor == b44.BackColor && b44.BackColor == b45.BackColor && b42.BackColor != Color.OldLace) ||
                (b43.BackColor == b44.BackColor && b44.BackColor == b45.BackColor && b45.BackColor == b46.BackColor && b43.BackColor != Color.OldLace) ||
                (b51.BackColor == b52.BackColor && b52.BackColor == b53.BackColor && b53.BackColor == b54.BackColor && b51.BackColor != Color.OldLace) ||
                (b52.BackColor == b53.BackColor && b53.BackColor == b54.BackColor && b54.BackColor == b55.BackColor && b52.BackColor != Color.OldLace) ||
                (b53.BackColor == b54.BackColor && b54.BackColor == b55.BackColor && b55.BackColor == b56.BackColor && b53.BackColor != Color.OldLace) ||
                (b61.BackColor == b62.BackColor && b62.BackColor == b63.BackColor && b63.BackColor == b64.BackColor && b61.BackColor != Color.OldLace) ||
                (b62.BackColor == b63.BackColor && b63.BackColor == b64.BackColor && b64.BackColor == b65.BackColor && b62.BackColor != Color.OldLace) ||
                (b63.BackColor == b64.BackColor && b64.BackColor == b65.BackColor && b65.BackColor == b66.BackColor && b63.BackColor != Color.OldLace) ||
                (b71.BackColor == b72.BackColor && b72.BackColor == b73.BackColor && b73.BackColor == b74.BackColor && b71.BackColor != Color.OldLace) ||
                (b72.BackColor == b73.BackColor && b73.BackColor == b74.BackColor && b74.BackColor == b75.BackColor && b72.BackColor != Color.OldLace) ||
                (b73.BackColor == b74.BackColor && b74.BackColor == b75.BackColor && b75.BackColor == b76.BackColor && b73.BackColor != Color.OldLace) ||
            #endregion
            #region Diagonals Right
                (b11.BackColor == b22.BackColor && b22.BackColor == b33.BackColor && b33.BackColor == b44.BackColor && b11.BackColor != Color.OldLace) ||
                (b12.BackColor == b23.BackColor && b23.BackColor == b34.BackColor && b34.BackColor == b45.BackColor && b12.BackColor != Color.OldLace) ||
                (b13.BackColor == b24.BackColor && b24.BackColor == b35.BackColor && b35.BackColor == b46.BackColor && b13.BackColor != Color.OldLace) ||
                (b21.BackColor == b32.BackColor && b32.BackColor == b43.BackColor && b43.BackColor == b54.BackColor && b21.BackColor != Color.OldLace) ||
                (b22.BackColor == b33.BackColor && b33.BackColor == b44.BackColor && b44.BackColor == b55.BackColor && b22.BackColor != Color.OldLace) ||
                (b23.BackColor == b34.BackColor && b34.BackColor == b45.BackColor && b45.BackColor == b56.BackColor && b23.BackColor != Color.OldLace) ||
                (b31.BackColor == b42.BackColor && b42.BackColor == b53.BackColor && b53.BackColor == b64.BackColor && b31.BackColor != Color.OldLace) ||
                (b32.BackColor == b43.BackColor && b43.BackColor == b54.BackColor && b54.BackColor == b65.BackColor && b32.BackColor != Color.OldLace) ||
                (b33.BackColor == b44.BackColor && b44.BackColor == b55.BackColor && b55.BackColor == b66.BackColor && b33.BackColor != Color.OldLace) ||
                (b41.BackColor == b52.BackColor && b52.BackColor == b63.BackColor && b63.BackColor == b74.BackColor && b41.BackColor != Color.OldLace) ||
                (b42.BackColor == b53.BackColor && b53.BackColor == b64.BackColor && b64.BackColor == b75.BackColor && b42.BackColor != Color.OldLace) ||
                (b43.BackColor == b54.BackColor && b54.BackColor == b65.BackColor && b65.BackColor == b76.BackColor && b43.BackColor != Color.OldLace) ||
            #endregion
            #region Diagonals Left
                (b71.BackColor == b62.BackColor && b62.BackColor == b53.BackColor && b53.BackColor == b44.BackColor && b71.BackColor != Color.OldLace) ||
                (b72.BackColor == b63.BackColor && b63.BackColor == b54.BackColor && b54.BackColor == b45.BackColor && b72.BackColor != Color.OldLace) ||
                (b73.BackColor == b64.BackColor && b64.BackColor == b55.BackColor && b55.BackColor == b46.BackColor && b73.BackColor != Color.OldLace) ||
                (b61.BackColor == b52.BackColor && b52.BackColor == b43.BackColor && b43.BackColor == b34.BackColor && b61.BackColor != Color.OldLace) ||
                (b62.BackColor == b53.BackColor && b53.BackColor == b44.BackColor && b44.BackColor == b35.BackColor && b62.BackColor != Color.OldLace) ||
                (b63.BackColor == b54.BackColor && b54.BackColor == b45.BackColor && b45.BackColor == b36.BackColor && b63.BackColor != Color.OldLace) ||
                (b51.BackColor == b42.BackColor && b42.BackColor == b33.BackColor && b33.BackColor == b24.BackColor && b51.BackColor != Color.OldLace) ||
                (b52.BackColor == b43.BackColor && b43.BackColor == b34.BackColor && b34.BackColor == b25.BackColor && b52.BackColor != Color.OldLace) ||
                (b53.BackColor == b44.BackColor && b44.BackColor == b36.BackColor && b36.BackColor == b26.BackColor && b53.BackColor != Color.OldLace) ||
                (b41.BackColor == b32.BackColor && b32.BackColor == b23.BackColor && b23.BackColor == b14.BackColor && b41.BackColor != Color.OldLace) ||
                (b42.BackColor == b33.BackColor && b33.BackColor == b24.BackColor && b24.BackColor == b15.BackColor && b42.BackColor != Color.OldLace) ||
                (b43.BackColor == b34.BackColor && b34.BackColor == b25.BackColor && b25.BackColor == b16.BackColor && b43.BackColor != Color.OldLace))
            #endregion
            {
                gameEnded = true;

                if (whoWon == "Red")
                {
                    R++;
                    lblRedScore.Text = $"Red : {R}";
                    icon = MessageBoxIcon.Error;
                }
                else if (whoWon == "Yellow")
                {
                    Y++;
                    lblYellowScore.Text = $"Yellow : {Y}";
                    icon = MessageBoxIcon.Warning;
                }

                DialogResult result;
                result = MessageBox.Show($"{whoWon} Won The Game !!!\nStart a New Game ?", $"{whoWon} Wins", MessageBoxButtons.YesNo, icon);
                if (result == DialogResult.Yes)
                    btnRestart.PerformClick();
            }

            if (moveCounter == 42 && gameEnded == false)
            {
                DialogResult result;
                result = MessageBox.Show("Game Ended In a Draw !!!\nStart a New Game ?", "Draw", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                    btnRestart.PerformClick();
            }
        }

        private void UpdateStatus()
        {
            lblMove.Text = $"Move : {moveCounter}";
            btnTurn.BackColor = turn;
            btnTurn.FlatAppearance.MouseOverBackColor = turn;
            btnTurn.FlatAppearance.MouseDownBackColor = turn;
        }

        private void btnHow_Click(object sender, EventArgs e)
        {
            if (how == null)
            {
                how = new HowToPlay(this.Location, this.Size);
                how.Show();
            }
            else
            {
                how.Hide();
                how = new HowToPlay(this.Location, this.Size);
                how.Show();
                how.Activate();
            }
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            if (info == null)
            {
                info = new Info(this.Location, this.Size);
                info.Show();
            }
            else
            {
                info.Hide();
                info = new Info(this.Location, this.Size);
                info.Show();
                info.Activate();
            }
        }
    }
}