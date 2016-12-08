namespace Unstable
{
    partial class WczytajGrę
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WczytajGrę));
            this.buttonWróć = new System.Windows.Forms.Button();
            this.wersjaGry = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonWróć
            // 
            this.buttonWróć.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonWróć.Location = new System.Drawing.Point(12, 465);
            this.buttonWróć.Name = "buttonWróć";
            this.buttonWróć.Size = new System.Drawing.Size(189, 85);
            this.buttonWróć.TabIndex = 0;
            this.buttonWróć.Text = "Wróć";
            this.buttonWróć.UseVisualStyleBackColor = true;
            this.buttonWróć.Click += new System.EventHandler(this.buttonWróć_Click);
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
            this.wersjaGry.TabIndex = 5;
            this.wersjaGry.Text = "Wersja Gry: ";
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.BackColor = System.Drawing.Color.Transparent;
            this.info.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.info.ForeColor = System.Drawing.Color.Gray;
            this.info.Location = new System.Drawing.Point(88, 235);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(635, 35);
            this.info.TabIndex = 19;
            this.info.Text = "W tej wersji gry wczytanie wyników jest niedostępne";
            // 
            // WczytajGrę
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Unstable.Properties.Resources.TłoNowaGra;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.ControlBox = false;
            this.Controls.Add(this.info);
            this.Controls.Add(this.wersjaGry);
            this.Controls.Add(this.buttonWróć);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "WczytajGrę";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WczytajGrę";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonWróć;
        private System.Windows.Forms.Label wersjaGry;
        private System.Windows.Forms.Label info;
    }
}