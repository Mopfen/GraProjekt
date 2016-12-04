namespace Unstable
{
    partial class Zadania
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
            this.listaMisjiGłównych = new System.Windows.Forms.ComboBox();
            this.alaButtonExit = new System.Windows.Forms.PictureBox();
            this.labelNazwa = new System.Windows.Forms.Label();
            this.labelZadaniaGłówne = new System.Windows.Forms.Label();
            this.labelZadaniaPoboczne = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelNazwaZadania = new System.Windows.Forms.Label();
            this.labelAktualnyEtap = new System.Windows.Forms.Label();
            this.labelEtap = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.alaButtonExit)).BeginInit();
            this.SuspendLayout();
            // 
            // listaMisjiGłównych
            // 
            this.listaMisjiGłównych.BackColor = System.Drawing.Color.OliveDrab;
            this.listaMisjiGłównych.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listaMisjiGłównych.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listaMisjiGłównych.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listaMisjiGłównych.ForeColor = System.Drawing.Color.Gold;
            this.listaMisjiGłównych.FormattingEnabled = true;
            this.listaMisjiGłównych.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.listaMisjiGłównych.Location = new System.Drawing.Point(233, 56);
            this.listaMisjiGłównych.Name = "listaMisjiGłównych";
            this.listaMisjiGłównych.Size = new System.Drawing.Size(205, 38);
            this.listaMisjiGłównych.Sorted = true;
            this.listaMisjiGłównych.TabIndex = 0;
            this.listaMisjiGłównych.TabStop = false;
            this.listaMisjiGłównych.SelectedIndexChanged += new System.EventHandler(this.ZmianaArgumetówMisjeGłówne);
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
            this.alaButtonExit.TabIndex = 26;
            this.alaButtonExit.TabStop = false;
            this.alaButtonExit.Click += new System.EventHandler(this.alaButtonExit_Click);
            // 
            // labelNazwa
            // 
            this.labelNazwa.AutoSize = true;
            this.labelNazwa.BackColor = System.Drawing.Color.Transparent;
            this.labelNazwa.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNazwa.ForeColor = System.Drawing.Color.Blue;
            this.labelNazwa.Location = new System.Drawing.Point(191, 214);
            this.labelNazwa.Name = "labelNazwa";
            this.labelNazwa.Size = new System.Drawing.Size(73, 30);
            this.labelNazwa.TabIndex = 27;
            this.labelNazwa.Text = "nazwa";
            // 
            // labelZadaniaGłówne
            // 
            this.labelZadaniaGłówne.AutoSize = true;
            this.labelZadaniaGłówne.BackColor = System.Drawing.Color.Transparent;
            this.labelZadaniaGłówne.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelZadaniaGłówne.ForeColor = System.Drawing.Color.White;
            this.labelZadaniaGłówne.Location = new System.Drawing.Point(12, 56);
            this.labelZadaniaGłówne.Name = "labelZadaniaGłówne";
            this.labelZadaniaGłówne.Size = new System.Drawing.Size(177, 30);
            this.labelZadaniaGłówne.TabIndex = 28;
            this.labelZadaniaGłówne.Text = "Zadania główne:";
            // 
            // labelZadaniaPoboczne
            // 
            this.labelZadaniaPoboczne.AutoSize = true;
            this.labelZadaniaPoboczne.BackColor = System.Drawing.Color.Transparent;
            this.labelZadaniaPoboczne.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelZadaniaPoboczne.ForeColor = System.Drawing.Color.White;
            this.labelZadaniaPoboczne.Location = new System.Drawing.Point(12, 126);
            this.labelZadaniaPoboczne.Name = "labelZadaniaPoboczne";
            this.labelZadaniaPoboczne.Size = new System.Drawing.Size(201, 30);
            this.labelZadaniaPoboczne.TabIndex = 29;
            this.labelZadaniaPoboczne.Text = "Zadania poboczne:";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.OliveDrab;
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox1.ForeColor = System.Drawing.Color.Gold;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBox1.Location = new System.Drawing.Point(233, 118);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(205, 38);
            this.comboBox1.Sorted = true;
            this.comboBox1.TabIndex = 30;
            this.comboBox1.TabStop = false;
            // 
            // labelNazwaZadania
            // 
            this.labelNazwaZadania.AutoSize = true;
            this.labelNazwaZadania.BackColor = System.Drawing.Color.Transparent;
            this.labelNazwaZadania.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNazwaZadania.ForeColor = System.Drawing.Color.White;
            this.labelNazwaZadania.Location = new System.Drawing.Point(12, 214);
            this.labelNazwaZadania.Name = "labelNazwaZadania";
            this.labelNazwaZadania.Size = new System.Drawing.Size(173, 30);
            this.labelNazwaZadania.TabIndex = 31;
            this.labelNazwaZadania.Text = "Nazwa zadania:";
            // 
            // labelAktualnyEtap
            // 
            this.labelAktualnyEtap.AutoSize = true;
            this.labelAktualnyEtap.BackColor = System.Drawing.Color.Transparent;
            this.labelAktualnyEtap.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAktualnyEtap.ForeColor = System.Drawing.Color.White;
            this.labelAktualnyEtap.Location = new System.Drawing.Point(12, 275);
            this.labelAktualnyEtap.Name = "labelAktualnyEtap";
            this.labelAktualnyEtap.Size = new System.Drawing.Size(164, 30);
            this.labelAktualnyEtap.TabIndex = 32;
            this.labelAktualnyEtap.Text = "Aktualny etap:";
            // 
            // labelEtap
            // 
            this.labelEtap.AutoSize = true;
            this.labelEtap.BackColor = System.Drawing.Color.Transparent;
            this.labelEtap.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelEtap.ForeColor = System.Drawing.Color.Gold;
            this.labelEtap.Location = new System.Drawing.Point(191, 275);
            this.labelEtap.MaximumSize = new System.Drawing.Size(256, 256);
            this.labelEtap.MinimumSize = new System.Drawing.Size(256, 256);
            this.labelEtap.Name = "labelEtap";
            this.labelEtap.Size = new System.Drawing.Size(256, 256);
            this.labelEtap.TabIndex = 33;
            this.labelEtap.Text = "nazwa";
            // 
            // Zadania
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Unstable.Properties.Resources.OkienkoStatystyki;
            this.ClientSize = new System.Drawing.Size(450, 600);
            this.ControlBox = false;
            this.Controls.Add(this.labelEtap);
            this.Controls.Add(this.labelAktualnyEtap);
            this.Controls.Add(this.labelNazwaZadania);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.labelZadaniaPoboczne);
            this.Controls.Add(this.labelZadaniaGłówne);
            this.Controls.Add(this.labelNazwa);
            this.Controls.Add(this.alaButtonExit);
            this.Controls.Add(this.listaMisjiGłównych);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(450, 600);
            this.MinimumSize = new System.Drawing.Size(450, 600);
            this.Name = "Zadania";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zadania";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Zadania_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.alaButtonExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox listaMisjiGłównych;
        private System.Windows.Forms.PictureBox alaButtonExit;
        private System.Windows.Forms.Label labelNazwa;
        private System.Windows.Forms.Label labelZadaniaGłówne;
        private System.Windows.Forms.Label labelZadaniaPoboczne;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelNazwaZadania;
        private System.Windows.Forms.Label labelAktualnyEtap;
        private System.Windows.Forms.Label labelEtap;
    }
}