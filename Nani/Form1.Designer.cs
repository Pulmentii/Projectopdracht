namespace Nani
{
    partial class Game
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.objFloor = new System.Windows.Forms.PictureBox();
            this.tmrGrav = new System.Windows.Forms.Timer(this.components);
            this.objPlayer = new System.Windows.Forms.PictureBox();
            this.tmrUp = new System.Windows.Forms.Timer(this.components);
            this.tmrRight = new System.Windows.Forms.Timer(this.components);
            this.tmrLeft = new System.Windows.Forms.Timer(this.components);
            this.menubar = new System.Windows.Forms.Panel();
            this.WindowTitle = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.objFloor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objPlayer)).BeginInit();
            this.menubar.SuspendLayout();
            this.SuspendLayout();
            // 
            // objFloor
            // 
            this.objFloor.BackColor = System.Drawing.Color.SkyBlue;
            this.objFloor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.objFloor.Image = ((System.Drawing.Image)(resources.GetObject("objFloor.Image")));
            this.objFloor.ImageLocation = "";
            this.objFloor.Location = new System.Drawing.Point(0, 549);
            this.objFloor.Name = "objFloor";
            this.objFloor.Size = new System.Drawing.Size(1251, 50);
            this.objFloor.TabIndex = 0;
            this.objFloor.TabStop = false;
            this.objFloor.Paint += new System.Windows.Forms.PaintEventHandler(this.objFloor_Paint);
            // 
            // tmrGrav
            // 
            this.tmrGrav.Enabled = true;
            this.tmrGrav.Interval = 16;
            this.tmrGrav.Tick += new System.EventHandler(this.tmrGrav_Tick);
            // 
            // objPlayer
            // 
            this.objPlayer.BackColor = System.Drawing.Color.Red;
            this.objPlayer.Image = ((System.Drawing.Image)(resources.GetObject("objPlayer.Image")));
            this.objPlayer.ImageLocation = "";
            this.objPlayer.Location = new System.Drawing.Point(66, 389);
            this.objPlayer.Name = "objPlayer";
            this.objPlayer.Size = new System.Drawing.Size(75, 75);
            this.objPlayer.TabIndex = 2;
            this.objPlayer.TabStop = false;
            // 
            // tmrUp
            // 
            this.tmrUp.Interval = 16;
            this.tmrUp.Tick += new System.EventHandler(this.tmrUp_Tick);
            // 
            // tmrRight
            // 
            this.tmrRight.Interval = 16;
            this.tmrRight.Tick += new System.EventHandler(this.tmrRight_Tick);
            // 
            // tmrLeft
            // 
            this.tmrLeft.Interval = 16;
            this.tmrLeft.Tick += new System.EventHandler(this.tmrLeft_Tick);
            // 
            // menubar
            // 
            this.menubar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.menubar.Controls.Add(this.WindowTitle);
            this.menubar.Dock = System.Windows.Forms.DockStyle.Top;
            this.menubar.Location = new System.Drawing.Point(0, 0);
            this.menubar.Name = "menubar";
            this.menubar.Size = new System.Drawing.Size(1251, 32);
            this.menubar.TabIndex = 3;
            this.menubar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menubar_MouseDown);
            // 
            // WindowTitle
            // 
            this.WindowTitle.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.WindowTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.WindowTitle.Enabled = false;
            this.WindowTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WindowTitle.ForeColor = System.Drawing.Color.White;
            this.WindowTitle.Location = new System.Drawing.Point(10, 7);
            this.WindowTitle.Name = "WindowTitle";
            this.WindowTitle.ReadOnly = true;
            this.WindowTitle.Size = new System.Drawing.Size(255, 19);
            this.WindowTitle.TabIndex = 0;
            this.WindowTitle.Text = "Game";
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Red;
            this.btnClose.Location = new System.Drawing.Point(1220, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(31, 32);
            this.btnClose.TabIndex = 9999;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnClose_MouseClick);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1251, 599);
            this.Controls.Add(this.menubar);
            this.Controls.Add(this.objPlayer);
            this.Controls.Add(this.objFloor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Game";
            this.Text = "Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Game_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Game_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.objFloor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objPlayer)).EndInit();
            this.menubar.ResumeLayout(false);
            this.menubar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox objFloor;
        private System.Windows.Forms.Timer tmrGrav;
        private System.Windows.Forms.PictureBox objPlayer;
        private System.Windows.Forms.Timer tmrUp;
        private System.Windows.Forms.Timer tmrRight;
        private System.Windows.Forms.Timer tmrLeft;
        private System.Windows.Forms.Panel menubar;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox WindowTitle;
    }
}

