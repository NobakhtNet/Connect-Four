using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Connect_Four
{
    public partial class ConnectFour : Form
    {
        Color turn = Color.Red;
        Color theme = Color.OldLace;
        int a, b, c, d, f, g, h, R, Y, moveCounter;
        string whoWon = "Yellow";
        bool redStarts, gameEnded = false;
        char[] letters = new char[3];
        List<Button> buttons = new List<Button>();
        List<Button> redo = new List<Button>();
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
            if (gameEnded == false && a < 6)
            {
                if (b11.BackColor == theme)
                {
                    b11.BackColor = turn;
                    b11.FlatAppearance.MouseOverBackColor = turn;
                    b11.FlatAppearance.MouseDownBackColor = turn;
                    buttons.Add(b11);
                }
                else if (b12.BackColor == theme)
                {
                    b12.BackColor = turn;
                    b12.FlatAppearance.MouseOverBackColor = turn;
                    b12.FlatAppearance.MouseDownBackColor = turn;
                    buttons.Add(b12);
                }
                else if (b13.BackColor == theme)
                {
                    b13.BackColor = turn;
                    b13.FlatAppearance.MouseOverBackColor = turn;
                    b13.FlatAppearance.MouseDownBackColor = turn;
                    buttons.Add(b13);
                }
                else if (b14.BackColor == theme)
                {
                    b14.BackColor = turn;
                    b14.FlatAppearance.MouseOverBackColor = turn;
                    b14.FlatAppearance.MouseDownBackColor = turn;
                    buttons.Add(b14);
                }
                else if (b15.BackColor == theme)
                {
                    b15.BackColor = turn;
                    b15.FlatAppearance.MouseOverBackColor = turn;
                    b15.FlatAppearance.MouseDownBackColor = turn;
                    buttons.Add(b15);
                }
                else if (b16.BackColor == theme)
                {
                    b16.BackColor = turn;
                    b16.FlatAppearance.MouseOverBackColor = turn;
                    b16.FlatAppearance.MouseDownBackColor = turn;
                    buttons.Add(b16);
                }
                a++;
                moveCounter++;
                redo.Clear();

                changeTurn();
                CheckForWinner();
            }
        }

        private void BtnColumn2_Click(object sender, EventArgs e)
        {
            if (gameEnded == false && b < 6)
            {
                if (b21.BackColor == theme)
                {
                    b21.BackColor = turn;
                    b21.FlatAppearance.MouseOverBackColor = turn;
                    b21.FlatAppearance.MouseDownBackColor = turn;
                    buttons.Add(b21);
                }
                else if (b22.BackColor == theme)
                {
                    b22.BackColor = turn;
                    b22.FlatAppearance.MouseOverBackColor = turn;
                    b22.FlatAppearance.MouseDownBackColor = turn;
                    buttons.Add(b22);
                }
                else if (b23.BackColor == theme)
                {
                    b23.BackColor = turn;
                    b23.FlatAppearance.MouseOverBackColor = turn;
                    b23.FlatAppearance.MouseDownBackColor = turn;
                    buttons.Add(b23);
                }
                else if (b24.BackColor == theme)
                {
                    b24.BackColor = turn;
                    b24.FlatAppearance.MouseOverBackColor = turn;
                    b24.FlatAppearance.MouseDownBackColor = turn;
                    buttons.Add(b24);
                }
                else if (b25.BackColor == theme)
                {
                    b25.BackColor = turn;
                    b25.FlatAppearance.MouseOverBackColor = turn;
                    b25.FlatAppearance.MouseDownBackColor = turn;
                    buttons.Add(b25);
                }
                else if (b26.BackColor == theme)
                {
                    b26.BackColor = turn;
                    b26.FlatAppearance.MouseOverBackColor = turn;
                    b26.FlatAppearance.MouseDownBackColor = turn;
                    buttons.Add(b26);
                }
                b++;
                moveCounter++;
                redo.Clear();

                changeTurn();
                CheckForWinner();
            }
        }

        private void BtnColumn3_Click(object sender, EventArgs e)
        {
            if (gameEnded == false && c < 6)
            {
                if (b31.BackColor == theme)
                {
                    b31.BackColor = turn;
                    b31.FlatAppearance.MouseOverBackColor = turn;
                    b31.FlatAppearance.MouseDownBackColor = turn;
                    buttons.Add(b31);
                }
                else if (b32.BackColor == theme)
                {
                    b32.BackColor = turn;
                    b32.FlatAppearance.MouseOverBackColor = turn;
                    b32.FlatAppearance.MouseDownBackColor = turn;
                    buttons.Add(b32);
                }
                else if (b33.BackColor == theme)
                {
                    b33.BackColor = turn;
                    b33.FlatAppearance.MouseOverBackColor = turn;
                    b33.FlatAppearance.MouseDownBackColor = turn;
                    buttons.Add(b33);
                }
                else if (b34.BackColor == theme)
                {
                    b34.BackColor = turn;
                    b34.FlatAppearance.MouseOverBackColor = turn;
                    b34.FlatAppearance.MouseDownBackColor = turn;
                    buttons.Add(b34);
                }
                else if (b35.BackColor == theme)
                {
                    b35.BackColor = turn;
                    b35.FlatAppearance.MouseOverBackColor = turn;
                    b35.FlatAppearance.MouseDownBackColor = turn;
                    buttons.Add(b35);
                }
                else if (b36.BackColor == theme)
                {
                    b36.BackColor = turn;
                    b36.FlatAppearance.MouseOverBackColor = turn;
                    b36.FlatAppearance.MouseDownBackColor = turn;
                    buttons.Add(b36);
                }
                c++;
                moveCounter++;
                redo.Clear();

                changeTurn();
                CheckForWinner();
            }
        }

        private void BtnColumn4_Click(object sender, EventArgs e)
        {
            if (gameEnded == false && d < 6)
            {
                if (b41.BackColor == theme)
                {
                    b41.BackColor = turn;
                    b41.FlatAppearance.MouseOverBackColor = turn;
                    b41.FlatAppearance.MouseDownBackColor = turn;
                    buttons.Add(b41);
                }
                else if (b42.BackColor == theme)
                {
                    b42.BackColor = turn;
                    b42.FlatAppearance.MouseOverBackColor = turn;
                    b42.FlatAppearance.MouseDownBackColor = turn;
                    buttons.Add(b42);
                }
                else if (b43.BackColor == theme)
                {
                    b43.BackColor = turn;
                    b43.FlatAppearance.MouseOverBackColor = turn;
                    b43.FlatAppearance.MouseDownBackColor = turn;
                    buttons.Add(b43);
                }
                else if (b44.BackColor == theme)
                {
                    b44.BackColor = turn;
                    b44.FlatAppearance.MouseOverBackColor = turn;
                    b44.FlatAppearance.MouseDownBackColor = turn;
                    buttons.Add(b44);
                }
                else if (b45.BackColor == theme)
                {
                    b45.BackColor = turn;
                    b45.FlatAppearance.MouseOverBackColor = turn;
                    b45.FlatAppearance.MouseDownBackColor = turn;
                    buttons.Add(b45);
                }
                else if (b46.BackColor == theme)
                {
                    b46.BackColor = turn;
                    b46.FlatAppearance.MouseOverBackColor = turn;
                    b46.FlatAppearance.MouseDownBackColor = turn;
                    buttons.Add(b46);
                }
                d++;
                moveCounter++;
                redo.Clear();

                changeTurn();
                CheckForWinner();
            }
        }

        private void BtnColumn5_Click(object sender, EventArgs e)
        {
            if (gameEnded == false && f < 6)
            {
                if (b51.BackColor == theme)
                {
                    b51.BackColor = turn;
                    b51.FlatAppearance.MouseOverBackColor = turn;
                    b51.FlatAppearance.MouseDownBackColor = turn;
                    buttons.Add(b51);
                }
                else if (b52.BackColor == theme)
                {
                    b52.BackColor = turn;
                    b52.FlatAppearance.MouseOverBackColor = turn;
                    b52.FlatAppearance.MouseDownBackColor = turn;
                    buttons.Add(b52);
                }
                else if (b53.BackColor == theme)
                {
                    b53.BackColor = turn;
                    b53.FlatAppearance.MouseOverBackColor = turn;
                    b53.FlatAppearance.MouseDownBackColor = turn;
                    buttons.Add(b53);
                }
                else if (b54.BackColor == theme)
                {
                    b54.BackColor = turn;
                    b54.FlatAppearance.MouseOverBackColor = turn;
                    b54.FlatAppearance.MouseDownBackColor = turn;
                    buttons.Add(b54);
                }
                else if (b55.BackColor == theme)
                {
                    b55.BackColor = turn;
                    b55.FlatAppearance.MouseOverBackColor = turn;
                    b55.FlatAppearance.MouseDownBackColor = turn;
                    buttons.Add(b55);
                }
                else if (b56.BackColor == theme)
                {
                    b56.BackColor = turn;
                    b56.FlatAppearance.MouseOverBackColor = turn;
                    b56.FlatAppearance.MouseDownBackColor = turn;
                    buttons.Add(b56);
                }
                f++;
                moveCounter++;
                redo.Clear();

                changeTurn();
                CheckForWinner();
            }
        }

        private void btnColumn6_Click(object sender, EventArgs e)
        {
            if (gameEnded == false && g < 6)
            {
                if (b61.BackColor == theme)
                {
                    b61.BackColor = turn;
                    b61.FlatAppearance.MouseOverBackColor = turn;
                    b61.FlatAppearance.MouseDownBackColor = turn;
                    buttons.Add(b61);
                }
                else if (b62.BackColor == theme)
                {
                    b62.BackColor = turn;
                    b62.FlatAppearance.MouseOverBackColor = turn;
                    b62.FlatAppearance.MouseDownBackColor = turn;
                    buttons.Add(b62);
                }
                else if (b63.BackColor == theme)
                {
                    b63.BackColor = turn;
                    b63.FlatAppearance.MouseOverBackColor = turn;
                    b63.FlatAppearance.MouseDownBackColor = turn;
                    buttons.Add(b63);
                }
                else if (b64.BackColor == theme)
                {
                    b64.BackColor = turn;
                    b64.FlatAppearance.MouseOverBackColor = turn;
                    b64.FlatAppearance.MouseDownBackColor = turn;
                    buttons.Add(b64);
                }
                else if (b65.BackColor == theme)
                {
                    b65.BackColor = turn;
                    b65.FlatAppearance.MouseOverBackColor = turn;
                    b65.FlatAppearance.MouseDownBackColor = turn;
                    buttons.Add(b65);
                }
                else if (b66.BackColor == theme)
                {
                    b66.BackColor = turn;
                    b66.FlatAppearance.MouseOverBackColor = turn;
                    b66.FlatAppearance.MouseDownBackColor = turn;
                    buttons.Add(b66);
                }
                g++;
                moveCounter++;
                redo.Clear();

                changeTurn();
                CheckForWinner();
            }
        }

        private void btnColumn7_Click(object sender, EventArgs e)
        {
            if (gameEnded == false && h < 6)
            {
                if (b71.BackColor == theme)
                {
                    b71.BackColor = turn;
                    b71.FlatAppearance.MouseOverBackColor = turn;
                    b71.FlatAppearance.MouseDownBackColor = turn;
                    buttons.Add(b71);
                }
                else if (b72.BackColor == theme)
                {
                    b72.BackColor = turn;
                    b72.FlatAppearance.MouseOverBackColor = turn;
                    b72.FlatAppearance.MouseDownBackColor = turn;
                    buttons.Add(b72);
                }
                else if (b73.BackColor == theme)
                {
                    b73.BackColor = turn;
                    b73.FlatAppearance.MouseOverBackColor = turn;
                    b73.FlatAppearance.MouseDownBackColor = turn;
                    buttons.Add(b73);
                }
                else if (b74.BackColor == theme)
                {
                    b74.BackColor = turn;
                    b74.FlatAppearance.MouseOverBackColor = turn;
                    b74.FlatAppearance.MouseDownBackColor = turn;
                    buttons.Add(b74);
                }
                else if (b75.BackColor == theme)
                {
                    b75.BackColor = turn;
                    b75.FlatAppearance.MouseOverBackColor = turn;
                    b75.FlatAppearance.MouseDownBackColor = turn;
                    buttons.Add(b75);
                }
                else if (b76.BackColor == theme)
                {
                    b76.BackColor = turn;
                    b76.FlatAppearance.MouseOverBackColor = turn;
                    b76.FlatAppearance.MouseDownBackColor = turn;
                    buttons.Add(b76);
                }
                h++;
                moveCounter++;
                redo.Clear();

                changeTurn();
                CheckForWinner();
            }
        }

        private void bUndo_Click(object sender, EventArgs e)
        {
            if (moveCounter > 0 && buttons.Count != 0)
            {
                if (buttons.Last() == b11 || buttons.Last() == b12 || buttons.Last() == b13 || buttons.Last() == b14 || buttons.Last() == b15 || buttons.Last() == b16)
                {
                    a--;
                }
                else if (buttons.Last() == b21 || buttons.Last() == b22 || buttons.Last() == b23 || buttons.Last() == b24 || buttons.Last() == b25 || buttons.Last() == b26)
                {
                    b--;
                }
                else if (buttons.Last() == b31 || buttons.Last() == b32 || buttons.Last() == b33 || buttons.Last() == b34 || buttons.Last() == b35 || buttons.Last() == b36)
                {
                    c--;
                }
                else if (buttons.Last() == b41 || buttons.Last() == b42 || buttons.Last() == b43 || buttons.Last() == b44 || buttons.Last() == b45 || buttons.Last() == b46)
                {
                    d--;
                }
                else if (buttons.Last() == b51 || buttons.Last() == b52 || buttons.Last() == b53 || buttons.Last() == b54 || buttons.Last() == b55 || buttons.Last() == b56)
                {
                    f--;
                }
                else if (buttons.Last() == b61 || buttons.Last() == b62 || buttons.Last() == b63 || buttons.Last() == b64 || buttons.Last() == b65 || buttons.Last() == b66)
                {
                    g--;
                }
                else if (buttons.Last() == b71 || buttons.Last() == b72 || buttons.Last() == b73 || buttons.Last() == b74 || buttons.Last() == b75 || buttons.Last() == b76)
                {
                    h--;
                }

                buttons.Last().BackColor = theme;
                buttons.Last().FlatAppearance.MouseOverBackColor = theme;
                buttons.Last().FlatAppearance.MouseDownBackColor = theme;
                redo.Add(buttons.Last());
                buttons.RemoveAt(buttons.Count - 1);
                moveCounter--;

                changeTurn();
            }
        }

        private void bRedo_Click(object sender, EventArgs e)
        {
            if (redo.Count != 0)
            {
                redo.Last().BackColor = turn;
                redo.Last().FlatAppearance.MouseOverBackColor = turn;
                redo.Last().FlatAppearance.MouseDownBackColor = turn;
                buttons.Add(redo.Last());
                redo.RemoveAt(redo.Count - 1);
                moveCounter++;

                changeTurn();
            }
        }

        private void ConnectFour_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.D1:
                case Keys.NumPad1:
                    b11.PerformClick();
                    break;
                case Keys.D2:
                case Keys.NumPad2:
                    b21.PerformClick();
                    break;
                case Keys.D3:
                case Keys.NumPad3:
                    b31.PerformClick();
                    break;
                case Keys.D4:
                case Keys.NumPad4:
                    b41.PerformClick();
                    break;
                case Keys.D5:
                case Keys.NumPad5:
                    b51.PerformClick();
                    break;
                case Keys.D6:
                case Keys.NumPad6:
                    b61.PerformClick();
                    break;
                case Keys.D7:
                case Keys.NumPad7:
                    b71.PerformClick();
                    break;
                case Keys.R:
                    btnRestart.PerformClick();
                    break;
                default:
                    break;
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Left:
                    bUndo.PerformClick();
                    break;
                case Keys.Right:
                    bRedo.PerformClick();
                    break;
                default:
                    break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void changeTurn()
        {
            if (turn == Color.Red)
                turn = Color.Yellow;
            else
                turn = Color.Red;

            if (whoWon == "Red")
                whoWon = "Yellow";
            else
                whoWon = "Red";

            UpdateStatus();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            foreach (Button b in tblConnect4.Controls)
            {
                if (b.BackColor != theme)
                {
                    b.BackColor = theme;
                    b.FlatAppearance.MouseOverBackColor = theme;
                    b.FlatAppearance.MouseDownBackColor = theme;
                }
            }
            a = 0; b = 0; c = 0; d = 0; f = 0; g = 0; h = 0; moveCounter = 0;
            gameEnded = false;
            buttons.Clear();
            redo.Clear();

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
            if ((b11.BackColor == b21.BackColor && b21.BackColor == b31.BackColor && b31.BackColor == b41.BackColor && b11.BackColor != theme) ||
                (b21.BackColor == b31.BackColor && b31.BackColor == b41.BackColor && b41.BackColor == b51.BackColor && b21.BackColor != theme) ||
                (b31.BackColor == b41.BackColor && b41.BackColor == b51.BackColor && b51.BackColor == b61.BackColor && b31.BackColor != theme) ||
                (b41.BackColor == b51.BackColor && b51.BackColor == b61.BackColor && b61.BackColor == b71.BackColor && b41.BackColor != theme) ||
                (b12.BackColor == b22.BackColor && b22.BackColor == b32.BackColor && b32.BackColor == b42.BackColor && b12.BackColor != theme) ||
                (b22.BackColor == b32.BackColor && b32.BackColor == b42.BackColor && b42.BackColor == b52.BackColor && b22.BackColor != theme) ||
                (b32.BackColor == b42.BackColor && b42.BackColor == b52.BackColor && b52.BackColor == b62.BackColor && b32.BackColor != theme) ||
                (b42.BackColor == b52.BackColor && b52.BackColor == b62.BackColor && b62.BackColor == b72.BackColor && b42.BackColor != theme) ||
                (b13.BackColor == b23.BackColor && b23.BackColor == b33.BackColor && b33.BackColor == b43.BackColor && b13.BackColor != theme) ||
                (b23.BackColor == b33.BackColor && b33.BackColor == b43.BackColor && b43.BackColor == b53.BackColor && b23.BackColor != theme) ||
                (b33.BackColor == b43.BackColor && b43.BackColor == b53.BackColor && b53.BackColor == b63.BackColor && b33.BackColor != theme) ||
                (b43.BackColor == b53.BackColor && b53.BackColor == b63.BackColor && b63.BackColor == b73.BackColor && b43.BackColor != theme) ||
                (b14.BackColor == b24.BackColor && b24.BackColor == b34.BackColor && b34.BackColor == b44.BackColor && b14.BackColor != theme) ||
                (b24.BackColor == b34.BackColor && b34.BackColor == b44.BackColor && b44.BackColor == b54.BackColor && b24.BackColor != theme) ||
                (b34.BackColor == b44.BackColor && b44.BackColor == b54.BackColor && b54.BackColor == b64.BackColor && b34.BackColor != theme) ||
                (b44.BackColor == b54.BackColor && b54.BackColor == b64.BackColor && b64.BackColor == b74.BackColor && b44.BackColor != theme) ||
                (b15.BackColor == b25.BackColor && b25.BackColor == b35.BackColor && b35.BackColor == b45.BackColor && b15.BackColor != theme) ||
                (b25.BackColor == b35.BackColor && b35.BackColor == b45.BackColor && b45.BackColor == b55.BackColor && b25.BackColor != theme) ||
                (b35.BackColor == b45.BackColor && b45.BackColor == b55.BackColor && b55.BackColor == b65.BackColor && b35.BackColor != theme) ||
                (b45.BackColor == b55.BackColor && b55.BackColor == b65.BackColor && b65.BackColor == b75.BackColor && b45.BackColor != theme) ||
                (b16.BackColor == b26.BackColor && b26.BackColor == b36.BackColor && b36.BackColor == b46.BackColor && b16.BackColor != theme) ||
                (b26.BackColor == b36.BackColor && b36.BackColor == b46.BackColor && b46.BackColor == b56.BackColor && b26.BackColor != theme) ||
                (b36.BackColor == b46.BackColor && b46.BackColor == b56.BackColor && b56.BackColor == b66.BackColor && b36.BackColor != theme) ||
                (b46.BackColor == b56.BackColor && b56.BackColor == b66.BackColor && b66.BackColor == b76.BackColor && b46.BackColor != theme) ||
            #endregion
            #region Columns
                (b11.BackColor == b12.BackColor && b12.BackColor == b13.BackColor && b13.BackColor == b14.BackColor && b11.BackColor != theme) ||
                (b12.BackColor == b13.BackColor && b13.BackColor == b14.BackColor && b14.BackColor == b15.BackColor && b12.BackColor != theme) ||
                (b13.BackColor == b14.BackColor && b14.BackColor == b15.BackColor && b15.BackColor == b16.BackColor && b13.BackColor != theme) ||
                (b21.BackColor == b22.BackColor && b22.BackColor == b23.BackColor && b23.BackColor == b24.BackColor && b21.BackColor != theme) ||
                (b22.BackColor == b23.BackColor && b23.BackColor == b24.BackColor && b24.BackColor == b25.BackColor && b22.BackColor != theme) ||
                (b23.BackColor == b24.BackColor && b24.BackColor == b25.BackColor && b25.BackColor == b26.BackColor && b23.BackColor != theme) ||
                (b31.BackColor == b32.BackColor && b32.BackColor == b33.BackColor && b33.BackColor == b34.BackColor && b31.BackColor != theme) ||
                (b32.BackColor == b33.BackColor && b33.BackColor == b34.BackColor && b34.BackColor == b35.BackColor && b32.BackColor != theme) ||
                (b33.BackColor == b34.BackColor && b34.BackColor == b35.BackColor && b35.BackColor == b36.BackColor && b33.BackColor != theme) ||
                (b41.BackColor == b42.BackColor && b42.BackColor == b43.BackColor && b43.BackColor == b44.BackColor && b41.BackColor != theme) ||
                (b42.BackColor == b43.BackColor && b43.BackColor == b44.BackColor && b44.BackColor == b45.BackColor && b42.BackColor != theme) ||
                (b43.BackColor == b44.BackColor && b44.BackColor == b45.BackColor && b45.BackColor == b46.BackColor && b43.BackColor != theme) ||
                (b51.BackColor == b52.BackColor && b52.BackColor == b53.BackColor && b53.BackColor == b54.BackColor && b51.BackColor != theme) ||
                (b52.BackColor == b53.BackColor && b53.BackColor == b54.BackColor && b54.BackColor == b55.BackColor && b52.BackColor != theme) ||
                (b53.BackColor == b54.BackColor && b54.BackColor == b55.BackColor && b55.BackColor == b56.BackColor && b53.BackColor != theme) ||
                (b61.BackColor == b62.BackColor && b62.BackColor == b63.BackColor && b63.BackColor == b64.BackColor && b61.BackColor != theme) ||
                (b62.BackColor == b63.BackColor && b63.BackColor == b64.BackColor && b64.BackColor == b65.BackColor && b62.BackColor != theme) ||
                (b63.BackColor == b64.BackColor && b64.BackColor == b65.BackColor && b65.BackColor == b66.BackColor && b63.BackColor != theme) ||
                (b71.BackColor == b72.BackColor && b72.BackColor == b73.BackColor && b73.BackColor == b74.BackColor && b71.BackColor != theme) ||
                (b72.BackColor == b73.BackColor && b73.BackColor == b74.BackColor && b74.BackColor == b75.BackColor && b72.BackColor != theme) ||
                (b73.BackColor == b74.BackColor && b74.BackColor == b75.BackColor && b75.BackColor == b76.BackColor && b73.BackColor != theme) ||
            #endregion
            #region Diagonals Right
                (b11.BackColor == b22.BackColor && b22.BackColor == b33.BackColor && b33.BackColor == b44.BackColor && b11.BackColor != theme) ||
                (b12.BackColor == b23.BackColor && b23.BackColor == b34.BackColor && b34.BackColor == b45.BackColor && b12.BackColor != theme) ||
                (b13.BackColor == b24.BackColor && b24.BackColor == b35.BackColor && b35.BackColor == b46.BackColor && b13.BackColor != theme) ||
                (b21.BackColor == b32.BackColor && b32.BackColor == b43.BackColor && b43.BackColor == b54.BackColor && b21.BackColor != theme) ||
                (b22.BackColor == b33.BackColor && b33.BackColor == b44.BackColor && b44.BackColor == b55.BackColor && b22.BackColor != theme) ||
                (b23.BackColor == b34.BackColor && b34.BackColor == b45.BackColor && b45.BackColor == b56.BackColor && b23.BackColor != theme) ||
                (b31.BackColor == b42.BackColor && b42.BackColor == b53.BackColor && b53.BackColor == b64.BackColor && b31.BackColor != theme) ||
                (b32.BackColor == b43.BackColor && b43.BackColor == b54.BackColor && b54.BackColor == b65.BackColor && b32.BackColor != theme) ||
                (b33.BackColor == b44.BackColor && b44.BackColor == b55.BackColor && b55.BackColor == b66.BackColor && b33.BackColor != theme) ||
                (b41.BackColor == b52.BackColor && b52.BackColor == b63.BackColor && b63.BackColor == b74.BackColor && b41.BackColor != theme) ||
                (b42.BackColor == b53.BackColor && b53.BackColor == b64.BackColor && b64.BackColor == b75.BackColor && b42.BackColor != theme) ||
                (b43.BackColor == b54.BackColor && b54.BackColor == b65.BackColor && b65.BackColor == b76.BackColor && b43.BackColor != theme) ||
            #endregion
            #region Diagonals Left
                (b71.BackColor == b62.BackColor && b62.BackColor == b53.BackColor && b53.BackColor == b44.BackColor && b71.BackColor != theme) ||
                (b72.BackColor == b63.BackColor && b63.BackColor == b54.BackColor && b54.BackColor == b45.BackColor && b72.BackColor != theme) ||
                (b73.BackColor == b64.BackColor && b64.BackColor == b55.BackColor && b55.BackColor == b46.BackColor && b73.BackColor != theme) ||
                (b61.BackColor == b52.BackColor && b52.BackColor == b43.BackColor && b43.BackColor == b34.BackColor && b61.BackColor != theme) ||
                (b62.BackColor == b53.BackColor && b53.BackColor == b44.BackColor && b44.BackColor == b35.BackColor && b62.BackColor != theme) ||
                (b63.BackColor == b54.BackColor && b54.BackColor == b45.BackColor && b45.BackColor == b36.BackColor && b63.BackColor != theme) ||
                (b51.BackColor == b42.BackColor && b42.BackColor == b33.BackColor && b33.BackColor == b24.BackColor && b51.BackColor != theme) ||
                (b52.BackColor == b43.BackColor && b43.BackColor == b34.BackColor && b34.BackColor == b25.BackColor && b52.BackColor != theme) ||
                (b53.BackColor == b44.BackColor && b44.BackColor == b35.BackColor && b35.BackColor == b26.BackColor && b53.BackColor != theme) ||
                (b41.BackColor == b32.BackColor && b32.BackColor == b23.BackColor && b23.BackColor == b14.BackColor && b41.BackColor != theme) ||
                (b42.BackColor == b33.BackColor && b33.BackColor == b24.BackColor && b24.BackColor == b15.BackColor && b42.BackColor != theme) ||
                (b43.BackColor == b34.BackColor && b34.BackColor == b25.BackColor && b25.BackColor == b16.BackColor && b43.BackColor != theme))
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
            if (buttons.Count != 0)
            {
                letters = buttons.Last().Name.ToCharArray();
                lblLastMove.Text = $"Last Move : C{letters[1]} R{letters[2]}";
            }
            else
                lblLastMove.Text = "Last Move : N/A";

            lblMove.Text = $"Move : {moveCounter}";
            btnTurn.BackColor = turn;
            btnTurn.FlatAppearance.MouseOverBackColor = turn;
            btnTurn.FlatAppearance.MouseDownBackColor = turn;
        }

        private void btnTheme_Click(object sender, EventArgs e)
        {
            if (theme == Color.OldLace)
            {
                theme = Color.FromArgb(35, 35, 35);

                #region Change Button Color
                pnlInfo.BackColor = theme;
                pnlInfo.ForeColor = Color.WhiteSmoke;
                btnRestart.BackColor = Color.Gray;
                btnInfo.BackColor = Color.Gray;
                btnHow.BackColor = Color.Gray;
                btnRestart.ForeColor = Color.Black;
                btnInfo.ForeColor = Color.Black;
                btnHow.ForeColor = Color.Black;
                bUndo.BackColor = Color.DimGray;
                bRedo.BackColor = Color.DimGray;
                btnTheme.BackColor = Color.DimGray;
                bUndo.FlatAppearance.BorderColor = Color.Gray;
                bRedo.FlatAppearance.BorderColor = Color.Gray;
                btnTheme.FlatAppearance.BorderColor = Color.Gray;
                lblYellowScore.ForeColor = Color.Gold;
                lblLine.BackColor = Color.Gray;
                #endregion

                foreach (Button b in tblConnect4.Controls)
                {
                    if (b.BackColor == Color.OldLace)
                    {
                        b.BackColor = theme;
                        b.FlatAppearance.MouseOverBackColor = theme;
                        b.FlatAppearance.MouseDownBackColor = theme;
                    }
                }

                CustomWindow(Color.FromArgb(45, 45, 45), Handle);
            }
            else
            {
                theme = Color.OldLace;

                #region Change Button Color
                pnlInfo.BackColor = theme;
                pnlInfo.ForeColor = Color.Black;
                btnRestart.BackColor = Color.White;
                btnInfo.BackColor = Color.White;
                btnHow.BackColor = Color.White;
                bUndo.BackColor = Color.Bisque;
                bRedo.BackColor = Color.Bisque;
                btnTheme.BackColor = Color.Bisque;
                bUndo.FlatAppearance.BorderColor = Color.DarkKhaki;
                bRedo.FlatAppearance.BorderColor = Color.DarkKhaki;
                btnTheme.FlatAppearance.BorderColor = Color.DarkKhaki;
                lblYellowScore.ForeColor = Color.DarkGoldenrod;
                lblLine.BackColor = Color.Black;
                #endregion

                foreach (Button b in tblConnect4.Controls)
                {
                    if (b.BackColor == Color.FromArgb(35, 35, 35))
                    {
                        b.BackColor = theme;
                        b.FlatAppearance.MouseOverBackColor = theme;
                        b.FlatAppearance.MouseDownBackColor = theme;
                    }
                }

                CustomWindow(Color.Bisque, Handle);
            }
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