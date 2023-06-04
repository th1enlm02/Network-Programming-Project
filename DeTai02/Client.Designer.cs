namespace DeTai02
{
    partial class Client
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Client));
            this.bunifuGradientPanel1 = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuPictureBox2 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.textBoxReceive = new System.Windows.Forms.TextBox();
            this.comboBox_To = new System.Windows.Forms.ComboBox();
            this.textBoxSend = new System.Windows.Forms.TextBox();
            this.comboBox_From = new System.Windows.Forms.ComboBox();
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.BorderRadius = 1;
            this.bunifuGradientPanel1.Controls.Add(this.label1);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuPictureBox2);
            this.bunifuGradientPanel1.Controls.Add(this.textBoxReceive);
            this.bunifuGradientPanel1.Controls.Add(this.comboBox_To);
            this.bunifuGradientPanel1.Controls.Add(this.textBoxSend);
            this.bunifuGradientPanel1.Controls.Add(this.comboBox_From);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuPictureBox1);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.Blue;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Blue;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(706, 455);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(302, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Translate to";
            // 
            // bunifuPictureBox2
            // 
            this.bunifuPictureBox2.AllowFocused = false;
            this.bunifuPictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox2.AutoSizeHeight = true;
            this.bunifuPictureBox2.BorderRadius = 0;
            this.bunifuPictureBox2.Image = global::DeTai02.Properties.Resources.arrow;
            this.bunifuPictureBox2.IsCircle = true;
            this.bunifuPictureBox2.Location = new System.Drawing.Point(315, 270);
            this.bunifuPictureBox2.Name = "bunifuPictureBox2";
            this.bunifuPictureBox2.Size = new System.Drawing.Size(78, 78);
            this.bunifuPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox2.TabIndex = 3;
            this.bunifuPictureBox2.TabStop = false;
            this.bunifuPictureBox2.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            // 
            // textBoxReceive
            // 
            this.textBoxReceive.BackColor = System.Drawing.Color.LightSkyBlue;
            this.textBoxReceive.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxReceive.Location = new System.Drawing.Point(408, 225);
            this.textBoxReceive.Multiline = true;
            this.textBoxReceive.Name = "textBoxReceive";
            this.textBoxReceive.ReadOnly = true;
            this.textBoxReceive.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxReceive.Size = new System.Drawing.Size(286, 218);
            this.textBoxReceive.TabIndex = 1;
            this.textBoxReceive.TabStop = false;
            this.textBoxReceive.Text = "Bản dịch";
            // 
            // comboBox_To
            // 
            this.comboBox_To.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.comboBox_To.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_To.FormattingEnabled = true;
            this.comboBox_To.Items.AddRange(new object[] {
            "Phát hiện ngôn ngữ:auto",
            "Tiếng Việt:vi",
            "Tiếng Anh:en",
            "Tiếng Tây Ban Nha:es",
            "Tiếng Pháp:fr",
            "Tiếng Đức:de",
            "Tiếng Ý:it",
            "Tiếng Nhật:ja",
            "Tiếng Trung (đơn giản):zh-CN",
            "Tiếng Trung (phồn thể):zh-TW",
            "Tiếng Hàn:ko",
            "Tiếng Nga:ru",
            "Tiếng Bồ Đào Nha:pt",
            "Tiếng Ả Rập:ar",
            "Tiếng Thụy Điển:sv",
            "Tiếng Hà Lan:nl",
            "Tiếng Ba Lan:pl",
            "Tiếng Đan Mạch:da",
            "Tiếng Hy Lạp:el",
            "Tiếng Thái:th",
            "Tiếng Hindi:hi",
            "Tiếng Indonesia:id"});
            this.comboBox_To.Location = new System.Drawing.Point(408, 192);
            this.comboBox_To.Name = "comboBox_To";
            this.comboBox_To.Size = new System.Drawing.Size(286, 27);
            this.comboBox_To.TabIndex = 1;
            this.comboBox_To.Text = "Tiếng Việt:vi";
            // 
            // textBoxSend
            // 
            this.textBoxSend.BackColor = System.Drawing.Color.LightSkyBlue;
            this.textBoxSend.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSend.Location = new System.Drawing.Point(10, 225);
            this.textBoxSend.Multiline = true;
            this.textBoxSend.Name = "textBoxSend";
            this.textBoxSend.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxSend.Size = new System.Drawing.Size(286, 218);
            this.textBoxSend.TabIndex = 2;
            this.textBoxSend.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSend_KeyDown);
            // 
            // comboBox_From
            // 
            this.comboBox_From.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.comboBox_From.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_From.FormattingEnabled = true;
            this.comboBox_From.Items.AddRange(new object[] {
            "Phát hiện ngôn ngữ:auto",
            "Tiếng Việt:vi",
            "Tiếng Anh:en",
            "Tiếng Tây Ban Nha:es",
            "Tiếng Pháp:fr",
            "Tiếng Đức:de",
            "Tiếng Ý:it",
            "Tiếng Nhật:ja",
            "Tiếng Trung (đơn giản):zh-CN",
            "Tiếng Trung (phồn thể):zh-TW",
            "Tiếng Hàn:ko",
            "Tiếng Nga:ru",
            "Tiếng Bồ Đào Nha:pt",
            "Tiếng Ả Rập:ar",
            "Tiếng Thụy Điển:sv",
            "Tiếng Hà Lan:nl",
            "Tiếng Ba Lan:pl",
            "Tiếng Đan Mạch:da",
            "Tiếng Hy Lạp:el",
            "Tiếng Thái:th",
            "Tiếng Hindi:hi",
            "Tiếng Indonesia:id"});
            this.comboBox_From.Location = new System.Drawing.Point(10, 192);
            this.comboBox_From.Name = "comboBox_From";
            this.comboBox_From.Size = new System.Drawing.Size(286, 27);
            this.comboBox_From.TabIndex = 0;
            this.comboBox_From.Text = "Phát hiện ngôn ngữ:auto";
            // 
            // bunifuPictureBox1
            // 
            this.bunifuPictureBox1.AllowFocused = false;
            this.bunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox1.AutoSizeHeight = false;
            this.bunifuPictureBox1.BorderRadius = 0;
            this.bunifuPictureBox1.Image = global::DeTai02.Properties.Resources.translator_icon;
            this.bunifuPictureBox1.IsCircle = true;
            this.bunifuPictureBox1.Location = new System.Drawing.Point(269, 12);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Size = new System.Drawing.Size(170, 170);
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox1.TabIndex = 2;
            this.bunifuPictureBox1.TabStop = false;
            this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 455);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Client";
            this.Text = "Client";
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
        private System.Windows.Forms.TextBox textBoxReceive;
        private System.Windows.Forms.ComboBox comboBox_To;
        private System.Windows.Forms.TextBox textBoxSend;
        private System.Windows.Forms.ComboBox comboBox_From;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox2;
        private System.Windows.Forms.Label label1;
    }
}