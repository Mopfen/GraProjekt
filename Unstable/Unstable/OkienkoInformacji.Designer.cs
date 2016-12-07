namespace Unstable
{
    partial class OkienkoInformacji
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OkienkoInformacji));
            this.alaButtonExit = new System.Windows.Forms.PictureBox();
            this.info = new System.Windows.Forms.Label();
            this.obrazek = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.alaButtonExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obrazek)).BeginInit();
            this.SuspendLayout();
            // 
            // alaButtonExit
            // 
            this.alaButtonExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.alaButtonExit.Image = global::Unstable.Properties.Resources.Zamknij24x24;
            this.alaButtonExit.Location = new System.Drawing.Point(423, 3);
            this.alaButtonExit.MaximumSize = new System.Drawing.Size(24, 24);
            this.alaButtonExit.MinimumSize = new System.Drawing.Size(24, 24);
            this.alaButtonExit.Name = "alaButtonExit";
            this.alaButtonExit.Size = new System.Drawing.Size(24, 24);
            this.alaButtonExit.TabIndex = 42;
            this.alaButtonExit.TabStop = false;
            this.alaButtonExit.Click += new System.EventHandler(this.alaButtonExit_Click);
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.BackColor = System.Drawing.Color.Transparent;
            this.info.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.info.Location = new System.Drawing.Point(1, 41);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(450, 360);
            this.info.TabIndex = 43;
            this.info.Text = resources.GetString("info.Text");
            this.info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // obrazek
            // 
            this.obrazek.BackColor = System.Drawing.Color.Transparent;
            this.obrazek.Image = global::Unstable.Properties.Resources.PerqunMovingDown;
            this.obrazek.Location = new System.Drawing.Point(186, 482);
            this.obrazek.Name = "obrazek";
            this.obrazek.Size = new System.Drawing.Size(64, 64);
            this.obrazek.TabIndex = 44;
            this.obrazek.TabStop = false;
            // 
            // OkienkoInformacji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Unstable.Properties.Resources.OkienkoStatystyki;
            this.ClientSize = new System.Drawing.Size(450, 600);
            this.ControlBox = false;
            this.Controls.Add(this.obrazek);
            this.Controls.Add(this.info);
            this.Controls.Add(this.alaButtonExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(450, 600);
            this.MinimumSize = new System.Drawing.Size(450, 600);
            this.Name = "OkienkoInformacji";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OkienkoInformacji";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OkienkoInformacji_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.alaButtonExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obrazek)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox alaButtonExit;
        private System.Windows.Forms.Label info;
        private System.Windows.Forms.PictureBox obrazek;
    }
}