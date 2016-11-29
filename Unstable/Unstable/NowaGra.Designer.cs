namespace Unstable
{
    partial class NowaGra
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
            this.buttonWróć = new System.Windows.Forms.Button();
            this.testNick = new System.Windows.Forms.Label();
            this.labelWygląd = new System.Windows.Forms.Label();
            this.labelKolorWłosów = new System.Windows.Forms.Label();
            this.labelKolorSkóry = new System.Windows.Forms.Label();
            this.aktualizator = new System.Windows.Forms.Timer(this.components);
            this.gracz = new System.Windows.Forms.PictureBox();
            this.buttonGoTest = new System.Windows.Forms.Button();
            this.alaButton_KolorWłosów = new System.Windows.Forms.PictureBox();
            this.alaButton_KolorSkóry = new System.Windows.Forms.PictureBox();
            this.alaButtonKolorWłosów_ = new System.Windows.Forms.PictureBox();
            this.alaButtonKolorSkóry_ = new System.Windows.Forms.PictureBox();
            this.info = new System.Windows.Forms.Label();
            this.wersjaGry = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gracz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alaButton_KolorWłosów)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alaButton_KolorSkóry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alaButtonKolorWłosów_)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alaButtonKolorSkóry_)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonWróć
            // 
            this.buttonWróć.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonWróć.Location = new System.Drawing.Point(12, 478);
            this.buttonWróć.Name = "buttonWróć";
            this.buttonWróć.Size = new System.Drawing.Size(153, 72);
            this.buttonWróć.TabIndex = 0;
            this.buttonWróć.Text = "Wróć";
            this.buttonWróć.UseVisualStyleBackColor = true;
            this.buttonWróć.Click += new System.EventHandler(this.buttonWróć_Click);
            // 
            // testNick
            // 
            this.testNick.AutoSize = true;
            this.testNick.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.testNick.Location = new System.Drawing.Point(65, 246);
            this.testNick.Name = "testNick";
            this.testNick.Size = new System.Drawing.Size(0, 25);
            this.testNick.TabIndex = 3;
            // 
            // labelWygląd
            // 
            this.labelWygląd.AutoSize = true;
            this.labelWygląd.BackColor = System.Drawing.Color.Transparent;
            this.labelWygląd.Font = new System.Drawing.Font("Gabriola", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWygląd.ForeColor = System.Drawing.Color.Snow;
            this.labelWygląd.Location = new System.Drawing.Point(195, 93);
            this.labelWygląd.Name = "labelWygląd";
            this.labelWygląd.Size = new System.Drawing.Size(98, 50);
            this.labelWygląd.TabIndex = 6;
            this.labelWygląd.Text = "Wygląd:";
            // 
            // labelKolorWłosów
            // 
            this.labelKolorWłosów.AutoSize = true;
            this.labelKolorWłosów.BackColor = System.Drawing.Color.Transparent;
            this.labelKolorWłosów.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelKolorWłosów.Location = new System.Drawing.Point(407, 82);
            this.labelKolorWłosów.Name = "labelKolorWłosów";
            this.labelKolorWłosów.Size = new System.Drawing.Size(105, 35);
            this.labelKolorWłosów.TabIndex = 7;
            this.labelKolorWłosów.Text = "Kolor włosów";
            // 
            // labelKolorSkóry
            // 
            this.labelKolorSkóry.AutoSize = true;
            this.labelKolorSkóry.BackColor = System.Drawing.Color.Transparent;
            this.labelKolorSkóry.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelKolorSkóry.Location = new System.Drawing.Point(407, 117);
            this.labelKolorSkóry.Name = "labelKolorSkóry";
            this.labelKolorSkóry.Size = new System.Drawing.Size(94, 35);
            this.labelKolorSkóry.TabIndex = 8;
            this.labelKolorSkóry.Text = "Kolor skóry";
            // 
            // aktualizator
            // 
            this.aktualizator.Enabled = true;
            this.aktualizator.Tick += new System.EventHandler(this.aktualizator_Tick);
            // 
            // gracz
            // 
            this.gracz.BackColor = System.Drawing.Color.Transparent;
            this.gracz.Image = global::Unstable.Properties.Resources.whiteBrownStand;
            this.gracz.Location = new System.Drawing.Point(299, 82);
            this.gracz.Name = "gracz";
            this.gracz.Size = new System.Drawing.Size(64, 64);
            this.gracz.TabIndex = 5;
            this.gracz.TabStop = false;
            this.gracz.Click += new System.EventHandler(this.gracz_Click);
            // 
            // buttonGoTest
            // 
            this.buttonGoTest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGoTest.Location = new System.Drawing.Point(353, 197);
            this.buttonGoTest.Name = "buttonGoTest";
            this.buttonGoTest.Size = new System.Drawing.Size(100, 74);
            this.buttonGoTest.TabIndex = 13;
            this.buttonGoTest.Text = "Graj";
            this.buttonGoTest.UseVisualStyleBackColor = true;
            this.buttonGoTest.Click += new System.EventHandler(this.buttonGoTest_Click);
            // 
            // alaButton_KolorWłosów
            // 
            this.alaButton_KolorWłosów.BackColor = System.Drawing.Color.Transparent;
            this.alaButton_KolorWłosów.Cursor = System.Windows.Forms.Cursors.Hand;
            this.alaButton_KolorWłosów.Image = global::Unstable.Properties.Resources.StrzałkaLeft;
            this.alaButton_KolorWłosów.Location = new System.Drawing.Point(380, 88);
            this.alaButton_KolorWłosów.Name = "alaButton_KolorWłosów";
            this.alaButton_KolorWłosów.Size = new System.Drawing.Size(24, 24);
            this.alaButton_KolorWłosów.TabIndex = 14;
            this.alaButton_KolorWłosów.TabStop = false;
            this.alaButton_KolorWłosów.Click += new System.EventHandler(this.alaButton_KolorWłosów_Click);
            // 
            // alaButton_KolorSkóry
            // 
            this.alaButton_KolorSkóry.BackColor = System.Drawing.Color.Transparent;
            this.alaButton_KolorSkóry.Cursor = System.Windows.Forms.Cursors.Hand;
            this.alaButton_KolorSkóry.Image = global::Unstable.Properties.Resources.StrzałkaLeft;
            this.alaButton_KolorSkóry.Location = new System.Drawing.Point(380, 122);
            this.alaButton_KolorSkóry.Name = "alaButton_KolorSkóry";
            this.alaButton_KolorSkóry.Size = new System.Drawing.Size(24, 24);
            this.alaButton_KolorSkóry.TabIndex = 15;
            this.alaButton_KolorSkóry.TabStop = false;
            this.alaButton_KolorSkóry.Click += new System.EventHandler(this.alaButton_KolorSkóry_Click);
            // 
            // alaButtonKolorWłosów_
            // 
            this.alaButtonKolorWłosów_.BackColor = System.Drawing.Color.Transparent;
            this.alaButtonKolorWłosów_.Cursor = System.Windows.Forms.Cursors.Hand;
            this.alaButtonKolorWłosów_.Image = global::Unstable.Properties.Resources.StrzałkaRight;
            this.alaButtonKolorWłosów_.Location = new System.Drawing.Point(511, 88);
            this.alaButtonKolorWłosów_.Name = "alaButtonKolorWłosów_";
            this.alaButtonKolorWłosów_.Size = new System.Drawing.Size(24, 24);
            this.alaButtonKolorWłosów_.TabIndex = 16;
            this.alaButtonKolorWłosów_.TabStop = false;
            this.alaButtonKolorWłosów_.Click += new System.EventHandler(this.alaButtonKolorWłosów__Click);
            // 
            // alaButtonKolorSkóry_
            // 
            this.alaButtonKolorSkóry_.BackColor = System.Drawing.Color.Transparent;
            this.alaButtonKolorSkóry_.Cursor = System.Windows.Forms.Cursors.Hand;
            this.alaButtonKolorSkóry_.Image = global::Unstable.Properties.Resources.StrzałkaRight;
            this.alaButtonKolorSkóry_.Location = new System.Drawing.Point(511, 122);
            this.alaButtonKolorSkóry_.Name = "alaButtonKolorSkóry_";
            this.alaButtonKolorSkóry_.Size = new System.Drawing.Size(24, 24);
            this.alaButtonKolorSkóry_.TabIndex = 17;
            this.alaButtonKolorSkóry_.TabStop = false;
            this.alaButtonKolorSkóry_.Click += new System.EventHandler(this.alaButtonKolorSkóry__Click);
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.BackColor = System.Drawing.Color.Transparent;
            this.info.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.info.ForeColor = System.Drawing.Color.Gray;
            this.info.Location = new System.Drawing.Point(124, 152);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(541, 23);
            this.info.TabIndex = 18;
            this.info.Text = "W tej wersji gry ustawiony wygląd nie zostanie zapamiętany w grze";
            // 
            // wersjaGry
            // 
            this.wersjaGry.AutoSize = true;
            this.wersjaGry.BackColor = System.Drawing.Color.Transparent;
            this.wersjaGry.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wersjaGry.ForeColor = System.Drawing.Color.White;
            this.wersjaGry.Location = new System.Drawing.Point(592, 530);
            this.wersjaGry.MaximumSize = new System.Drawing.Size(180, 20);
            this.wersjaGry.MinimumSize = new System.Drawing.Size(180, 20);
            this.wersjaGry.Name = "wersjaGry";
            this.wersjaGry.Size = new System.Drawing.Size(180, 20);
            this.wersjaGry.TabIndex = 19;
            this.wersjaGry.Text = "Wersja Gry: ";
            // 
            // NowaGra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BackgroundImage = global::Unstable.Properties.Resources.TłoNowaGra;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.ControlBox = false;
            this.Controls.Add(this.wersjaGry);
            this.Controls.Add(this.info);
            this.Controls.Add(this.alaButtonKolorSkóry_);
            this.Controls.Add(this.alaButtonKolorWłosów_);
            this.Controls.Add(this.alaButton_KolorSkóry);
            this.Controls.Add(this.alaButton_KolorWłosów);
            this.Controls.Add(this.buttonGoTest);
            this.Controls.Add(this.labelKolorSkóry);
            this.Controls.Add(this.labelKolorWłosów);
            this.Controls.Add(this.labelWygląd);
            this.Controls.Add(this.gracz);
            this.Controls.Add(this.testNick);
            this.Controls.Add(this.buttonWróć);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "NowaGra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.NowaGra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gracz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alaButton_KolorWłosów)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alaButton_KolorSkóry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alaButtonKolorWłosów_)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alaButtonKolorSkóry_)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonWróć;
        private System.Windows.Forms.Label testNick;
        private System.Windows.Forms.PictureBox gracz;
        private System.Windows.Forms.Label labelWygląd;
        private System.Windows.Forms.Label labelKolorWłosów;
        private System.Windows.Forms.Label labelKolorSkóry;
        private System.Windows.Forms.Timer aktualizator;
        private System.Windows.Forms.Button buttonGoTest;
        private System.Windows.Forms.PictureBox alaButton_KolorWłosów;
        private System.Windows.Forms.PictureBox alaButton_KolorSkóry;
        private System.Windows.Forms.PictureBox alaButtonKolorWłosów_;
        private System.Windows.Forms.PictureBox alaButtonKolorSkóry_;
        private System.Windows.Forms.Label info;
        private System.Windows.Forms.Label wersjaGry;
    }
}