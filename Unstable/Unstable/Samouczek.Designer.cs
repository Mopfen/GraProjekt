namespace Unstable
{
    partial class Samouczek
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Samouczek));
            this.demonstracja = new System.Windows.Forms.PictureBox();
            this.buttonDalej = new System.Windows.Forms.Button();
            this.labelSamouczek = new System.Windows.Forms.Label();
            this.klawisze = new System.Windows.Forms.PictureBox();
            this.labelOpis = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.demonstracja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klawisze)).BeginInit();
            this.SuspendLayout();
            // 
            // demonstracja
            // 
            this.demonstracja.Image = ((System.Drawing.Image)(resources.GetObject("demonstracja.Image")));
            this.demonstracja.Location = new System.Drawing.Point(12, 12);
            this.demonstracja.Name = "demonstracja";
            this.demonstracja.Size = new System.Drawing.Size(256, 256);
            this.demonstracja.TabIndex = 2;
            this.demonstracja.TabStop = false;
            // 
            // buttonDalej
            // 
            this.buttonDalej.BackColor = System.Drawing.Color.White;
            this.buttonDalej.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDalej.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDalej.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDalej.ForeColor = System.Drawing.Color.Gold;
            this.buttonDalej.Image = global::Unstable.Properties.Resources.Button;
            this.buttonDalej.Location = new System.Drawing.Point(235, 320);
            this.buttonDalej.MaximumSize = new System.Drawing.Size(128, 64);
            this.buttonDalej.MinimumSize = new System.Drawing.Size(128, 64);
            this.buttonDalej.Name = "buttonDalej";
            this.buttonDalej.Size = new System.Drawing.Size(128, 64);
            this.buttonDalej.TabIndex = 1;
            this.buttonDalej.Text = "Dalej";
            this.buttonDalej.UseVisualStyleBackColor = false;
            this.buttonDalej.Click += new System.EventHandler(this.buttonDalej_Click);
            // 
            // labelSamouczek
            // 
            this.labelSamouczek.AutoSize = true;
            this.labelSamouczek.BackColor = System.Drawing.Color.Transparent;
            this.labelSamouczek.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSamouczek.ForeColor = System.Drawing.Color.OrangeRed;
            this.labelSamouczek.Location = new System.Drawing.Point(220, 271);
            this.labelSamouczek.Name = "labelSamouczek";
            this.labelSamouczek.Size = new System.Drawing.Size(159, 38);
            this.labelSamouczek.TabIndex = 3;
            this.labelSamouczek.Text = "Samouczek";
            // 
            // klawisze
            // 
            this.klawisze.BackColor = System.Drawing.Color.Transparent;
            this.klawisze.Image = global::Unstable.Properties.Resources.KlawiszeSamouczekChodzenie;
            this.klawisze.Location = new System.Drawing.Point(304, 93);
            this.klawisze.Name = "klawisze";
            this.klawisze.Size = new System.Drawing.Size(256, 128);
            this.klawisze.TabIndex = 4;
            this.klawisze.TabStop = false;
            // 
            // labelOpis
            // 
            this.labelOpis.AutoSize = true;
            this.labelOpis.BackColor = System.Drawing.Color.Transparent;
            this.labelOpis.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelOpis.ForeColor = System.Drawing.Color.Snow;
            this.labelOpis.Location = new System.Drawing.Point(287, 12);
            this.labelOpis.Name = "labelOpis";
            this.labelOpis.Size = new System.Drawing.Size(273, 60);
            this.labelOpis.TabIndex = 5;
            this.labelOpis.Text = "Do poruszania się\r\nużywaj klawiszy strzałek.";
            // 
            // Samouczek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImage = global::Unstable.Properties.Resources.OkienkoSamouczek;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.ControlBox = false;
            this.Controls.Add(this.labelOpis);
            this.Controls.Add(this.labelSamouczek);
            this.Controls.Add(this.demonstracja);
            this.Controls.Add(this.buttonDalej);
            this.Controls.Add(this.klawisze);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(600, 400);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "Samouczek";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Samouczek";
            ((System.ComponentModel.ISupportInitialize)(this.demonstracja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klawisze)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonDalej;
        private System.Windows.Forms.PictureBox demonstracja;
        private System.Windows.Forms.Label labelSamouczek;
        private System.Windows.Forms.PictureBox klawisze;
        private System.Windows.Forms.Label labelOpis;
    }
}