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
            this.labelInstrukcja = new System.Windows.Forms.Label();
            this.labelInfo = new System.Windows.Forms.Label();
            this.labelAnimacje = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.demonstracja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klawisze)).BeginInit();
            this.SuspendLayout();
            // 
            // demonstracja
            // 
            this.demonstracja.Image = global::Unstable.Properties.Resources.SamouczekChodzenie;
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
            // labelInstrukcja
            // 
            this.labelInstrukcja.AutoSize = true;
            this.labelInstrukcja.BackColor = System.Drawing.Color.Transparent;
            this.labelInstrukcja.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelInstrukcja.ForeColor = System.Drawing.Color.Snow;
            this.labelInstrukcja.Location = new System.Drawing.Point(274, 10);
            this.labelInstrukcja.MaximumSize = new System.Drawing.Size(300, 80);
            this.labelInstrukcja.MinimumSize = new System.Drawing.Size(300, 80);
            this.labelInstrukcja.Name = "labelInstrukcja";
            this.labelInstrukcja.Size = new System.Drawing.Size(300, 80);
            this.labelInstrukcja.TabIndex = 5;
            this.labelInstrukcja.Text = "Do poruszania się używaj klawiszy strzałek.";
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.BackColor = System.Drawing.Color.Transparent;
            this.labelInfo.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelInfo.ForeColor = System.Drawing.Color.Snow;
            this.labelInfo.Location = new System.Drawing.Point(377, 224);
            this.labelInfo.MaximumSize = new System.Drawing.Size(210, 165);
            this.labelInfo.MinimumSize = new System.Drawing.Size(210, 165);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(210, 165);
            this.labelInfo.TabIndex = 6;
            this.labelInfo.Text = "Szybkość poruszania się zależy od obuwia, które nosisz.";
            // 
            // labelAnimacje
            // 
            this.labelAnimacje.AutoSize = true;
            this.labelAnimacje.BackColor = System.Drawing.Color.Transparent;
            this.labelAnimacje.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAnimacje.ForeColor = System.Drawing.Color.Snow;
            this.labelAnimacje.Location = new System.Drawing.Point(12, 271);
            this.labelAnimacje.MaximumSize = new System.Drawing.Size(210, 100);
            this.labelAnimacje.MinimumSize = new System.Drawing.Size(210, 100);
            this.labelAnimacje.Name = "labelAnimacje";
            this.labelAnimacje.Size = new System.Drawing.Size(210, 100);
            this.labelAnimacje.TabIndex = 7;
            this.labelAnimacje.Text = "Animacja powyższego obrazka nie jest w 100% zsynchronizowana z animacją przyciskó" +
    "w.";
            // 
            // Samouczek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImage = global::Unstable.Properties.Resources.OkienkoSamouczek;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.ControlBox = false;
            this.Controls.Add(this.labelAnimacje);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.labelInstrukcja);
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
        private System.Windows.Forms.Label labelInstrukcja;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Label labelAnimacje;
    }
}