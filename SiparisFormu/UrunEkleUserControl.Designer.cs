namespace SiparisFormu
{
    partial class UrunEkleUserControl
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UrunEkleUserControl));
            this.label1 = new System.Windows.Forms.Label();
            this.UrunBilgileri = new System.Windows.Forms.GroupBox();
            this.maskedStokCode = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbBirim = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMarBarkod = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKDV = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIskonto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBirimFiyat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtStokMiktar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxbirim = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.birimsil = new System.Windows.Forms.Button();
            this.cmbBirimSil = new System.Windows.Forms.ComboBox();
            this.textBoxBirim = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.UrunBilgileri.SuspendLayout();
            this.groupBoxbirim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(7, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "*Stok Kodu:";
            // 
            // UrunBilgileri
            // 
            this.UrunBilgileri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.UrunBilgileri.Controls.Add(this.maskedStokCode);
            this.UrunBilgileri.Controls.Add(this.button1);
            this.UrunBilgileri.Controls.Add(this.cmbBirim);
            this.UrunBilgileri.Controls.Add(this.label4);
            this.UrunBilgileri.Controls.Add(this.txtMarBarkod);
            this.UrunBilgileri.Controls.Add(this.label3);
            this.UrunBilgileri.Controls.Add(this.txtKDV);
            this.UrunBilgileri.Controls.Add(this.label8);
            this.UrunBilgileri.Controls.Add(this.txtIskonto);
            this.UrunBilgileri.Controls.Add(this.label7);
            this.UrunBilgileri.Controls.Add(this.txtBirimFiyat);
            this.UrunBilgileri.Controls.Add(this.label6);
            this.UrunBilgileri.Controls.Add(this.txtStokMiktar);
            this.UrunBilgileri.Controls.Add(this.label5);
            this.UrunBilgileri.Controls.Add(this.txtMarka);
            this.UrunBilgileri.Controls.Add(this.label9);
            this.UrunBilgileri.Controls.Add(this.txtUrunAdi);
            this.UrunBilgileri.Controls.Add(this.label2);
            this.UrunBilgileri.Controls.Add(this.label1);
            this.UrunBilgileri.Dock = System.Windows.Forms.DockStyle.Left;
            this.UrunBilgileri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UrunBilgileri.Location = new System.Drawing.Point(0, 0);
            this.UrunBilgileri.Name = "UrunBilgileri";
            this.UrunBilgileri.Size = new System.Drawing.Size(326, 570);
            this.UrunBilgileri.TabIndex = 2;
            this.UrunBilgileri.TabStop = false;
            this.UrunBilgileri.Text = "Ürün Bilgileri";
            // 
            // maskedStokCode
            // 
            this.maskedStokCode.Enabled = false;
            this.maskedStokCode.Location = new System.Drawing.Point(122, 51);
            this.maskedStokCode.Mask = "TR-000-000-000-000";
            this.maskedStokCode.Name = "maskedStokCode";
            this.maskedStokCode.Size = new System.Drawing.Size(135, 21);
            this.maskedStokCode.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SkyBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(196, 502);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 30);
            this.button1.TabIndex = 6;
            this.button1.Text = "Ürünü Kaydet";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // cmbBirim
            // 
            this.cmbBirim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBirim.FormattingEnabled = true;
            this.cmbBirim.Location = new System.Drawing.Point(122, 262);
            this.cmbBirim.Name = "cmbBirim";
            this.cmbBirim.Size = new System.Drawing.Size(135, 23);
            this.cmbBirim.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(7, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "*Birim:";
            // 
            // txtMarBarkod
            // 
            this.txtMarBarkod.Enabled = false;
            this.txtMarBarkod.Location = new System.Drawing.Point(122, 207);
            this.txtMarBarkod.Mask = "0000-0000-0000-0000";
            this.txtMarBarkod.Name = "txtMarBarkod";
            this.txtMarBarkod.Size = new System.Drawing.Size(135, 21);
            this.txtMarBarkod.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(6, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "*Barkod No:";
            // 
            // txtKDV
            // 
            this.txtKDV.Location = new System.Drawing.Point(122, 457);
            this.txtKDV.Name = "txtKDV";
            this.txtKDV.Size = new System.Drawing.Size(135, 21);
            this.txtKDV.TabIndex = 5;
            this.txtKDV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtKDV_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(7, 458);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 18);
            this.label8.TabIndex = 0;
            this.label8.Text = "*KDV Oranı:";
            // 
            // txtIskonto
            // 
            this.txtIskonto.Location = new System.Drawing.Point(122, 404);
            this.txtIskonto.Name = "txtIskonto";
            this.txtIskonto.Size = new System.Drawing.Size(135, 21);
            this.txtIskonto.TabIndex = 4;
            this.txtIskonto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtKDV_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(7, 405);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "İskonto Oranı:";
            // 
            // txtBirimFiyat
            // 
            this.txtBirimFiyat.Location = new System.Drawing.Point(122, 358);
            this.txtBirimFiyat.Name = "txtBirimFiyat";
            this.txtBirimFiyat.Size = new System.Drawing.Size(135, 21);
            this.txtBirimFiyat.TabIndex = 3;
            this.txtBirimFiyat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtKDV_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(7, 358);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "*Birim Fiyatı:";
            // 
            // txtStokMiktar
            // 
            this.txtStokMiktar.Location = new System.Drawing.Point(122, 311);
            this.txtStokMiktar.Name = "txtStokMiktar";
            this.txtStokMiktar.Size = new System.Drawing.Size(135, 21);
            this.txtStokMiktar.TabIndex = 2;
            this.txtStokMiktar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtKDV_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(7, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "*Stok Miktarı:";
            // 
            // txtMarka
            // 
            this.txtMarka.Location = new System.Drawing.Point(122, 106);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(135, 21);
            this.txtMarka.TabIndex = 0;
            this.txtMarka.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtUrunAdi_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(7, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 18);
            this.label9.TabIndex = 0;
            this.label9.Text = "*Marka:";
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(122, 161);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(135, 21);
            this.txtUrunAdi.TabIndex = 1;
            this.txtUrunAdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtUrunAdi_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(7, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "*Ürün Adı:";
            // 
            // groupBoxbirim
            // 
            this.groupBoxbirim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.groupBoxbirim.Controls.Add(this.button3);
            this.groupBoxbirim.Controls.Add(this.birimsil);
            this.groupBoxbirim.Controls.Add(this.cmbBirimSil);
            this.groupBoxbirim.Controls.Add(this.textBoxBirim);
            this.groupBoxbirim.Controls.Add(this.label11);
            this.groupBoxbirim.Controls.Add(this.label10);
            this.groupBoxbirim.Controls.Add(this.button2);
            this.groupBoxbirim.Location = new System.Drawing.Point(323, 0);
            this.groupBoxbirim.Name = "groupBoxbirim";
            this.groupBoxbirim.Size = new System.Drawing.Size(285, 567);
            this.groupBoxbirim.TabIndex = 9;
            this.groupBoxbirim.TabStop = false;
            this.groupBoxbirim.Text = "Birim Ekle";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.SkyBlue;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(170, 504);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 26);
            this.button3.TabIndex = 11;
            this.button3.Text = "Slaytı Durdur";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // birimsil
            // 
            this.birimsil.BackColor = System.Drawing.Color.SkyBlue;
            this.birimsil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.birimsil.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.birimsil.Location = new System.Drawing.Point(92, 222);
            this.birimsil.Name = "birimsil";
            this.birimsil.Size = new System.Drawing.Size(91, 26);
            this.birimsil.TabIndex = 10;
            this.birimsil.Text = "Birim Sil";
            this.birimsil.UseVisualStyleBackColor = false;
            this.birimsil.Click += new System.EventHandler(this.Birimsil_Click);
            // 
            // cmbBirimSil
            // 
            this.cmbBirimSil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBirimSil.FormattingEnabled = true;
            this.cmbBirimSil.ItemHeight = 13;
            this.cmbBirimSil.Location = new System.Drawing.Point(146, 108);
            this.cmbBirimSil.Name = "cmbBirimSil";
            this.cmbBirimSil.Size = new System.Drawing.Size(121, 21);
            this.cmbBirimSil.TabIndex = 8;
            // 
            // textBoxBirim
            // 
            this.textBoxBirim.Location = new System.Drawing.Point(146, 44);
            this.textBoxBirim.Name = "textBoxBirim";
            this.textBoxBirim.Size = new System.Drawing.Size(121, 20);
            this.textBoxBirim.TabIndex = 7;
            this.textBoxBirim.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxBirim_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(9, 111);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(120, 18);
            this.label11.TabIndex = 2;
            this.label11.Text = "Silinecek Birim:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(9, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(131, 18);
            this.label10.TabIndex = 2;
            this.label10.Text = "Eklenecek Birim:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SkyBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(189, 222);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 26);
            this.button2.TabIndex = 9;
            this.button2.Text = "Birim Ekle";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "1.jpg");
            this.ımageList1.Images.SetKeyName(1, "2.jpg");
            this.ımageList1.Images.SetKeyName(2, "3.jpg");
            this.ımageList1.Images.SetKeyName(3, "4.jpg");
            this.ımageList1.Images.SetKeyName(4, "6.jpg");
            this.ımageList1.Images.SetKeyName(5, "7.jpg");
            this.ımageList1.Images.SetKeyName(6, "8.jpeg");
            this.ımageList1.Images.SetKeyName(7, "9.jpg");
            this.ımageList1.Images.SetKeyName(8, "10.jpg");
            this.ımageList1.Images.SetKeyName(9, "11.jpg");
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(607, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(598, 570);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // UrunEkleUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBoxbirim);
            this.Controls.Add(this.UrunBilgileri);
            this.Name = "UrunEkleUserControl";
            this.Size = new System.Drawing.Size(1205, 570);
            this.Load += new System.EventHandler(this.UrunEkleUserControl_Load);
            this.UrunBilgileri.ResumeLayout(false);
            this.UrunBilgileri.PerformLayout();
            this.groupBoxbirim.ResumeLayout(false);
            this.groupBoxbirim.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox UrunBilgileri;
        private System.Windows.Forms.TextBox txtKDV;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtIskonto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBirimFiyat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtStokMiktar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtMarBarkod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbBirim;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox maskedStokCode;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBoxbirim;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBoxBirim;
        private System.Windows.Forms.ComboBox cmbBirimSil;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button birimsil;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button3;
    }
}
