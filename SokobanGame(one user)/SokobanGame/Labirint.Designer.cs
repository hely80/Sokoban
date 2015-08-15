namespace SokobanGame
{
    partial class Labirint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Labirint));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolPrevLevel = new System.Windows.Forms.ToolStripButton();
            this.toolNextLevel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolLevelText = new System.Windows.Forms.ToolStripLabel();
            this.toolLevel = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStatText = new System.Windows.Forms.ToolStripLabel();
            this.toolStat = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolDone = new System.Windows.Forms.ToolStripLabel();
            this.toolRestart = new System.Windows.Forms.ToolStripButton();
            this.panel = new System.Windows.Forms.Panel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.LavenderBlush;
            this.toolStrip1.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolPrevLevel,
            this.toolNextLevel,
            this.toolStripSeparator3,
            this.toolLevelText,
            this.toolLevel,
            this.toolStripSeparator1,
            this.toolStatText,
            this.toolStat,
            this.toolStripSeparator2,
            this.toolDone,
            this.toolRestart});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(567, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolPrevLevel
            // 
            this.toolPrevLevel.BackColor = System.Drawing.Color.Transparent;
            this.toolPrevLevel.BackgroundImage = global::SokobanGame.Properties.Resources.left;
            this.toolPrevLevel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.toolPrevLevel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolPrevLevel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolPrevLevel.Name = "toolPrevLevel";
            this.toolPrevLevel.Size = new System.Drawing.Size(23, 22);
            this.toolPrevLevel.Text = "toolStripButton1";
            this.toolPrevLevel.ToolTipText = "На предыдущий уровень";
            this.toolPrevLevel.Click += new System.EventHandler(this.toolPrevLevel_Click);
            // 
            // toolNextLevel
            // 
            this.toolNextLevel.BackgroundImage = global::SokobanGame.Properties.Resources.right;
            this.toolNextLevel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.toolNextLevel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolNextLevel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolNextLevel.Name = "toolNextLevel";
            this.toolNextLevel.Size = new System.Drawing.Size(23, 22);
            this.toolNextLevel.Text = "toolStripButton2";
            this.toolNextLevel.ToolTipText = "На следующий уровень";
            this.toolNextLevel.Click += new System.EventHandler(this.toolNextLevel_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolLevelText
            // 
            this.toolLevelText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.toolLevelText.Name = "toolLevelText";
            this.toolLevelText.Size = new System.Drawing.Size(75, 22);
            this.toolLevelText.Text = "Уровень №";
            // 
            // toolLevel
            // 
            this.toolLevel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.toolLevel.Name = "toolLevel";
            this.toolLevel.Size = new System.Drawing.Size(15, 22);
            this.toolLevel.Text = "1";
            this.toolLevel.ToolTipText = "Номер уровня";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStatText
            // 
            this.toolStatText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.toolStatText.Name = "toolStatText";
            this.toolStatText.Size = new System.Drawing.Size(141, 22);
            this.toolStatText.Text = "Установлено ящиков:";
            // 
            // toolStat
            // 
            this.toolStat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.toolStat.Name = "toolStat";
            this.toolStat.Size = new System.Drawing.Size(40, 22);
            this.toolStat.Text = "0 из 5";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolDone
            // 
            this.toolDone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.toolDone.Name = "toolDone";
            this.toolDone.Size = new System.Drawing.Size(114, 22);
            this.toolDone.Text = "Уровень пройден!";
            this.toolDone.Visible = false;
            // 
            // toolRestart
            // 
            this.toolRestart.BackColor = System.Drawing.Color.Transparent;
            this.toolRestart.BackgroundImage = global::SokobanGame.Properties.Resources.resize;
            this.toolRestart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.toolRestart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolRestart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolRestart.Name = "toolRestart";
            this.toolRestart.Size = new System.Drawing.Size(23, 22);
            this.toolRestart.Text = "toolStripButton3";
            this.toolRestart.ToolTipText = "Начать уровень заново";
            this.toolRestart.Click += new System.EventHandler(this.toolRestart_Click);
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.Transparent;
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 25);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(567, 354);
            this.panel.TabIndex = 1;
            this.panel.Resize += new System.EventHandler(this.panel_Resize);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Labirint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(567, 379);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Labirint";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лабиринт";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Labirint_KeyDown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolLevelText;
        private System.Windows.Forms.ToolStripButton toolRestart;
        private System.Windows.Forms.ToolStripButton toolPrevLevel;
        private System.Windows.Forms.ToolStripButton toolNextLevel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel toolLevel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStatText;
        private System.Windows.Forms.ToolStripLabel toolStat;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolDone;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Timer timer;
    }
}