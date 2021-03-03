namespace SiparisFormu
{
    partial class MesajForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MesajForm));
            this.txtadet = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panelSiparisForm = new System.Windows.Forms.Panel();
            this.txtIndirim = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtToplam = new System.Windows.Forms.TextBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnYazdir = new System.Windows.Forms.Button();
            this.btnSayfaAyarlari = new System.Windows.Forms.Button();
            this.btnBaskiOnizleme = new System.Windows.Forms.Button();
            this.btnGizle = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.urunAd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.urunMarka = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stokNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.siparisBarkodNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SiparisFiyat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Miktar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SiparisIskonto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.KDV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panelSiparisForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtadet
            // 
            this.txtadet.Location = new System.Drawing.Point(301, 158);
            this.txtadet.Name = "txtadet";
            this.txtadet.Size = new System.Drawing.Size(113, 20);
            this.txtadet.TabIndex = 0;
            this.txtadet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtadet_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bildirim";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(437, 246);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "Onayla";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button2.Location = new System.Drawing.Point(134, 246);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 28);
            this.button2.TabIndex = 2;
            this.button2.Text = "İptal Et";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(244, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lütfen kaç adet istediğinizi yazınız";
            // 
            // panelSiparisForm
            // 
            this.panelSiparisForm.BackColor = System.Drawing.Color.White;
            this.panelSiparisForm.Controls.Add(this.txtIndirim);
            this.panelSiparisForm.Controls.Add(this.label4);
            this.panelSiparisForm.Controls.Add(this.label3);
            this.panelSiparisForm.Controls.Add(this.txtToplam);
            this.panelSiparisForm.Controls.Add(this.btnSil);
            this.panelSiparisForm.Controls.Add(this.btnYazdir);
            this.panelSiparisForm.Controls.Add(this.btnSayfaAyarlari);
            this.panelSiparisForm.Controls.Add(this.btnBaskiOnizleme);
            this.panelSiparisForm.Controls.Add(this.btnGizle);
            this.panelSiparisForm.Controls.Add(this.listView1);
            this.panelSiparisForm.Location = new System.Drawing.Point(0, 0);
            this.panelSiparisForm.Name = "panelSiparisForm";
            this.panelSiparisForm.Size = new System.Drawing.Size(755, 354);
            this.panelSiparisForm.TabIndex = 4;
            this.panelSiparisForm.Visible = false;
            // 
            // txtIndirim
            // 
            this.txtIndirim.Location = new System.Drawing.Point(97, 317);
            this.txtIndirim.Name = "txtIndirim";
            this.txtIndirim.Size = new System.Drawing.Size(100, 20);
            this.txtIndirim.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "İndirim Tutarı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(486, 324);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Toplam:";
            // 
            // txtToplam
            // 
            this.txtToplam.Location = new System.Drawing.Point(541, 321);
            this.txtToplam.Name = "txtToplam";
            this.txtToplam.Size = new System.Drawing.Size(100, 20);
            this.txtToplam.TabIndex = 39;
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Red;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnSil.Location = new System.Drawing.Point(648, 118);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(107, 31);
            this.btnSil.TabIndex = 38;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // btnYazdir
            // 
            this.btnYazdir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnYazdir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnYazdir.Location = new System.Drawing.Point(647, 80);
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.Size = new System.Drawing.Size(107, 31);
            this.btnYazdir.TabIndex = 37;
            this.btnYazdir.Text = "Yazdır";
            this.btnYazdir.UseVisualStyleBackColor = false;
            this.btnYazdir.Click += new System.EventHandler(this.BtnYazdir_Click);
            // 
            // btnSayfaAyarlari
            // 
            this.btnSayfaAyarlari.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSayfaAyarlari.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnSayfaAyarlari.Location = new System.Drawing.Point(648, 43);
            this.btnSayfaAyarlari.Name = "btnSayfaAyarlari";
            this.btnSayfaAyarlari.Size = new System.Drawing.Size(107, 31);
            this.btnSayfaAyarlari.TabIndex = 36;
            this.btnSayfaAyarlari.Text = "Sayfa Ayarları";
            this.btnSayfaAyarlari.UseVisualStyleBackColor = false;
            this.btnSayfaAyarlari.Click += new System.EventHandler(this.BtnSayfaAyarlari_Click);
            // 
            // btnBaskiOnizleme
            // 
            this.btnBaskiOnizleme.BackColor = System.Drawing.Color.SkyBlue;
            this.btnBaskiOnizleme.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnBaskiOnizleme.Location = new System.Drawing.Point(647, 5);
            this.btnBaskiOnizleme.Name = "btnBaskiOnizleme";
            this.btnBaskiOnizleme.Size = new System.Drawing.Size(107, 31);
            this.btnBaskiOnizleme.TabIndex = 35;
            this.btnBaskiOnizleme.Text = "Baskı Önizleme";
            this.btnBaskiOnizleme.UseVisualStyleBackColor = false;
            this.btnBaskiOnizleme.Click += new System.EventHandler(this.BtnBaskiOnizleme_Click);
            // 
            // btnGizle
            // 
            this.btnGizle.BackColor = System.Drawing.Color.SlateBlue;
            this.btnGizle.FlatAppearance.BorderSize = 0;
            this.btnGizle.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnGizle.Location = new System.Drawing.Point(648, 277);
            this.btnGizle.Name = "btnGizle";
            this.btnGizle.Size = new System.Drawing.Size(107, 31);
            this.btnGizle.TabIndex = 32;
            this.btnGizle.Text = "Geri Dön";
            this.btnGizle.UseVisualStyleBackColor = false;
            this.btnGizle.Click += new System.EventHandler(this.BtnGizle_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.urunAd,
            this.urunMarka,
            this.stokNo,
            this.siparisBarkodNo,
            this.SiparisFiyat,
            this.Miktar,
            this.SiparisIskonto,
            this.KDV});
            this.listView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(641, 308);
            this.listView1.TabIndex = 31;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListView1_MouseClick);
            // 
            // urunAd
            // 
            this.urunAd.Text = "Ürün adı";
            this.urunAd.Width = 70;
            // 
            // urunMarka
            // 
            this.urunMarka.Text = "Ürün Marka";
            this.urunMarka.Width = 70;
            // 
            // stokNo
            // 
            this.stokNo.Text = "Stok Kodu";
            this.stokNo.Width = 120;
            // 
            // siparisBarkodNo
            // 
            this.siparisBarkodNo.Text = "Barkod Numarası";
            this.siparisBarkodNo.Width = 120;
            // 
            // SiparisFiyat
            // 
            this.SiparisFiyat.Text = "Birim Fiyat";
            // 
            // Miktar
            // 
            this.Miktar.Text = "Miktar";
            // 
            // SiparisIskonto
            // 
            this.SiparisIskonto.Text = "İskonto Oranı";
            this.SiparisIskonto.Width = 75;
            // 
            // KDV
            // 
            this.KDV.Text = "KDV Oranı";
            this.KDV.Width = 62;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument1_PrintPage);
            // 
            // pageSetupDialog1
            // 
            this.pageSetupDialog1.Document = this.printDocument1;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Text = "Baskı önizleme";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.pictureBox1.Location = new System.Drawing.Point(650, 566);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Location = new System.Drawing.Point(986, 446);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(314, 196);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // MesajForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SiparisFormu.Properties.Resources.business_communication_computer_free_stock_photo_image_wallpaper;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(755, 353);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelSiparisForm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtadet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MesajForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MesajForm";
            this.Load += new System.EventHandler(this.MesajForm_Load);
            this.panelSiparisForm.ResumeLayout(false);
            this.panelSiparisForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtadet;
        private System.Windows.Forms.Button btnGizle;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader urunAd;
        private System.Windows.Forms.ColumnHeader urunMarka;
        private System.Windows.Forms.ColumnHeader stokNo;
        private System.Windows.Forms.ColumnHeader siparisBarkodNo;
        private System.Windows.Forms.ColumnHeader SiparisFiyat;
        private System.Windows.Forms.ColumnHeader Miktar;
        private System.Windows.Forms.ColumnHeader SiparisIskonto;
        private System.Windows.Forms.ColumnHeader KDV;
        public System.Windows.Forms.Panel panelSiparisForm;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Button btnBaskiOnizleme;
        private System.Windows.Forms.Button btnSayfaAyarlari;
        private System.Windows.Forms.Button btnYazdir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtToplam;
        private System.Windows.Forms.TextBox txtIndirim;
        private System.Windows.Forms.Label label4;
    }
}