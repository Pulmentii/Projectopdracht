using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nani
{
    public partial class Game : Form
    {
        // Windows api shit
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (!msg.HWnd.Equals(Handle) &&
                (keyData == Keys.W || keyData == Keys.A ||
                 keyData == Keys.S || keyData == Keys.D))
                return true;
            return base.ProcessCmdKey(ref msg, keyData);
        }


        // My shit
        bool isJumping = false;
        bool isGrounded = false;
        int maxJumpTime = 25;
        public Game()
        {
            InitializeComponent();
            
        }

        private void tmrGrav_Tick(object sender, EventArgs e)
        {
            if (objPlayer.Bounds.IntersectsWith(objFloor.Bounds))
            {
                isGrounded = true;
            }
            if (!objPlayer.Bounds.IntersectsWith(objFloor.Bounds) && !isJumping)
            {
                isGrounded = false;
                objPlayer.Top += 10;
            }
        }

        private void tmrUp_Tick(object sender, EventArgs e)
        {
            if (isGrounded)
            {
                if (maxJumpTime >= 0)
                {
                    objPlayer.Top -= 10;
                    isJumping = true;
                    maxJumpTime--;
                }
                else
                {
                    isJumping = false;
                    tmrUp.Stop();
                }
            }
        }

        private void tmrRight_Tick(object sender, EventArgs e)
        {
            objPlayer.Left += 10;
        }

        private void tmrLeft_Tick(object sender, EventArgs e)
        {
            objPlayer.Left -= 10;
        }

        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    tmrUp.Start();
                    break;
                case Keys.D:
                    tmrRight.Start();
                    break;
                case Keys.A:
                    tmrLeft.Start();
                    break;
            }
        }

        private void Game_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    tmrUp.Stop();
                    isJumping = false;
                    maxJumpTime = 25;
                    break;
                case Keys.D:
                    tmrRight.Stop();
                    break;
                case Keys.A:
                    tmrLeft.Stop();
                    break;

            }
        }

        private void objFloor_Paint(object sender, PaintEventArgs e)
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(Game));
            Image image = ((Image)(resources.GetObject("objFloor.Image")));
            TextureBrush tBrush = new TextureBrush(image);
            e.Graphics.FillRectangle(tBrush, new Rectangle(0, 0, 99999, 50));
        }

        private void menubar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnClose_MouseClick(object sender, MouseEventArgs e)
        {
            Environment.Exit(0);
        }

    }
}
