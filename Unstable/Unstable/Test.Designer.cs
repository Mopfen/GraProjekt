namespace Unstable
{
    partial class Test
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Test));
            this.aktualizatorGracz = new System.Windows.Forms.Timer(this.components);
            this.aktualizatorMob = new System.Windows.Forms.Timer(this.components);
            this.aktualizatorAtak = new System.Windows.Forms.Timer(this.components);
            this.poleGry = new System.Windows.Forms.Panel();
            this.zbroja = new System.Windows.Forms.PictureBox();
            this.mob = new System.Windows.Forms.PictureBox();
            this.gracz = new System.Windows.Forms.PictureBox();
            this.poleGry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zbroja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mob)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gracz)).BeginInit();
            this.SuspendLayout();
            // 
            // aktualizatorGracz
            // 
            this.aktualizatorGracz.Tick += new System.EventHandler(this.aktualizatorGracz_Tick);
            // 
            // aktualizatorMob
            // 
            this.aktualizatorMob.Tick += new System.EventHandler(this.aktualizatorMob_Tick);
            // 
            // aktualizatorAtak
            // 
            this.aktualizatorAtak.Tick += new System.EventHandler(this.aktualizatorAtak_Tick);
            // 
            // poleGry
            // 
            this.poleGry.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.poleGry.BackColor = System.Drawing.Color.Transparent;
            this.poleGry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.poleGry.CausesValidation = false;
            this.poleGry.Controls.Add(this.zbroja);
            this.poleGry.Controls.Add(this.mob);
            this.poleGry.Controls.Add(this.gracz);
            this.poleGry.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.poleGry.Location = new System.Drawing.Point(0, -2);
            this.poleGry.Name = "poleGry";
            this.poleGry.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.poleGry.Size = new System.Drawing.Size(784, 566);
            this.poleGry.TabIndex = 1;
            // 
            // zbroja
            // 
            this.zbroja.BackColor = System.Drawing.Color.Transparent;
            this.zbroja.Image = ((System.Drawing.Image)(resources.GetObject("zbroja.Image")));
            this.zbroja.Location = new System.Drawing.Point(69, 188);
            this.zbroja.Margin = new System.Windows.Forms.Padding(0);
            this.zbroja.MaximumSize = new System.Drawing.Size(64, 64);
            this.zbroja.MinimumSize = new System.Drawing.Size(64, 64);
            this.zbroja.Name = "zbroja";
            this.zbroja.Size = new System.Drawing.Size(64, 64);
            this.zbroja.TabIndex = 2;
            this.zbroja.TabStop = false;
            // 
            // mob
            // 
            this.mob.BackColor = System.Drawing.Color.Transparent;
            this.mob.Image = global::Unstable.Properties.Resources.StandWhiteManBrownHairBlueEyes1;
            this.mob.Location = new System.Drawing.Point(400, 188);
            this.mob.Margin = new System.Windows.Forms.Padding(10);
            this.mob.MaximumSize = new System.Drawing.Size(64, 64);
            this.mob.MinimumSize = new System.Drawing.Size(64, 64);
            this.mob.Name = "mob";
            this.mob.Size = new System.Drawing.Size(64, 64);
            this.mob.TabIndex = 1;
            this.mob.TabStop = false;
            // 
            // gracz
            // 
            this.gracz.BackColor = System.Drawing.Color.Transparent;
            this.gracz.Cursor = System.Windows.Forms.Cursors.Default;
            this.gracz.Image = global::Unstable.Properties.Resources.StandWhiteManBrownHairBlueEyes;
            this.gracz.Location = new System.Drawing.Point(247, 188);
            this.gracz.Margin = new System.Windows.Forms.Padding(10);
            this.gracz.MaximumSize = new System.Drawing.Size(64, 64);
            this.gracz.MinimumSize = new System.Drawing.Size(64, 64);
            this.gracz.Name = "gracz";
            this.gracz.Size = new System.Drawing.Size(64, 64);
            this.gracz.TabIndex = 0;
            this.gracz.TabStop = false;
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.poleGry);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Test";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test";
            this.Load += new System.EventHandler(this.Test_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Test_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Test_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Test_KeyUp);
            this.poleGry.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.zbroja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mob)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gracz)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer aktualizatorGracz;
        private System.Windows.Forms.Panel poleGry;
        private System.Windows.Forms.PictureBox mob;
        private System.Windows.Forms.Timer aktualizatorMob;
        private System.Windows.Forms.Timer aktualizatorAtak;
        private System.Windows.Forms.PictureBox zbroja;
        private System.Windows.Forms.PictureBox gracz;
    }
}