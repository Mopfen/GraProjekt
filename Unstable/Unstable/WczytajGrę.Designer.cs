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
            // WczytajGrę
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.buttonWróć);
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "WczytajGrę";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WczytajGrę";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonWróć;
    }
}