namespace Unstable
{
    partial class Launcher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Launcher));
            this.buttonStart = new System.Windows.Forms.Button();
            this.obrazek = new System.Windows.Forms.PictureBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.music = new AxWMPLib.AxWindowsMediaPlayer();
            this.soundGracz = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.obrazek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.music)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soundGracz)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.Transparent;
            this.buttonStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStart.Location = new System.Drawing.Point(118, 12);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(110, 27);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // obrazek
            // 
            this.obrazek.BackColor = System.Drawing.Color.Transparent;
            this.obrazek.Image = global::Unstable.Properties.Resources.blackBlackStand;
            this.obrazek.Location = new System.Drawing.Point(12, 14);
            this.obrazek.MaximumSize = new System.Drawing.Size(64, 64);
            this.obrazek.MinimumSize = new System.Drawing.Size(64, 64);
            this.obrazek.Name = "obrazek";
            this.obrazek.Size = new System.Drawing.Size(64, 64);
            this.obrazek.TabIndex = 1;
            this.obrazek.TabStop = false;
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Transparent;
            this.buttonExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExit.Location = new System.Drawing.Point(118, 51);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(110, 27);
            this.buttonExit.TabIndex = 2;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // music
            // 
            this.music.Enabled = true;
            this.music.Location = new System.Drawing.Point(82, 15);
            this.music.Name = "music";
            this.music.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("music.OcxState")));
            this.music.Size = new System.Drawing.Size(8, 8);
            this.music.TabIndex = 3;
            this.music.Visible = false;
            // 
            // soundGracz
            // 
            this.soundGracz.Enabled = true;
            this.soundGracz.Location = new System.Drawing.Point(82, 31);
            this.soundGracz.Name = "soundGracz";
            this.soundGracz.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("soundGracz.OcxState")));
            this.soundGracz.Size = new System.Drawing.Size(8, 8);
            this.soundGracz.TabIndex = 4;
            this.soundGracz.Visible = false;
            // 
            // Launcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Unstable.Properties.Resources.TłoNowaGra;
            this.ClientSize = new System.Drawing.Size(240, 90);
            this.ControlBox = false;
            this.Controls.Add(this.soundGracz);
            this.Controls.Add(this.music);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.obrazek);
            this.Controls.Add(this.buttonStart);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(256, 124);
            this.MinimumSize = new System.Drawing.Size(256, 124);
            this.Name = "Launcher";
            this.Text = "Launcher";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Launcher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.obrazek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.music)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soundGracz)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.PictureBox obrazek;
        private System.Windows.Forms.Button buttonExit;
        internal AxWMPLib.AxWindowsMediaPlayer music;
        internal AxWMPLib.AxWindowsMediaPlayer soundGracz;
    }
}

