namespace Unstable
{
    partial class MenuGlowne
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
            this.buttonNowaGra = new System.Windows.Forms.Button();
            this.buttonWyjście = new System.Windows.Forms.Button();
            this.buttonWczytajGrę = new System.Windows.Forms.Button();
            this.aktualizator = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.wersjaGry = new System.Windows.Forms.Label();
            this.labelTerrorOfDragons = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonNowaGra
            // 
            this.buttonNowaGra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonNowaGra.Location = new System.Drawing.Point(351, 136);
            this.buttonNowaGra.MaximumSize = new System.Drawing.Size(128, 64);
            this.buttonNowaGra.MinimumSize = new System.Drawing.Size(128, 64);
            this.buttonNowaGra.Name = "buttonNowaGra";
            this.buttonNowaGra.Size = new System.Drawing.Size(128, 64);
            this.buttonNowaGra.TabIndex = 0;
            this.buttonNowaGra.Text = "Nowa Gra";
            this.buttonNowaGra.UseVisualStyleBackColor = true;
            this.buttonNowaGra.Click += new System.EventHandler(this.buttonNowaGra_Click);
            // 
            // buttonWyjście
            // 
            this.buttonWyjście.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonWyjście.Location = new System.Drawing.Point(351, 317);
            this.buttonWyjście.MaximumSize = new System.Drawing.Size(128, 64);
            this.buttonWyjście.MinimumSize = new System.Drawing.Size(128, 64);
            this.buttonWyjście.Name = "buttonWyjście";
            this.buttonWyjście.Size = new System.Drawing.Size(128, 64);
            this.buttonWyjście.TabIndex = 1;
            this.buttonWyjście.Text = "Wyjście";
            this.buttonWyjście.UseVisualStyleBackColor = true;
            this.buttonWyjście.Click += new System.EventHandler(this.buttonWyjście_Click);
            // 
            // buttonWczytajGrę
            // 
            this.buttonWczytajGrę.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonWczytajGrę.Location = new System.Drawing.Point(351, 225);
            this.buttonWczytajGrę.MaximumSize = new System.Drawing.Size(128, 64);
            this.buttonWczytajGrę.MinimumSize = new System.Drawing.Size(128, 64);
            this.buttonWczytajGrę.Name = "buttonWczytajGrę";
            this.buttonWczytajGrę.Size = new System.Drawing.Size(128, 64);
            this.buttonWczytajGrę.TabIndex = 3;
            this.buttonWczytajGrę.Text = "Wczytaj Grę";
            this.buttonWczytajGrę.UseVisualStyleBackColor = true;
            this.buttonWczytajGrę.Click += new System.EventHandler(this.buttonWczytajGrę_Click);
            // 
            // aktualizator
            // 
            this.aktualizator.Tick += new System.EventHandler(this.aktualizator_Tick);
            // 
            // wersjaGry
            // 
            this.wersjaGry.AutoSize = true;
            this.wersjaGry.BackColor = System.Drawing.Color.Transparent;
            this.wersjaGry.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wersjaGry.ForeColor = System.Drawing.Color.White;
            this.wersjaGry.Location = new System.Drawing.Point(592, 533);
            this.wersjaGry.MaximumSize = new System.Drawing.Size(180, 20);
            this.wersjaGry.MinimumSize = new System.Drawing.Size(180, 20);
            this.wersjaGry.Name = "wersjaGry";
            this.wersjaGry.Size = new System.Drawing.Size(180, 20);
            this.wersjaGry.TabIndex = 4;
            this.wersjaGry.Text = "Wersja Gry: ";
            // 
            // labelTerrorOfDragons
            // 
            this.labelTerrorOfDragons.AutoSize = true;
            this.labelTerrorOfDragons.BackColor = System.Drawing.Color.Transparent;
            this.labelTerrorOfDragons.Font = new System.Drawing.Font("Showcard Gothic", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTerrorOfDragons.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.labelTerrorOfDragons.Location = new System.Drawing.Point(149, 55);
            this.labelTerrorOfDragons.Name = "labelTerrorOfDragons";
            this.labelTerrorOfDragons.Size = new System.Drawing.Size(528, 60);
            this.labelTerrorOfDragons.TabIndex = 5;
            this.labelTerrorOfDragons.Text = "Terror Of Dragons";
            // 
            // MenuGlowne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Unstable.Properties.Resources.TłoNowaGra;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.ControlBox = false;
            this.Controls.Add(this.labelTerrorOfDragons);
            this.Controls.Add(this.wersjaGry);
            this.Controls.Add(this.buttonWczytajGrę);
            this.Controls.Add(this.buttonWyjście);
            this.Controls.Add(this.buttonNowaGra);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MenuGlowne";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuGlowne";
            this.Load += new System.EventHandler(this.MenuGlowne_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNowaGra;
        private System.Windows.Forms.Button buttonWyjście;
        private System.Windows.Forms.Button buttonWczytajGrę;
        private System.Windows.Forms.Timer aktualizator;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label wersjaGry;
        private System.Windows.Forms.Label labelTerrorOfDragons;
    }
}