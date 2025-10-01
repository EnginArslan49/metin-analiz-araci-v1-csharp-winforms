namespace karakterSayar
{
    // Author: Engin ARSLAN ~ Arslan Yazılım (arslanengin.com.tr)
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblReferansMetin = new Label();
            txtReferansMetin = new TextBox();
            txtGirilenMetninUzunlugu = new TextBox();
            lblGirilenMetninUzunlugu = new Label();
            btnKarakterSay = new Button();
            btnTemizle = new Button();
            btnYeniIcerikSay = new Button();
            Menuler = new ContextMenuStrip(components);
            menuYeniIcerikSay = new ToolStripMenuItem();
            txtEnKisaKelime = new TextBox();
            lblEnKisaKelime = new Label();
            txtEnUzunKelime = new TextBox();
            lblEnUzunKelime = new Label();
            pictureBox1 = new PictureBox();
            lblBilgilendirme = new Label();
            txtGirilenMetninCumleUzunlugu = new TextBox();
            lblGirilenMetninCumleUzunlugu = new Label();
            Menuler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblReferansMetin
            // 
            lblReferansMetin.AutoSize = true;
            lblReferansMetin.BackColor = Color.Transparent;
            lblReferansMetin.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblReferansMetin.Location = new Point(432, 13);
            lblReferansMetin.Name = "lblReferansMetin";
            lblReferansMetin.Size = new Size(163, 19);
            lblReferansMetin.TabIndex = 0;
            lblReferansMetin.Text = "REFERANS METİN:";
            // 
            // txtReferansMetin
            // 
            txtReferansMetin.Location = new Point(432, 35);
            txtReferansMetin.Multiline = true;
            txtReferansMetin.Name = "txtReferansMetin";
            txtReferansMetin.Size = new Size(390, 150);
            txtReferansMetin.TabIndex = 1;
            txtReferansMetin.TextChanged += txtReferansMetin_TextChanged;
            // 
            // txtGirilenMetninUzunlugu
            // 
            txtGirilenMetninUzunlugu.Location = new Point(432, 307);
            txtGirilenMetninUzunlugu.Multiline = true;
            txtGirilenMetninUzunlugu.Name = "txtGirilenMetninUzunlugu";
            txtGirilenMetninUzunlugu.ReadOnly = true;
            txtGirilenMetninUzunlugu.Size = new Size(200, 40);
            txtGirilenMetninUzunlugu.TabIndex = 3;
            txtGirilenMetninUzunlugu.TextAlign = HorizontalAlignment.Center;
            // 
            // lblGirilenMetninUzunlugu
            // 
            lblGirilenMetninUzunlugu.AutoSize = true;
            lblGirilenMetninUzunlugu.BackColor = Color.Transparent;
            lblGirilenMetninUzunlugu.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblGirilenMetninUzunlugu.Location = new Point(432, 283);
            lblGirilenMetninUzunlugu.Name = "lblGirilenMetninUzunlugu";
            lblGirilenMetninUzunlugu.Size = new Size(130, 19);
            lblGirilenMetninUzunlugu.TabIndex = 2;
            lblGirilenMetninUzunlugu.Text = "Karakter Sayısı:";
            // 
            // btnKarakterSay
            // 
            btnKarakterSay.BackColor = Color.CornflowerBlue;
            btnKarakterSay.Cursor = Cursors.Hand;
            btnKarakterSay.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnKarakterSay.ForeColor = Color.White;
            btnKarakterSay.Location = new Point(432, 191);
            btnKarakterSay.Name = "btnKarakterSay";
            btnKarakterSay.Size = new Size(130, 45);
            btnKarakterSay.TabIndex = 4;
            btnKarakterSay.Text = "Analiz ET";
            btnKarakterSay.UseVisualStyleBackColor = false;
            btnKarakterSay.Click += btnKarakterSay_Click;
            // 
            // btnTemizle
            // 
            btnTemizle.BackColor = Color.CornflowerBlue;
            btnTemizle.Cursor = Cursors.Hand;
            btnTemizle.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            btnTemizle.ForeColor = Color.White;
            btnTemizle.Location = new Point(562, 191);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(130, 45);
            btnTemizle.TabIndex = 5;
            btnTemizle.Text = "Temizle";
            btnTemizle.UseVisualStyleBackColor = false;
            btnTemizle.Click += btnTemizle_Click;
            // 
            // btnYeniIcerikSay
            // 
            btnYeniIcerikSay.BackColor = Color.CornflowerBlue;
            btnYeniIcerikSay.Cursor = Cursors.Hand;
            btnYeniIcerikSay.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            btnYeniIcerikSay.ForeColor = Color.White;
            btnYeniIcerikSay.Location = new Point(692, 191);
            btnYeniIcerikSay.Name = "btnYeniIcerikSay";
            btnYeniIcerikSay.Size = new Size(130, 45);
            btnYeniIcerikSay.TabIndex = 6;
            btnYeniIcerikSay.Text = "Yeni İçerik";
            btnYeniIcerikSay.UseVisualStyleBackColor = false;
            btnYeniIcerikSay.Click += btnYeniIcerikSay_Click;
            // 
            // Menuler
            // 
            Menuler.ImageScalingSize = new Size(20, 20);
            Menuler.Items.AddRange(new ToolStripItem[] { menuYeniIcerikSay });
            Menuler.Name = "Menuler";
            Menuler.Size = new Size(172, 28);
            // 
            // menuYeniIcerikSay
            // 
            menuYeniIcerikSay.Name = "menuYeniIcerikSay";
            menuYeniIcerikSay.Size = new Size(171, 24);
            menuYeniIcerikSay.Text = "Yeni İçerik Say";
            menuYeniIcerikSay.Click += menuYeniIcerikSay_Click;
            // 
            // txtEnKisaKelime
            // 
            txtEnKisaKelime.Location = new Point(670, 404);
            txtEnKisaKelime.Multiline = true;
            txtEnKisaKelime.Name = "txtEnKisaKelime";
            txtEnKisaKelime.ReadOnly = true;
            txtEnKisaKelime.Size = new Size(200, 40);
            txtEnKisaKelime.TabIndex = 8;
            txtEnKisaKelime.TextAlign = HorizontalAlignment.Center;
            // 
            // lblEnKisaKelime
            // 
            lblEnKisaKelime.AutoSize = true;
            lblEnKisaKelime.BackColor = Color.Transparent;
            lblEnKisaKelime.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblEnKisaKelime.Location = new Point(670, 380);
            lblEnKisaKelime.Name = "lblEnKisaKelime";
            lblEnKisaKelime.Size = new Size(130, 19);
            lblEnKisaKelime.TabIndex = 7;
            lblEnKisaKelime.Text = "En Kısa Kelime:";
            // 
            // txtEnUzunKelime
            // 
            txtEnUzunKelime.Location = new Point(432, 404);
            txtEnUzunKelime.Multiline = true;
            txtEnUzunKelime.Name = "txtEnUzunKelime";
            txtEnUzunKelime.ReadOnly = true;
            txtEnUzunKelime.Size = new Size(200, 40);
            txtEnUzunKelime.TabIndex = 10;
            txtEnUzunKelime.TextAlign = HorizontalAlignment.Center;
            // 
            // lblEnUzunKelime
            // 
            lblEnUzunKelime.AutoSize = true;
            lblEnUzunKelime.BackColor = Color.Transparent;
            lblEnUzunKelime.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblEnUzunKelime.Location = new Point(432, 375);
            lblEnUzunKelime.Name = "lblEnUzunKelime";
            lblEnUzunKelime.Size = new Size(133, 19);
            lblEnUzunKelime.TabIndex = 9;
            lblEnUzunKelime.Text = "En Uzun Kelime:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(43, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(348, 420);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // lblBilgilendirme
            // 
            lblBilgilendirme.AutoSize = true;
            lblBilgilendirme.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblBilgilendirme.ForeColor = Color.Red;
            lblBilgilendirme.Location = new Point(432, 261);
            lblBilgilendirme.Name = "lblBilgilendirme";
            lblBilgilendirme.Size = new Size(0, 17);
            lblBilgilendirme.TabIndex = 12;
            // 
            // txtGirilenMetninCumleUzunlugu
            // 
            txtGirilenMetninCumleUzunlugu.Location = new Point(670, 307);
            txtGirilenMetninCumleUzunlugu.Multiline = true;
            txtGirilenMetninCumleUzunlugu.Name = "txtGirilenMetninCumleUzunlugu";
            txtGirilenMetninCumleUzunlugu.ReadOnly = true;
            txtGirilenMetninCumleUzunlugu.Size = new Size(200, 40);
            txtGirilenMetninCumleUzunlugu.TabIndex = 14;
            txtGirilenMetninCumleUzunlugu.TextAlign = HorizontalAlignment.Center;
            // 
            // lblGirilenMetninCumleUzunlugu
            // 
            lblGirilenMetninCumleUzunlugu.AutoSize = true;
            lblGirilenMetninCumleUzunlugu.BackColor = Color.Transparent;
            lblGirilenMetninCumleUzunlugu.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblGirilenMetninCumleUzunlugu.Location = new Point(670, 283);
            lblGirilenMetninCumleUzunlugu.Name = "lblGirilenMetninCumleUzunlugu";
            lblGirilenMetninCumleUzunlugu.Size = new Size(112, 19);
            lblGirilenMetninCumleUzunlugu.TabIndex = 13;
            lblGirilenMetninCumleUzunlugu.Text = "Cümle Sayısı:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(882, 483);
            ContextMenuStrip = Menuler;
            Controls.Add(txtGirilenMetninCumleUzunlugu);
            Controls.Add(lblGirilenMetninCumleUzunlugu);
            Controls.Add(lblBilgilendirme);
            Controls.Add(pictureBox1);
            Controls.Add(txtEnUzunKelime);
            Controls.Add(lblEnUzunKelime);
            Controls.Add(txtEnKisaKelime);
            Controls.Add(lblEnKisaKelime);
            Controls.Add(btnYeniIcerikSay);
            Controls.Add(btnTemizle);
            Controls.Add(btnKarakterSay);
            Controls.Add(txtGirilenMetninUzunlugu);
            Controls.Add(lblGirilenMetninUzunlugu);
            Controls.Add(txtReferansMetin);
            Controls.Add(lblReferansMetin);
            DoubleBuffered = true;
            Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Metin Analiz Aracı v1";
            Menuler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblReferansMetin;
        private TextBox txtReferansMetin;
        private TextBox txtGirilenMetninUzunlugu;
        private Label lblGirilenMetninUzunlugu;
        private Button btnKarakterSay;
        private Button btnTemizle;
        private Button btnYeniIcerikSay;
        private ContextMenuStrip Menuler;
        private ToolStripMenuItem menuYeniIcerikSay;
        private TextBox txtEnKisaKelime;
        private Label lblEnKisaKelime;
        private TextBox txtEnUzunKelime;
        private Label lblEnUzunKelime;
        private PictureBox pictureBox1;
        private Label lblBilgilendirme;
        private TextBox txtGirilenMetninCumleUzunlugu;
        private Label lblGirilenMetninCumleUzunlugu;
    }
}
