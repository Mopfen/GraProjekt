﻿namespace Unstable
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
            this.timerStatystyki = new System.Windows.Forms.Timer(this.components);
            this.labelHpGracz = new System.Windows.Forms.Label();
            this.poleGry = new System.Windows.Forms.Panel();
            this.labelHpMob = new System.Windows.Forms.Label();
            this.gracz = new System.Windows.Forms.PictureBox();
            this.mob = new System.Windows.Forms.PictureBox();
            this.underGracz = new System.Windows.Forms.PictureBox();
            this.underMob = new System.Windows.Forms.PictureBox();
            this.hitLog = new System.Windows.Forms.Label();
            this.timerMob = new System.Windows.Forms.Timer(this.components);
            this.timerAtakMob = new System.Windows.Forms.Timer(this.components);
            this.panelStatystyk = new System.Windows.Forms.Panel();
            this.labelManaGracz = new System.Windows.Forms.Label();
            this.labelLvGracz = new System.Windows.Forms.Label();
            this.labelExpGracz = new System.Windows.Forms.Label();
            this.poleGry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gracz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mob)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.underGracz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.underMob)).BeginInit();
            this.panelStatystyk.SuspendLayout();
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
            // timerStatystyki
            // 
            this.timerStatystyki.Interval = 1;
            this.timerStatystyki.Tick += new System.EventHandler(this.timerStatystyki_Tick);
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
            this.poleGry.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("poleGry.BackgroundImage")));
            this.poleGry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.poleGry.CausesValidation = false;
            this.poleGry.Controls.Add(this.labelHpMob);
            this.poleGry.Controls.Add(this.gracz);
            this.poleGry.Controls.Add(this.mob);
            this.poleGry.Controls.Add(this.underGracz);
            this.poleGry.Controls.Add(this.underMob);
            this.poleGry.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.poleGry.Location = new System.Drawing.Point(0, -2);
            this.poleGry.Name = "poleGry";
            this.poleGry.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.poleGry.Size = new System.Drawing.Size(780, 450);
            this.poleGry.TabIndex = 2;
            // 
            // labelHpMob
            // 
            this.labelHpMob.AutoSize = true;
            this.labelHpMob.BackColor = System.Drawing.Color.Transparent;
            this.labelHpMob.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelHpMob.ForeColor = System.Drawing.Color.Green;
            this.labelHpMob.Location = new System.Drawing.Point(412, 158);
            this.labelHpMob.Name = "labelHpMob";
            this.labelHpMob.Size = new System.Drawing.Size(63, 20);
            this.labelHpMob.TabIndex = 4;
            this.labelHpMob.Text = "hpMob";
            // 
            // gracz
            // 
            this.gracz.BackColor = System.Drawing.Color.Transparent;
            this.gracz.Cursor = System.Windows.Forms.Cursors.Default;
            this.gracz.Image = global::Unstable.Properties.Resources.whiteBrownStand;
            this.gracz.Location = new System.Drawing.Point(168, 188);
            this.gracz.Margin = new System.Windows.Forms.Padding(10);
            this.gracz.MaximumSize = new System.Drawing.Size(64, 64);
            this.gracz.MinimumSize = new System.Drawing.Size(64, 64);
            this.gracz.Name = "gracz";
            this.gracz.Size = new System.Drawing.Size(64, 64);
            this.gracz.TabIndex = 0;
            this.gracz.TabStop = false;
            // 
            // mob
            // 
            this.mob.BackColor = System.Drawing.Color.Transparent;
            this.mob.Image = global::Unstable.Properties.Resources.whiteBrownStand;
            this.mob.Location = new System.Drawing.Point(411, 188);
            this.mob.Margin = new System.Windows.Forms.Padding(10);
            this.mob.MaximumSize = new System.Drawing.Size(64, 64);
            this.mob.MinimumSize = new System.Drawing.Size(64, 64);
            this.mob.Name = "mob";
            this.mob.Size = new System.Drawing.Size(64, 64);
            this.mob.TabIndex = 1;
            this.mob.TabStop = false;
            // 
            // underGracz
            // 
            this.underGracz.BackColor = System.Drawing.Color.Transparent;
            this.underGracz.Cursor = System.Windows.Forms.Cursors.Default;
            this.underGracz.Location = new System.Drawing.Point(168, 188);
            this.underGracz.Margin = new System.Windows.Forms.Padding(10);
            this.underGracz.MaximumSize = new System.Drawing.Size(64, 64);
            this.underGracz.MinimumSize = new System.Drawing.Size(64, 64);
            this.underGracz.Name = "underGracz";
            this.underGracz.Size = new System.Drawing.Size(64, 64);
            this.underGracz.TabIndex = 3;
            this.underGracz.TabStop = false;
            // 
            // underMob
            // 
            this.underMob.Location = new System.Drawing.Point(411, 188);
            this.underMob.Name = "underMob";
            this.underMob.Size = new System.Drawing.Size(64, 64);
            this.underMob.TabIndex = 5;
            this.underMob.TabStop = false;
            // 
            // hitLog
            // 
            this.hitLog.AutoSize = true;
            this.hitLog.BackColor = System.Drawing.Color.Tomato;
            this.hitLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.hitLog.ForeColor = System.Drawing.Color.Gold;
            this.hitLog.Location = new System.Drawing.Point(538, 3);
            this.hitLog.Name = "hitLog";
            this.hitLog.Size = new System.Drawing.Size(239, 120);
            this.hitLog.TabIndex = 5;
            this.hitLog.Text = "                                                          \r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n";
            // 
            // timerMob
            // 
            this.timerMob.Interval = 50;
            this.timerMob.Tick += new System.EventHandler(this.timerMob_Tick);
            // 
            // timerAtakMob
            // 
            this.timerAtakMob.Tick += new System.EventHandler(this.timerAtakMob_Tick);
            // 
            // panelStatystyk
            // 
            this.panelStatystyk.BackColor = System.Drawing.Color.Olive;
            this.panelStatystyk.Controls.Add(this.labelExpGracz);
            this.panelStatystyk.Controls.Add(this.labelLvGracz);
            this.panelStatystyk.Controls.Add(this.labelManaGracz);
            this.panelStatystyk.Controls.Add(this.hitLog);
            this.panelStatystyk.Controls.Add(this.labelHpGracz);
            this.panelStatystyk.Location = new System.Drawing.Point(0, 448);
            this.panelStatystyk.Name = "panelStatystyk";
            this.panelStatystyk.Size = new System.Drawing.Size(780, 115);
            this.panelStatystyk.TabIndex = 6;
            // 
            // labelManaGracz
            // 
            this.labelManaGracz.AutoSize = true;
            this.labelManaGracz.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelManaGracz.Location = new System.Drawing.Point(12, 38);
            this.labelManaGracz.Name = "labelManaGracz";
            this.labelManaGracz.Size = new System.Drawing.Size(131, 25);
            this.labelManaGracz.TabIndex = 6;
            this.labelManaGracz.Text = "manaGracz";
            // 
            // labelLvGracz
            // 
            this.labelLvGracz.AutoSize = true;
            this.labelLvGracz.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLvGracz.Location = new System.Drawing.Point(12, 63);
            this.labelLvGracz.Name = "labelLvGracz";
            this.labelLvGracz.Size = new System.Drawing.Size(92, 25);
            this.labelLvGracz.TabIndex = 7;
            this.labelLvGracz.Text = "lvGracz";
            // 
            // labelExpGracz
            // 
            this.labelExpGracz.AutoSize = true;
            this.labelExpGracz.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelExpGracz.Location = new System.Drawing.Point(12, 88);
            this.labelExpGracz.Name = "labelExpGracz";
            this.labelExpGracz.Size = new System.Drawing.Size(112, 25);
            this.labelExpGracz.TabIndex = 8;
            this.labelExpGracz.Text = "expGracz";
            // 
            // Mapa1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.ControlBox = false;
            this.Controls.Add(this.panelStatystyk);
            this.Controls.Add(this.poleGry);
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Mapa1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mapa1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Mapa1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Mapa1_KeyUp);
            this.poleGry.ResumeLayout(false);
            this.poleGry.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gracz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mob)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.underGracz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.underMob)).EndInit();
            this.panelStatystyk.ResumeLayout(false);
            this.panelStatystyk.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timerGracz;
        private System.Windows.Forms.Panel poleGry;
        private System.Windows.Forms.PictureBox mob;
        private System.Windows.Forms.PictureBox gracz;
        private System.Windows.Forms.Timer timerAtakGracz;
        private System.Windows.Forms.PictureBox underGracz;
        private System.Windows.Forms.Label labelHpMob;
        private System.Windows.Forms.Timer timerStatystyki;
        private System.Windows.Forms.Label labelHpGracz;
        private System.Windows.Forms.Label hitLog;
        private System.Windows.Forms.Timer timerMob;
        private System.Windows.Forms.Timer timerAtakMob;
        private System.Windows.Forms.PictureBox underMob;
        private System.Windows.Forms.Panel panelStatystyk;
        private System.Windows.Forms.Label labelExpGracz;
        private System.Windows.Forms.Label labelLvGracz;
        private System.Windows.Forms.Label labelManaGracz;
    }
}