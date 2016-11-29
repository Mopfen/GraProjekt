namespace Unstable
{
    partial class KoniecTestu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KoniecTestu));
            this.info = new System.Windows.Forms.Label();
            this.man1 = new System.Windows.Forms.PictureBox();
            this.man2 = new System.Windows.Forms.PictureBox();
            this.buttonOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.man1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.man2)).BeginInit();
            this.SuspendLayout();
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.BackColor = System.Drawing.Color.Transparent;
            this.info.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.info.Location = new System.Drawing.Point(49, 0);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(146, 48);
            this.info.TabIndex = 0;
            this.info.Text = "Gratulacje, dotarłeś do\r\nkońca testów w tej\r\nwersji gry.";
            this.info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // man1
            // 
            this.man1.BackColor = System.Drawing.Color.Transparent;
            this.man1.Image = global::Unstable.Properties.Resources.whiteBrownAttackingRight;
            this.man1.Location = new System.Drawing.Point(0, 21);
            this.man1.MaximumSize = new System.Drawing.Size(64, 64);
            this.man1.MinimumSize = new System.Drawing.Size(64, 64);
            this.man1.Name = "man1";
            this.man1.Size = new System.Drawing.Size(64, 64);
            this.man1.TabIndex = 1;
            this.man1.TabStop = false;
            // 
            // man2
            // 
            this.man2.BackColor = System.Drawing.Color.Transparent;
            this.man2.Image = global::Unstable.Properties.Resources.whiteBrownAttackingLeft;
            this.man2.Location = new System.Drawing.Point(176, 21);
            this.man2.MaximumSize = new System.Drawing.Size(64, 64);
            this.man2.MinimumSize = new System.Drawing.Size(64, 64);
            this.man2.Name = "man2";
            this.man2.Size = new System.Drawing.Size(64, 64);
            this.man2.TabIndex = 2;
            this.man2.TabStop = false;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(84, 51);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 3;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            this.buttonOK.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KoniecTestu_KeyDown);
            // 
            // KoniecTestu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(240, 86);
            this.ControlBox = false;
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.man1);
            this.Controls.Add(this.man2);
            this.Controls.Add(this.info);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(256, 124);
            this.MinimumSize = new System.Drawing.Size(256, 124);
            this.Name = "KoniecTestu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KoniecTestu";
            ((System.ComponentModel.ISupportInitialize)(this.man1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.man2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label info;
        private System.Windows.Forms.PictureBox man1;
        private System.Windows.Forms.PictureBox man2;
        private System.Windows.Forms.Button buttonOK;
    }
}