namespace Unstable
{
    partial class Mapa1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mapa1));
            this.timerGracz = new System.Windows.Forms.Timer(this.components);
            this.timerAtakGracz = new System.Windows.Forms.Timer(this.components);
            this.zbroja = new System.Windows.Forms.PictureBox();
            this.gracz = new System.Windows.Forms.PictureBox();
            this.mob = new System.Windows.Forms.PictureBox();
            this.poleGry = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.zbroja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gracz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mob)).BeginInit();
            this.SuspendLayout();
            // 
            // timerGracz
            // 
            this.timerGracz.Interval = 50;
            this.timerGracz.Tick += new System.EventHandler(this.timerGracz_Tick);
            // 
            // timerAtakGracz
            // 
            this.timerAtakGracz.Tick += new System.EventHandler(this.timerAtakGracz_Tick);
            // 
            // zbroja
            // 
            this.zbroja.BackColor = System.Drawing.Color.Transparent;
            this.zbroja.Image = ((System.Drawing.Image)(resources.GetObject("zbroja.Image")));
            this.zbroja.Location = new System.Drawing.Point(38, 160);
            this.zbroja.Margin = new System.Windows.Forms.Padding(0);
            this.zbroja.MaximumSize = new System.Drawing.Size(64, 64);
            this.zbroja.MinimumSize = new System.Drawing.Size(64, 64);
            this.zbroja.Name = "zbroja";
            this.zbroja.Size = new System.Drawing.Size(64, 64);
            this.zbroja.TabIndex = 2;
            this.zbroja.TabStop = false;
            // 
            // gracz
            // 
            this.gracz.BackColor = System.Drawing.Color.Transparent;
            this.gracz.Cursor = System.Windows.Forms.Cursors.Default;
            this.gracz.Image = global::Unstable.Properties.Resources.StandWhiteManBrownHairBlueEyes;
            this.gracz.Location = new System.Drawing.Point(198, 160);
            this.gracz.Margin = new System.Windows.Forms.Padding(10);
            this.gracz.MaximumSize = new System.Drawing.Size(64, 64);
            this.gracz.MinimumSize = new System.Drawing.Size(64, 64);
            this.gracz.Name = "gracz";
            this.gracz.Size = new System.Drawing.Size(64, 64);
            this.gracz.TabIndex = 0;
            this.gracz.TabStop = false;
            this.gracz.WaitOnLoad = true;
            // 
            // mob
            // 
            this.mob.BackColor = System.Drawing.Color.Transparent;
            this.mob.Image = global::Unstable.Properties.Resources.StandWhiteManBrownHairBlueEyes1;
            this.mob.Location = new System.Drawing.Point(534, 160);
            this.mob.Margin = new System.Windows.Forms.Padding(10);
            this.mob.MaximumSize = new System.Drawing.Size(64, 64);
            this.mob.MinimumSize = new System.Drawing.Size(64, 64);
            this.mob.Name = "mob";
            this.mob.Size = new System.Drawing.Size(64, 64);
            this.mob.TabIndex = 1;
            this.mob.TabStop = false;
            // 
            // poleGry
            // 
            this.poleGry.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.poleGry.BackColor = System.Drawing.Color.Transparent;
            this.poleGry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.poleGry.CausesValidation = false;
            this.poleGry.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.poleGry.Location = new System.Drawing.Point(0, -2);
            this.poleGry.Name = "poleGry";
            this.poleGry.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.poleGry.Size = new System.Drawing.Size(784, 566);
            this.poleGry.TabIndex = 7;
            // 
            // Mapa1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.zbroja);
            this.Controls.Add(this.mob);
            this.Controls.Add(this.gracz);
            this.Controls.Add(this.poleGry);
            this.DoubleBuffered = true;
            this.Name = "Mapa1";
            this.Text = "Mapa1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Mapa1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Mapa1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.zbroja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gracz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mob)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timerGracz;
        private System.Windows.Forms.PictureBox zbroja;
        private System.Windows.Forms.PictureBox mob;
        private System.Windows.Forms.PictureBox gracz;
        private System.Windows.Forms.Timer timerAtakGracz;
        private System.Windows.Forms.Panel poleGry;
    }
}