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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NowaGra));
            this.buttonWróć = new System.Windows.Forms.Button();
            this.testNick = new System.Windows.Forms.Label();
            this.labelWygląd = new System.Windows.Forms.Label();
            this.labelKolorWłosów = new System.Windows.Forms.Label();
            this.labelKolorSkóry = new System.Windows.Forms.Label();
            this.button_KolorWłosów = new System.Windows.Forms.Button();
            this.buttonKolorWłosów_ = new System.Windows.Forms.Button();
            this.button_KolorSkóry = new System.Windows.Forms.Button();
            this.buttonKolorSkóry_ = new System.Windows.Forms.Button();
            this.aktualizator = new System.Windows.Forms.Timer(this.components);
            this.gracz = new System.Windows.Forms.PictureBox();
            this.buttonGoTest = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gracz)).BeginInit();
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
            // button_KolorWłosów
            // 
            this.button_KolorWłosów.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_KolorWłosów.Location = new System.Drawing.Point(385, 92);
            this.button_KolorWłosów.Name = "button_KolorWłosów";
            this.button_KolorWłosów.Size = new System.Drawing.Size(16, 16);
            this.button_KolorWłosów.TabIndex = 9;
            this.button_KolorWłosów.UseVisualStyleBackColor = true;
            this.button_KolorWłosów.Click += new System.EventHandler(this.button_KolorWłosów_Click);
            // 
            // buttonKolorWłosów_
            // 
            this.buttonKolorWłosów_.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonKolorWłosów_.Location = new System.Drawing.Point(516, 92);
            this.buttonKolorWłosów_.Name = "buttonKolorWłosów_";
            this.buttonKolorWłosów_.Size = new System.Drawing.Size(16, 16);
            this.buttonKolorWłosów_.TabIndex = 10;
            this.buttonKolorWłosów_.UseVisualStyleBackColor = true;
            this.buttonKolorWłosów_.Click += new System.EventHandler(this.buttonKolorWłosów__Click);
            // 
            // button_KolorSkóry
            // 
            this.button_KolorSkóry.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_KolorSkóry.Location = new System.Drawing.Point(385, 127);
            this.button_KolorSkóry.Name = "button_KolorSkóry";
            this.button_KolorSkóry.Size = new System.Drawing.Size(16, 16);
            this.button_KolorSkóry.TabIndex = 11;
            this.button_KolorSkóry.UseVisualStyleBackColor = true;
            this.button_KolorSkóry.Click += new System.EventHandler(this.button_KolorSkóry_Click);
            // 
            // buttonKolorSkóry_
            // 
            this.buttonKolorSkóry_.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonKolorSkóry_.Location = new System.Drawing.Point(516, 127);
            this.buttonKolorSkóry_.Name = "buttonKolorSkóry_";
            this.buttonKolorSkóry_.Size = new System.Drawing.Size(16, 16);
            this.buttonKolorSkóry_.TabIndex = 12;
            this.buttonKolorSkóry_.UseVisualStyleBackColor = true;
            this.buttonKolorSkóry_.Click += new System.EventHandler(this.buttonKolorSkóry__Click);
            // 
            // aktualizator
            // 
            this.aktualizator.Tick += new System.EventHandler(this.aktualizator_Tick);
            // 
            // gracz
            // 
            this.gracz.BackColor = System.Drawing.Color.Transparent;
            this.gracz.Location = new System.Drawing.Point(299, 82);
            this.gracz.Name = "gracz";
            this.gracz.Size = new System.Drawing.Size(64, 64);
            this.gracz.TabIndex = 5;
            this.gracz.TabStop = false;
            this.gracz.Click += new System.EventHandler(this.gracz_Click);
            // 
            // buttonGoTest
            // 
            this.buttonGoTest.Location = new System.Drawing.Point(672, 12);
            this.buttonGoTest.Name = "buttonGoTest";
            this.buttonGoTest.Size = new System.Drawing.Size(100, 74);
            this.buttonGoTest.TabIndex = 13;
            this.buttonGoTest.Text = "Go Test";
            this.buttonGoTest.UseVisualStyleBackColor = true;
            this.buttonGoTest.Click += new System.EventHandler(this.buttonGoTest_Click);
            // 
            // NowaGra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.buttonGoTest);
            this.Controls.Add(this.buttonKolorSkóry_);
            this.Controls.Add(this.button_KolorSkóry);
            this.Controls.Add(this.buttonKolorWłosów_);
            this.Controls.Add(this.button_KolorWłosów);
            this.Controls.Add(this.labelKolorSkóry);
            this.Controls.Add(this.labelKolorWłosów);
            this.Controls.Add(this.labelWygląd);
            this.Controls.Add(this.gracz);
            this.Controls.Add(this.testNick);
            this.Controls.Add(this.buttonWróć);
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "NowaGra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.NowaGra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gracz)).EndInit();
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
        private System.Windows.Forms.Button button_KolorWłosów;
        private System.Windows.Forms.Button buttonKolorWłosów_;
        private System.Windows.Forms.Button button_KolorSkóry;
        private System.Windows.Forms.Button buttonKolorSkóry_;
        private System.Windows.Forms.Timer aktualizator;
        private System.Windows.Forms.Button buttonGoTest;
    }
}