namespace SokobanGame
{
    partial class WelcomSokoban
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomSokoban));
            this.buttonStart = new System.Windows.Forms.Button();
            this.textHost = new System.Windows.Forms.TextBox();
            this.textPort = new System.Windows.Forms.TextBox();
            this.radioClient = new System.Windows.Forms.RadioButton();
            this.radioServer = new System.Windows.Forms.RadioButton();
            this.labelHost = new System.Windows.Forms.Label();
            this.labelPort = new System.Windows.Forms.Label();
            this.radioSingle = new System.Windows.Forms.RadioButton();
            this.radioDouble = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStart.BackColor = System.Drawing.Color.Transparent;
            this.buttonStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStart.FlatAppearance.BorderSize = 0;
            this.buttonStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStart.Font = new System.Drawing.Font("Buxton Sketch", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))));
            this.buttonStart.Location = new System.Drawing.Point(280, 209);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(119, 100);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Начать\r\nигру";
            this.buttonStart.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // textHost
            // 
            this.textHost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textHost.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textHost.Font = new System.Drawing.Font("Buxton Sketch", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textHost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))));
            this.textHost.Location = new System.Drawing.Point(278, 187);
            this.textHost.Name = "textHost";
            this.textHost.Size = new System.Drawing.Size(86, 20);
            this.textHost.TabIndex = 6;
            this.textHost.Text = "127.0.0.1";
            this.textHost.Visible = false;
            // 
            // textPort
            // 
            this.textPort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textPort.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textPort.Font = new System.Drawing.Font("Buxton Sketch", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textPort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))));
            this.textPort.Location = new System.Drawing.Point(279, 164);
            this.textPort.Name = "textPort";
            this.textPort.Size = new System.Drawing.Size(100, 20);
            this.textPort.TabIndex = 5;
            this.textPort.Text = "8000";
            this.textPort.Visible = false;
            // 
            // radioClient
            // 
            this.radioClient.AutoSize = true;
            this.radioClient.BackColor = System.Drawing.Color.Transparent;
            this.radioClient.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))));
            this.radioClient.FlatAppearance.BorderSize = 3;
            this.radioClient.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))));
            this.radioClient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))));
            this.radioClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioClient.Font = new System.Drawing.Font("Buxton Sketch", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioClient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))));
            this.radioClient.Location = new System.Drawing.Point(42, 188);
            this.radioClient.Name = "radioClient";
            this.radioClient.Size = new System.Drawing.Size(184, 24);
            this.radioClient.TabIndex = 4;
            this.radioClient.Text = "Игра по сети - Клиент";
            this.radioClient.UseVisualStyleBackColor = false;
            this.radioClient.CheckedChanged += new System.EventHandler(this.radioClient_CheckedChanged);
            // 
            // radioServer
            // 
            this.radioServer.AutoSize = true;
            this.radioServer.BackColor = System.Drawing.Color.Transparent;
            this.radioServer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))));
            this.radioServer.FlatAppearance.BorderSize = 3;
            this.radioServer.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))));
            this.radioServer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))));
            this.radioServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioServer.Font = new System.Drawing.Font("Buxton Sketch", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioServer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))));
            this.radioServer.Location = new System.Drawing.Point(42, 163);
            this.radioServer.Name = "radioServer";
            this.radioServer.Size = new System.Drawing.Size(178, 24);
            this.radioServer.TabIndex = 3;
            this.radioServer.Text = "Игра по сети - Сервер";
            this.radioServer.UseVisualStyleBackColor = false;
            this.radioServer.CheckedChanged += new System.EventHandler(this.radioServer_CheckedChanged);
            // 
            // labelHost
            // 
            this.labelHost.AutoSize = true;
            this.labelHost.BackColor = System.Drawing.Color.Transparent;
            this.labelHost.Font = new System.Drawing.Font("Buxton Sketch", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))));
            this.labelHost.Location = new System.Drawing.Point(228, 187);
            this.labelHost.Name = "labelHost";
            this.labelHost.Size = new System.Drawing.Size(48, 20);
            this.labelHost.TabIndex = 7;
            this.labelHost.Text = "Хост:";
            this.labelHost.Visible = false;
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.BackColor = System.Drawing.Color.Transparent;
            this.labelPort.Font = new System.Drawing.Font("Buxton Sketch", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))));
            this.labelPort.Location = new System.Drawing.Point(226, 165);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(50, 20);
            this.labelPort.TabIndex = 8;
            this.labelPort.Text = "Порт:";
            this.labelPort.Visible = false;
            // 
            // radioSingle
            // 
            this.radioSingle.AutoSize = true;
            this.radioSingle.BackColor = System.Drawing.Color.Transparent;
            this.radioSingle.Checked = true;
            this.radioSingle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))));
            this.radioSingle.FlatAppearance.BorderSize = 3;
            this.radioSingle.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))));
            this.radioSingle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))));
            this.radioSingle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioSingle.Font = new System.Drawing.Font("Buxton Sketch", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioSingle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))));
            this.radioSingle.Location = new System.Drawing.Point(42, 224);
            this.radioSingle.Name = "radioSingle";
            this.radioSingle.Size = new System.Drawing.Size(130, 24);
            this.radioSingle.TabIndex = 1;
            this.radioSingle.Text = "Играть одному";
            this.radioSingle.UseVisualStyleBackColor = false;
            this.radioSingle.CheckedChanged += new System.EventHandler(this.radioSingle_CheckedChanged);
            // 
            // radioDouble
            // 
            this.radioDouble.AutoSize = true;
            this.radioDouble.BackColor = System.Drawing.Color.Transparent;
            this.radioDouble.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))));
            this.radioDouble.FlatAppearance.BorderSize = 3;
            this.radioDouble.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))));
            this.radioDouble.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))));
            this.radioDouble.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioDouble.Font = new System.Drawing.Font("Buxton Sketch", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioDouble.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))));
            this.radioDouble.Location = new System.Drawing.Point(42, 247);
            this.radioDouble.Name = "radioDouble";
            this.radioDouble.Size = new System.Drawing.Size(129, 24);
            this.radioDouble.TabIndex = 2;
            this.radioDouble.Text = "Играть вдвоем";
            this.radioDouble.UseVisualStyleBackColor = false;
            // 
            // WelcomSokoban
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 43F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.BackgroundImage = global::SokobanGame.Properties.Resources.WelcomSocoban;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(624, 347);
            this.Controls.Add(this.radioDouble);
            this.Controls.Add(this.radioSingle);
            this.Controls.Add(this.labelPort);
            this.Controls.Add(this.labelHost);
            this.Controls.Add(this.radioServer);
            this.Controls.Add(this.radioClient);
            this.Controls.Add(this.textPort);
            this.Controls.Add(this.textHost);
            this.Controls.Add(this.buttonStart);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Palatino Linotype", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(10);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WelcomSokoban";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Интеллектуальная игра \"СОКОБАН\"";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.TextBox textHost;
        private System.Windows.Forms.TextBox textPort;
        private System.Windows.Forms.RadioButton radioClient;
        private System.Windows.Forms.RadioButton radioServer;
        private System.Windows.Forms.Label labelHost;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.RadioButton radioSingle;
        private System.Windows.Forms.RadioButton radioDouble;
    }
}

