namespace Unstable
{
    partial class _01PiętroPierwsze
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_01PiętroPierwsze));
            this.timerGracz = new System.Windows.Forms.Timer(this.components);
            this.timerAtakGracz = new System.Windows.Forms.Timer(this.components);
            this.timerStatystyki = new System.Windows.Forms.Timer(this.components);
            this.timerStrzałaGracz = new System.Windows.Forms.Timer(this.components);
            this.timerAtakMob = new System.Windows.Forms.Timer(this.components);
            this.timerMob = new System.Windows.Forms.Timer(this.components);
            this.timerNPC = new System.Windows.Forms.Timer(this.components);
            this.panelStatystyk = new System.Windows.Forms.Panel();
            this.labelExpGracz = new System.Windows.Forms.Label();
            this.labelLvGracz = new System.Windows.Forms.Label();
            this.labelManaGracz = new System.Windows.Forms.Label();
            this.hitLog = new System.Windows.Forms.Label();
            this.labelHpGracz = new System.Windows.Forms.Label();
            this.poleGry = new System.Windows.Forms.Panel();
            this.drop0 = new System.Windows.Forms.PictureBox();
            this.strzałaGracz = new System.Windows.Forms.PictureBox();
            this.gracz = new System.Windows.Forms.PictureBox();
            this.ściana1 = new System.Windows.Forms.PictureBox();
            this.ściana3 = new System.Windows.Forms.PictureBox();
            this.rozdajStatystyki = new System.Windows.Forms.PictureBox();
            this.ściana2 = new System.Windows.Forms.PictureBox();
            this.underGracz = new System.Windows.Forms.PictureBox();
            this.wyjścieParter = new System.Windows.Forms.PictureBox();
            this.panelStatystyk.SuspendLayout();
            this.poleGry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drop0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.strzałaGracz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gracz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ściana1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ściana3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rozdajStatystyki)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ściana2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.underGracz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wyjścieParter)).BeginInit();
            this.SuspendLayout();
            // 
            // timerGracz
            // 
            this.timerGracz.Enabled = true;
            this.timerGracz.Interval = 50;
            this.timerGracz.Tick += new System.EventHandler(this.timerGracz_Tick);
            // 
            // timerAtakGracz
            // 
            this.timerAtakGracz.Enabled = true;
            this.timerAtakGracz.Tick += new System.EventHandler(this.timerAtakGracz_Tick);
            // 
            // timerStatystyki
            // 
            this.timerStatystyki.Enabled = true;
            this.timerStatystyki.Interval = 1;
            this.timerStatystyki.Tick += new System.EventHandler(this.timerStatystyki_Tick);
            // 
            // timerStrzałaGracz
            // 
            this.timerStrzałaGracz.Enabled = true;
            this.timerStrzałaGracz.Interval = 1;
            this.timerStrzałaGracz.Tick += new System.EventHandler(this.timerStrzałaGracz_Tick);
            // 
            // timerMob
            // 
            this.timerMob.Interval = 50;
            // 
            // timerNPC
            // 
            this.timerNPC.Enabled = true;
            this.timerNPC.Interval = 1;
            // 
            // panelStatystyk
            // 
            this.panelStatystyk.BackColor = System.Drawing.Color.Snow;
            this.panelStatystyk.BackgroundImage = global::Unstable.Properties.Resources.PanelStatystyk;
            this.panelStatystyk.Controls.Add(this.labelExpGracz);
            this.panelStatystyk.Controls.Add(this.labelLvGracz);
            this.panelStatystyk.Controls.Add(this.labelManaGracz);
            this.panelStatystyk.Controls.Add(this.hitLog);
            this.panelStatystyk.Controls.Add(this.labelHpGracz);
            this.panelStatystyk.Location = new System.Drawing.Point(2, 445);
            this.panelStatystyk.Name = "panelStatystyk";
            this.panelStatystyk.Size = new System.Drawing.Size(780, 115);
            this.panelStatystyk.TabIndex = 39;
            // 
            // labelExpGracz
            // 
            this.labelExpGracz.AutoSize = true;
            this.labelExpGracz.BackColor = System.Drawing.Color.Transparent;
            this.labelExpGracz.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelExpGracz.Location = new System.Drawing.Point(12, 88);
            this.labelExpGracz.Name = "labelExpGracz";
            this.labelExpGracz.Size = new System.Drawing.Size(112, 25);
            this.labelExpGracz.TabIndex = 11;
            this.labelExpGracz.Text = "expGracz";
            // 
            // labelLvGracz
            // 
            this.labelLvGracz.AutoSize = true;
            this.labelLvGracz.BackColor = System.Drawing.Color.Transparent;
            this.labelLvGracz.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLvGracz.Location = new System.Drawing.Point(12, 63);
            this.labelLvGracz.Name = "labelLvGracz";
            this.labelLvGracz.Size = new System.Drawing.Size(92, 25);
            this.labelLvGracz.TabIndex = 10;
            this.labelLvGracz.Text = "lvGracz";
            // 
            // labelManaGracz
            // 
            this.labelManaGracz.AutoSize = true;
            this.labelManaGracz.BackColor = System.Drawing.Color.Transparent;
            this.labelManaGracz.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelManaGracz.Location = new System.Drawing.Point(12, 38);
            this.labelManaGracz.Name = "labelManaGracz";
            this.labelManaGracz.Size = new System.Drawing.Size(131, 25);
            this.labelManaGracz.TabIndex = 9;
            this.labelManaGracz.Text = "manaGracz";
            // 
            // hitLog
            // 
            this.hitLog.AutoSize = true;
            this.hitLog.BackColor = System.Drawing.Color.Tomato;
            this.hitLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.hitLog.ForeColor = System.Drawing.Color.Gold;
            this.hitLog.Location = new System.Drawing.Point(533, 8);
            this.hitLog.MaximumSize = new System.Drawing.Size(240, 100);
            this.hitLog.MinimumSize = new System.Drawing.Size(240, 100);
            this.hitLog.Name = "hitLog";
            this.hitLog.Size = new System.Drawing.Size(240, 100);
            this.hitLog.TabIndex = 5;
            // 
            // labelHpGracz
            // 
            this.labelHpGracz.AutoSize = true;
            this.labelHpGracz.BackColor = System.Drawing.Color.Transparent;
            this.labelHpGracz.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelHpGracz.Location = new System.Drawing.Point(12, 13);
            this.labelHpGracz.Name = "labelHpGracz";
            this.labelHpGracz.Size = new System.Drawing.Size(100, 25);
            this.labelHpGracz.TabIndex = 4;
            this.labelHpGracz.Text = "hpGracz";
            // 
            // poleGry
            // 
            this.poleGry.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.poleGry.BackColor = System.Drawing.Color.Transparent;
            this.poleGry.BackgroundImage = global::Unstable.Properties.Resources._01PiętroPierwsze;
            this.poleGry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.poleGry.CausesValidation = false;
            this.poleGry.Controls.Add(this.strzałaGracz);
            this.poleGry.Controls.Add(this.gracz);
            this.poleGry.Controls.Add(this.ściana1);
            this.poleGry.Controls.Add(this.ściana3);
            this.poleGry.Controls.Add(this.rozdajStatystyki);
            this.poleGry.Controls.Add(this.ściana2);
            this.poleGry.Controls.Add(this.underGracz);
            this.poleGry.Controls.Add(this.wyjścieParter);
            this.poleGry.Controls.Add(this.drop0);
            this.poleGry.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.poleGry.Location = new System.Drawing.Point(3, -14);
            this.poleGry.Name = "poleGry";
            this.poleGry.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.poleGry.Size = new System.Drawing.Size(780, 450);
            this.poleGry.TabIndex = 38;
            // 
            // drop0
            // 
            this.drop0.Image = global::Unstable.Properties.Resources.ZbutwiałyŁuk;
            this.drop0.Location = new System.Drawing.Point(378, 69);
            this.drop0.Name = "drop0";
            this.drop0.Size = new System.Drawing.Size(48, 48);
            this.drop0.TabIndex = 40;
            this.drop0.TabStop = false;
            // 
            // strzałaGracz
            // 
            this.strzałaGracz.Image = global::Unstable.Properties.Resources.StrzałaRight;
            this.strzałaGracz.Location = new System.Drawing.Point(9, 15);
            this.strzałaGracz.MaximumSize = new System.Drawing.Size(32, 12);
            this.strzałaGracz.MinimumSize = new System.Drawing.Size(32, 12);
            this.strzałaGracz.Name = "strzałaGracz";
            this.strzałaGracz.Size = new System.Drawing.Size(32, 12);
            this.strzałaGracz.TabIndex = 5;
            this.strzałaGracz.TabStop = false;
            // 
            // gracz
            // 
            this.gracz.BackColor = System.Drawing.Color.Transparent;
            this.gracz.Cursor = System.Windows.Forms.Cursors.Default;
            this.gracz.Image = global::Unstable.Properties.Resources.whiteBrownStand;
            this.gracz.Location = new System.Drawing.Point(79, 262);
            this.gracz.Margin = new System.Windows.Forms.Padding(10);
            this.gracz.MaximumSize = new System.Drawing.Size(64, 64);
            this.gracz.MinimumSize = new System.Drawing.Size(64, 64);
            this.gracz.Name = "gracz";
            this.gracz.Size = new System.Drawing.Size(64, 64);
            this.gracz.TabIndex = 0;
            this.gracz.TabStop = false;
            // 
            // ściana1
            // 
            this.ściana1.Location = new System.Drawing.Point(17, 3);
            this.ściana1.Name = "ściana1";
            this.ściana1.Size = new System.Drawing.Size(87, 137);
            this.ściana1.TabIndex = 8;
            this.ściana1.TabStop = false;
            // 
            // ściana3
            // 
            this.ściana3.Location = new System.Drawing.Point(103, 3);
            this.ściana3.Name = "ściana3";
            this.ściana3.Size = new System.Drawing.Size(159, 24);
            this.ściana3.TabIndex = 33;
            this.ściana3.TabStop = false;
            // 
            // rozdajStatystyki
            // 
            this.rozdajStatystyki.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rozdajStatystyki.Image = global::Unstable.Properties.Resources.rozdajStatystyki;
            this.rozdajStatystyki.Location = new System.Drawing.Point(17, 410);
            this.rozdajStatystyki.MaximumSize = new System.Drawing.Size(32, 32);
            this.rozdajStatystyki.MinimumSize = new System.Drawing.Size(32, 32);
            this.rozdajStatystyki.Name = "rozdajStatystyki";
            this.rozdajStatystyki.Size = new System.Drawing.Size(32, 32);
            this.rozdajStatystyki.TabIndex = 32;
            this.rozdajStatystyki.TabStop = false;
            this.rozdajStatystyki.Visible = false;
            this.rozdajStatystyki.Click += new System.EventHandler(this.rozdajStatystyki_Click);
            // 
            // ściana2
            // 
            this.ściana2.Location = new System.Drawing.Point(262, 3);
            this.ściana2.Name = "ściana2";
            this.ściana2.Size = new System.Drawing.Size(110, 137);
            this.ściana2.TabIndex = 31;
            this.ściana2.TabStop = false;
            // 
            // underGracz
            // 
            this.underGracz.BackColor = System.Drawing.Color.Transparent;
            this.underGracz.Cursor = System.Windows.Forms.Cursors.Default;
            this.underGracz.Location = new System.Drawing.Point(79, 262);
            this.underGracz.Margin = new System.Windows.Forms.Padding(10);
            this.underGracz.MaximumSize = new System.Drawing.Size(64, 64);
            this.underGracz.MinimumSize = new System.Drawing.Size(64, 64);
            this.underGracz.Name = "underGracz";
            this.underGracz.Size = new System.Drawing.Size(64, 64);
            this.underGracz.TabIndex = 3;
            this.underGracz.TabStop = false;
            // 
            // wyjścieParter
            // 
            this.wyjścieParter.Location = new System.Drawing.Point(219, 15);
            this.wyjścieParter.Name = "wyjścieParter";
            this.wyjścieParter.Size = new System.Drawing.Size(43, 64);
            this.wyjścieParter.TabIndex = 35;
            this.wyjścieParter.TabStop = false;
            // 
            // _01PiętroPierwsze
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.ControlBox = false;
            this.Controls.Add(this.panelStatystyk);
            this.Controls.Add(this.poleGry);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "_01PiętroPierwsze";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "_01PiętroPierwsze";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TheKeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TheKeyUp);
            this.panelStatystyk.ResumeLayout(false);
            this.panelStatystyk.PerformLayout();
            this.poleGry.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.drop0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.strzałaGracz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gracz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ściana1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ściana3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rozdajStatystyki)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ściana2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.underGracz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wyjścieParter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox strzałaGracz;
        private System.Windows.Forms.PictureBox gracz;
        private System.Windows.Forms.PictureBox ściana1;
        private System.Windows.Forms.PictureBox ściana3;
        private System.Windows.Forms.Panel poleGry;
        private System.Windows.Forms.PictureBox rozdajStatystyki;
        private System.Windows.Forms.PictureBox ściana2;
        private System.Windows.Forms.PictureBox underGracz;
        private System.Windows.Forms.PictureBox wyjścieParter;
        private System.Windows.Forms.Timer timerGracz;
        private System.Windows.Forms.Timer timerAtakGracz;
        private System.Windows.Forms.Timer timerStatystyki;
        private System.Windows.Forms.Timer timerStrzałaGracz;
        private System.Windows.Forms.Timer timerAtakMob;
        private System.Windows.Forms.Timer timerMob;
        private System.Windows.Forms.Timer timerNPC;
        private System.Windows.Forms.Label labelHpGracz;
        private System.Windows.Forms.Panel panelStatystyk;
        private System.Windows.Forms.Label labelExpGracz;
        private System.Windows.Forms.Label labelLvGracz;
        private System.Windows.Forms.Label labelManaGracz;
        private System.Windows.Forms.Label hitLog;
        private System.Windows.Forms.PictureBox drop0;
    }
}