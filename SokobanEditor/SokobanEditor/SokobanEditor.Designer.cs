namespace SokobanEditor
{
    partial class SokobanEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SokobanEditor));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolWall = new System.Windows.Forms.ToolStripButton();
            this.toolUser1 = new System.Windows.Forms.ToolStripButton();
            this.toolUser2 = new System.Windows.Forms.ToolStripButton();
            this.toolAbox = new System.Windows.Forms.ToolStripButton();
            this.statAbox = new System.Windows.Forms.ToolStripLabel();
            this.toolHere = new System.Windows.Forms.ToolStripButton();
            this.statHere = new System.Windows.Forms.ToolStripLabel();
            this.toolDone = new System.Windows.Forms.ToolStripButton();
            this.toolNone = new System.Windows.Forms.ToolStripButton();
            this.toolSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tootSave = new System.Windows.Forms.ToolStripButton();
            this.toolSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolPrev = new System.Windows.Forms.ToolStripButton();
            this.toolNext = new System.Windows.Forms.ToolStripButton();
            this.toolSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolLabelSize = new System.Windows.Forms.ToolStripLabel();
            this.toolTextBoxSize = new System.Windows.Forms.ToolStripComboBox();
            this.toolSetSize = new System.Windows.Forms.ToolStripButton();
            this.panel = new System.Windows.Forms.Panel();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.AutoSize = false;
            this.toolStrip.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolWall,
            this.toolUser1,
            this.toolUser2,
            this.statAbox,
            this.toolAbox,
            this.statHere,
            this.toolHere,
            this.toolDone,
            this.toolNone,
            this.toolSeparator1,
            this.tootSave,
            this.toolSeparator3,
            this.toolPrev,
            this.toolNext,
            this.toolSeparator2,
            this.toolLabelSize,
            this.toolTextBoxSize,
            this.toolSetSize});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(815, 55);
            this.toolStrip.TabIndex = 0;
            this.toolStrip.Text = "toolStrip1";
            // 
            // toolWall
            // 
            this.toolWall.AutoSize = false;
            this.toolWall.AutoToolTip = false;
            this.toolWall.BackgroundImage = global::SokobanEditor.Properties.Resources.wall;
            this.toolWall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.toolWall.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolWall.DoubleClickEnabled = true;
            this.toolWall.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolWall.Name = "toolWall";
            this.toolWall.Size = new System.Drawing.Size(50, 50);
            this.toolWall.Text = "toolStripButton1";
            this.toolWall.ToolTipText = "Стена";
            this.toolWall.Click += new System.EventHandler(this.toolWall_Click);
            // 
            // toolUser1
            // 
            this.toolUser1.AutoSize = false;
            this.toolUser1.AutoToolTip = false;
            this.toolUser1.BackgroundImage = global::SokobanEditor.Properties.Resources.user1;
            this.toolUser1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.toolUser1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolUser1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolUser1.Name = "toolUser1";
            this.toolUser1.Size = new System.Drawing.Size(50, 50);
            this.toolUser1.Text = "toolStripButton6";
            this.toolUser1.ToolTipText = "Игрок";
            this.toolUser1.Click += new System.EventHandler(this.toolUser1_Click);
            // 
            // toolUser2
            // 
            this.toolUser2.AutoSize = false;
            this.toolUser2.AutoToolTip = false;
            this.toolUser2.BackgroundImage = global::SokobanEditor.Properties.Resources.user2;
            this.toolUser2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.toolUser2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolUser2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolUser2.Name = "toolUser2";
            this.toolUser2.Size = new System.Drawing.Size(50, 50);
            this.toolUser2.Text = "toolStripButton6";
            this.toolUser2.ToolTipText = "Игрок";
            this.toolUser2.Click += new System.EventHandler(this.toolUser2_Click);
            // 
            // toolAbox
            // 
            this.toolAbox.AutoSize = false;
            this.toolAbox.AutoToolTip = false;
            this.toolAbox.BackgroundImage = global::SokobanEditor.Properties.Resources.abox;
            this.toolAbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.toolAbox.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolAbox.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolAbox.Name = "toolAbox";
            this.toolAbox.Size = new System.Drawing.Size(50, 50);
            this.toolAbox.Text = "toolStripButton2";
            this.toolAbox.ToolTipText = "Ящик";
            this.toolAbox.Click += new System.EventHandler(this.toolAbox_Click);
            // 
            // statAbox
            // 
            this.statAbox.AutoSize = false;
            this.statAbox.Name = "statAbox";
            this.statAbox.Size = new System.Drawing.Size(25, 52);
            this.statAbox.Text = "0x";
            this.statAbox.ToolTipText = "Количество ящиков";
            // 
            // toolHere
            // 
            this.toolHere.AutoSize = false;
            this.toolHere.AutoToolTip = false;
            this.toolHere.BackgroundImage = global::SokobanEditor.Properties.Resources.here;
            this.toolHere.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.toolHere.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolHere.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolHere.Name = "toolHere";
            this.toolHere.Size = new System.Drawing.Size(50, 50);
            this.toolHere.Text = "toolStripButton3";
            this.toolHere.ToolTipText = "Место для ящика";
            this.toolHere.Click += new System.EventHandler(this.toolHere_Click);
            // 
            // statHere
            // 
            this.statHere.AutoSize = false;
            this.statHere.Name = "statHere";
            this.statHere.Size = new System.Drawing.Size(25, 52);
            this.statHere.Text = "0x";
            this.statHere.ToolTipText = "Количество мест для ящиков";
            // 
            // toolDone
            // 
            this.toolDone.AutoSize = false;
            this.toolDone.AutoToolTip = false;
            this.toolDone.BackgroundImage = global::SokobanEditor.Properties.Resources.done;
            this.toolDone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.toolDone.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolDone.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolDone.Name = "toolDone";
            this.toolDone.Size = new System.Drawing.Size(50, 50);
            this.toolDone.Text = "toolStripButton4";
            this.toolDone.ToolTipText = "Ящик установленный на место";
            this.toolDone.Click += new System.EventHandler(this.toolDone_Click);
            // 
            // toolNone
            // 
            this.toolNone.AutoSize = false;
            this.toolNone.AutoToolTip = false;
            this.toolNone.BackgroundImage = global::SokobanEditor.Properties.Resources.none;
            this.toolNone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.toolNone.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolNone.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolNone.Name = "toolNone";
            this.toolNone.Size = new System.Drawing.Size(50, 50);
            this.toolNone.Text = "toolStripButton5";
            this.toolNone.ToolTipText = "Пустое поле";
            this.toolNone.Click += new System.EventHandler(this.toolNone_Click);
            // 
            // toolSeparator1
            // 
            this.toolSeparator1.Name = "toolSeparator1";
            this.toolSeparator1.Size = new System.Drawing.Size(6, 55);
            // 
            // tootSave
            // 
            this.tootSave.AutoSize = false;
            this.tootSave.AutoToolTip = false;
            this.tootSave.BackgroundImage = global::SokobanEditor.Properties.Resources.Safe;
            this.tootSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tootSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tootSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tootSave.Name = "tootSave";
            this.tootSave.Size = new System.Drawing.Size(50, 50);
            this.tootSave.Text = "toolStripButton1";
            this.tootSave.ToolTipText = "Сохранить уровень";
            this.tootSave.Click += new System.EventHandler(this.tootSave_Click);
            // 
            // toolSeparator3
            // 
            this.toolSeparator3.Name = "toolSeparator3";
            this.toolSeparator3.Size = new System.Drawing.Size(6, 55);
            // 
            // toolPrev
            // 
            this.toolPrev.AutoSize = false;
            this.toolPrev.AutoToolTip = false;
            this.toolPrev.BackgroundImage = global::SokobanEditor.Properties.Resources.left;
            this.toolPrev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolPrev.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolPrev.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolPrev.Name = "toolPrev";
            this.toolPrev.Size = new System.Drawing.Size(50, 50);
            this.toolPrev.Text = "toolStripButton1";
            this.toolPrev.ToolTipText = "Предыдущий уровень";
            this.toolPrev.Click += new System.EventHandler(this.toolPrev_Click);
            // 
            // toolNext
            // 
            this.toolNext.AutoSize = false;
            this.toolNext.AutoToolTip = false;
            this.toolNext.BackgroundImage = global::SokobanEditor.Properties.Resources.right;
            this.toolNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolNext.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolNext.Name = "toolNext";
            this.toolNext.Size = new System.Drawing.Size(50, 50);
            this.toolNext.Text = "toolStripButton2";
            this.toolNext.ToolTipText = "Следующий уровень";
            this.toolNext.Click += new System.EventHandler(this.toolNext_Click);
            // 
            // toolSeparator2
            // 
            this.toolSeparator2.Name = "toolSeparator2";
            this.toolSeparator2.Size = new System.Drawing.Size(6, 55);
            // 
            // toolLabelSize
            // 
            this.toolLabelSize.ActiveLinkColor = System.Drawing.Color.Transparent;
            this.toolLabelSize.AutoSize = false;
            this.toolLabelSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.toolLabelSize.Name = "toolLabelSize";
            this.toolLabelSize.Size = new System.Drawing.Size(50, 52);
            this.toolLabelSize.Text = " Размер:";
            this.toolLabelSize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolTextBoxSize
            // 
            this.toolTextBoxSize.AutoSize = false;
            this.toolTextBoxSize.BackColor = System.Drawing.Color.LavenderBlush;
            this.toolTextBoxSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toolTextBoxSize.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolTextBoxSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.toolTextBoxSize.Name = "toolTextBoxSize";
            this.toolTextBoxSize.Size = new System.Drawing.Size(80, 26);
            this.toolTextBoxSize.ToolTipText = "Размер поля";
            this.toolTextBoxSize.KeyDown += new System.Windows.Forms.KeyEventHandler(this.toolTextBoxSize_KeyDown);
            // 
            // toolSetSize
            // 
            this.toolSetSize.AutoSize = false;
            this.toolSetSize.AutoToolTip = false;
            this.toolSetSize.BackgroundImage = global::SokobanEditor.Properties.Resources.resize;
            this.toolSetSize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolSetSize.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolSetSize.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSetSize.Name = "toolSetSize";
            this.toolSetSize.Size = new System.Drawing.Size(50, 50);
            this.toolSetSize.Text = "toolStripButton1";
            this.toolSetSize.ToolTipText = "Установить размер поля";
            this.toolSetSize.Click += new System.EventHandler(this.toolSetSize_Click);
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.Transparent;
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 55);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(815, 356);
            this.panel.TabIndex = 1;
            // 
            // SokobanEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(815, 411);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.toolStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SokobanEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактор уровней игры \"СОКОБАН\"";
            this.Load += new System.EventHandler(this.SokobanEditor_Load);
            this.Resize += new System.EventHandler(this.SokobanEditor_Resize);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton toolWall;
        private System.Windows.Forms.ToolStripButton toolAbox;
        private System.Windows.Forms.ToolStripButton toolHere;
        private System.Windows.Forms.ToolStripButton toolDone;
        private System.Windows.Forms.ToolStripButton toolNone;
        private System.Windows.Forms.ToolStripButton toolUser1;
        private System.Windows.Forms.ToolStripSeparator toolSeparator1;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.ToolStripSeparator toolSeparator2;
        private System.Windows.Forms.ToolStripButton tootSave;
        private System.Windows.Forms.ToolStripSeparator toolSeparator3;
        private System.Windows.Forms.ToolStripButton toolPrev;
        private System.Windows.Forms.ToolStripButton toolNext;
        private System.Windows.Forms.ToolStripLabel toolLabelSize;
        private System.Windows.Forms.ToolStripComboBox toolTextBoxSize;
        private System.Windows.Forms.ToolStripButton toolSetSize;
        private System.Windows.Forms.ToolStripLabel statAbox;
        private System.Windows.Forms.ToolStripLabel statHere;
        private System.Windows.Forms.ToolStripButton toolUser2;
    }
}

