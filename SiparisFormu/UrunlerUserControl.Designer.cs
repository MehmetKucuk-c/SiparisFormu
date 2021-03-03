namespace SiparisFormu
{
    partial class UrunlerUserControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StokKodu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cinsi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BarkodNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StokMiktar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirimFiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IskontoOrani = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KDVOrani = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUrunAd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.VerileriGetir = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStokMiktar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBirimFiyat = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIskonto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtKDV = new System.Windows.Forms.TextBox();
            this.Sil = new System.Windows.Forms.Button();
            this.btnArma = new System.Windows.Forms.Button();
            this.Bilgiler = new System.Windows.Forms.GroupBox();
            this.AranacakUrun = new System.Windows.Forms.TextBox();
            this.maskedStokCode = new System.Windows.Forms.MaskedTextBox();
            this.cmbBirim = new System.Windows.Forms.ComboBox();
            this.txtMarBarkod = new System.Windows.Forms.MaskedTextBox();
            this.Txtmarka = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Bilgiler.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.StokKodu,
            this.Marka,
            this.Cinsi,
            this.BarkodNo,
            this.Birim,
            this.StokMiktar,
            this.BirimFiyat,
            this.IskontoOrani,
            this.KDVOrani});
            this.dataGridView1.Location = new System.Drawing.Point(0, 131);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Size = new System.Drawing.Size(1205, 439);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "idTut";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // StokKodu
            // 
            this.StokKodu.DataPropertyName = "StokKodu";
            this.StokKodu.HeaderText = "Stok Kodu";
            this.StokKodu.Name = "StokKodu";
            this.StokKodu.Width = 150;
            // 
            // Marka
            // 
            this.Marka.DataPropertyName = "Marka";
            this.Marka.HeaderText = "Marka";
            this.Marka.Name = "Marka";
            this.Marka.Width = 130;
            // 
            // Cinsi
            // 
            this.Cinsi.DataPropertyName = "Cinsi";
            this.Cinsi.HeaderText = "Ürün Adı";
            this.Cinsi.Name = "Cinsi";
            this.Cinsi.Width = 150;
            // 
            // BarkodNo
            // 
            this.BarkodNo.DataPropertyName = "BarkodNo";
            this.BarkodNo.HeaderText = "Barkod Numarası";
            this.BarkodNo.Name = "BarkodNo";
            this.BarkodNo.Width = 150;
            // 
            // Birim
            // 
            this.Birim.DataPropertyName = "Birim";
            this.Birim.HeaderText = "Birim";
            this.Birim.Name = "Birim";
            // 
            // StokMiktar
            // 
            this.StokMiktar.DataPropertyName = "StokMiktar";
            this.StokMiktar.HeaderText = "Stok Miktarı";
            this.StokMiktar.Name = "StokMiktar";
            this.StokMiktar.Width = 130;
            // 
            // BirimFiyat
            // 
            this.BirimFiyat.DataPropertyName = "BirimFiyat";
            this.BirimFiyat.HeaderText = "Birim Fiyat  \"TL\"";
            this.BirimFiyat.Name = "BirimFiyat";
            this.BirimFiyat.Width = 150;
            // 
            // IskontoOrani
            // 
            this.IskontoOrani.DataPropertyName = "IskontoOrani";
            this.IskontoOrani.HeaderText = "İskonto Oranı  \"%\"";
            this.IskontoOrani.Name = "IskontoOrani";
            this.IskontoOrani.Width = 130;
            // 
            // KDVOrani
            // 
            this.KDVOrani.DataPropertyName = "KDVOrani";
            this.KDVOrani.HeaderText = "KDV Oranı  \"%\"";
            this.KDVOrani.Name = "KDVOrani";
            this.KDVOrani.Width = 113;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SkyBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(719, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 26);
            this.button1.TabIndex = 1;
            this.button1.Text = "Güncelle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(1, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Stok Kodu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(1, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ürünün Adı:";
            // 
            // txtUrunAd
            // 
            this.txtUrunAd.Location = new System.Drawing.Point(101, 45);
            this.txtUrunAd.Name = "txtUrunAd";
            this.txtUrunAd.Size = new System.Drawing.Size(120, 20);
            this.txtUrunAd.TabIndex = 5;
            this.txtUrunAd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Aranacak_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(1, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Barkod No:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(1, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Birim:";
            // 
            // VerileriGetir
            // 
            this.VerileriGetir.BackColor = System.Drawing.Color.SkyBlue;
            this.VerileriGetir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VerileriGetir.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.VerileriGetir.Location = new System.Drawing.Point(719, 93);
            this.VerileriGetir.Name = "VerileriGetir";
            this.VerileriGetir.Size = new System.Drawing.Size(114, 26);
            this.VerileriGetir.TabIndex = 1;
            this.VerileriGetir.Text = "Verileri Getir";
            this.VerileriGetir.UseVisualStyleBackColor = false;
            this.VerileriGetir.Click += new System.EventHandler(this.VerileriGetir_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(245, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "Stok Miktarı:";
            // 
            // txtStokMiktar
            // 
            this.txtStokMiktar.Location = new System.Drawing.Point(360, 24);
            this.txtStokMiktar.Name = "txtStokMiktar";
            this.txtStokMiktar.Size = new System.Drawing.Size(120, 20);
            this.txtStokMiktar.TabIndex = 4;
            this.txtStokMiktar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtStokMiktar_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(245, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 18);
            this.label6.TabIndex = 2;
            this.label6.Text = "Birim Fiyatı:";
            // 
            // txtBirimFiyat
            // 
            this.txtBirimFiyat.Location = new System.Drawing.Point(360, 50);
            this.txtBirimFiyat.Name = "txtBirimFiyat";
            this.txtBirimFiyat.Size = new System.Drawing.Size(120, 20);
            this.txtBirimFiyat.TabIndex = 4;
            this.txtBirimFiyat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtStokMiktar_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(245, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 18);
            this.label7.TabIndex = 2;
            this.label7.Text = "İskonto Oranı:";
            // 
            // txtIskonto
            // 
            this.txtIskonto.Location = new System.Drawing.Point(360, 76);
            this.txtIskonto.Name = "txtIskonto";
            this.txtIskonto.Size = new System.Drawing.Size(120, 20);
            this.txtIskonto.TabIndex = 4;
            this.txtIskonto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtStokMiktar_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(245, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 18);
            this.label8.TabIndex = 2;
            this.label8.Text = "KDV Oranı:";
            // 
            // txtKDV
            // 
            this.txtKDV.Location = new System.Drawing.Point(360, 105);
            this.txtKDV.Name = "txtKDV";
            this.txtKDV.Size = new System.Drawing.Size(120, 20);
            this.txtKDV.TabIndex = 4;
            this.txtKDV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtStokMiktar_KeyPress);
            // 
            // Sil
            // 
            this.Sil.BackColor = System.Drawing.Color.SkyBlue;
            this.Sil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sil.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.Sil.Location = new System.Drawing.Point(719, 56);
            this.Sil.Name = "Sil";
            this.Sil.Size = new System.Drawing.Size(114, 26);
            this.Sil.TabIndex = 1;
            this.Sil.Text = "Sil";
            this.Sil.UseVisualStyleBackColor = false;
            this.Sil.Click += new System.EventHandler(this.Sil_Click);
            // 
            // btnArma
            // 
            this.btnArma.BackColor = System.Drawing.Color.SkyBlue;
            this.btnArma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArma.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnArma.Location = new System.Drawing.Point(1124, 98);
            this.btnArma.Name = "btnArma";
            this.btnArma.Size = new System.Drawing.Size(78, 28);
            this.btnArma.TabIndex = 1;
            this.btnArma.Text = "Ara";
            this.btnArma.UseVisualStyleBackColor = false;
            this.btnArma.Click += new System.EventHandler(this.BtnArma_Click);
            // 
            // Bilgiler
            // 
            this.Bilgiler.Controls.Add(this.AranacakUrun);
            this.Bilgiler.Controls.Add(this.maskedStokCode);
            this.Bilgiler.Controls.Add(this.cmbBirim);
            this.Bilgiler.Controls.Add(this.txtMarBarkod);
            this.Bilgiler.Controls.Add(this.button1);
            this.Bilgiler.Controls.Add(this.VerileriGetir);
            this.Bilgiler.Controls.Add(this.Txtmarka);
            this.Bilgiler.Controls.Add(this.txtUrunAd);
            this.Bilgiler.Controls.Add(this.Sil);
            this.Bilgiler.Controls.Add(this.label4);
            this.Bilgiler.Controls.Add(this.btnArma);
            this.Bilgiler.Controls.Add(this.label1);
            this.Bilgiler.Controls.Add(this.txtKDV);
            this.Bilgiler.Controls.Add(this.label2);
            this.Bilgiler.Controls.Add(this.txtIskonto);
            this.Bilgiler.Controls.Add(this.label10);
            this.Bilgiler.Controls.Add(this.label5);
            this.Bilgiler.Controls.Add(this.txtBirimFiyat);
            this.Bilgiler.Controls.Add(this.label3);
            this.Bilgiler.Controls.Add(this.label6);
            this.Bilgiler.Controls.Add(this.label8);
            this.Bilgiler.Controls.Add(this.label7);
            this.Bilgiler.Controls.Add(this.txtStokMiktar);
            this.Bilgiler.Dock = System.Windows.Forms.DockStyle.Top;
            this.Bilgiler.Location = new System.Drawing.Point(0, 0);
            this.Bilgiler.Name = "Bilgiler";
            this.Bilgiler.Size = new System.Drawing.Size(1205, 132);
            this.Bilgiler.TabIndex = 6;
            this.Bilgiler.TabStop = false;
            this.Bilgiler.Text = "Bilgiler";
            // 
            // AranacakUrun
            // 
            this.AranacakUrun.Location = new System.Drawing.Point(998, 102);
            this.AranacakUrun.Name = "AranacakUrun";
            this.AranacakUrun.Size = new System.Drawing.Size(120, 20);
            this.AranacakUrun.TabIndex = 14;
            this.AranacakUrun.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AranacakUrun_KeyPress);
            // 
            // maskedStokCode
            // 
            this.maskedStokCode.Enabled = false;
            this.maskedStokCode.Location = new System.Drawing.Point(101, 16);
            this.maskedStokCode.Mask = "TR-000-000-000-000";
            this.maskedStokCode.Name = "maskedStokCode";
            this.maskedStokCode.Size = new System.Drawing.Size(120, 20);
            this.maskedStokCode.TabIndex = 13;
            // 
            // cmbBirim
            // 
            this.cmbBirim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBirim.FormattingEnabled = true;
            this.cmbBirim.Location = new System.Drawing.Point(100, 99);
            this.cmbBirim.Name = "cmbBirim";
            this.cmbBirim.Size = new System.Drawing.Size(121, 21);
            this.cmbBirim.TabIndex = 7;
            // 
            // txtMarBarkod
            // 
            this.txtMarBarkod.Enabled = false;
            this.txtMarBarkod.Location = new System.Drawing.Point(101, 72);
            this.txtMarBarkod.Mask = "0000-0000-0000-0000";
            this.txtMarBarkod.Name = "txtMarBarkod";
            this.txtMarBarkod.Size = new System.Drawing.Size(120, 20);
            this.txtMarBarkod.TabIndex = 6;
            // 
            // Txtmarka
            // 
            this.Txtmarka.Location = new System.Drawing.Point(562, 24);
            this.Txtmarka.Name = "Txtmarka";
            this.Txtmarka.Size = new System.Drawing.Size(120, 20);
            this.Txtmarka.TabIndex = 5;
            this.Txtmarka.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Aranacak_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(496, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 18);
            this.label10.TabIndex = 2;
            this.label10.Text = "Marka:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SkyBlue;
            this.panel2.Controls.Add(this.label26);
            this.panel2.Controls.Add(this.label27);
            this.panel2.Controls.Add(this.label28);
            this.panel2.Controls.Add(this.label34);
            this.panel2.Controls.Add(this.label29);
            this.panel2.Controls.Add(this.label30);
            this.panel2.Controls.Add(this.label31);
            this.panel2.Controls.Add(this.label32);
            this.panel2.Controls.Add(this.label33);
            this.panel2.Location = new System.Drawing.Point(0, 132);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1205, 22);
            this.panel2.TabIndex = 25;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.label26.Location = new System.Drawing.Point(429, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(99, 15);
            this.label26.TabIndex = 0;
            this.label26.Text = "Barkod Numarası";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.label27.Location = new System.Drawing.Point(811, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(85, 15);
            this.label27.TabIndex = 0;
            this.label27.Text = "Birim Fiyat  \"TL\"";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.label28.Location = new System.Drawing.Point(959, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(100, 15);
            this.label28.TabIndex = 0;
            this.label28.Text = "İskonto Oranı  \"%\"";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.label34.Location = new System.Drawing.Point(1088, 0);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(86, 15);
            this.label34.TabIndex = 0;
            this.label34.Text = "KDV Oranı  \"%\"";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.label29.Location = new System.Drawing.Point(577, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(33, 15);
            this.label29.TabIndex = 0;
            this.label29.Text = "Birim";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.label30.Location = new System.Drawing.Point(678, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(68, 15);
            this.label30.TabIndex = 0;
            this.label30.Text = "Stok Miktarı";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.label31.Location = new System.Drawing.Point(279, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(53, 15);
            this.label31.TabIndex = 0;
            this.label31.Text = "Ürün Adı";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.label32.Location = new System.Drawing.Point(150, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(41, 15);
            this.label32.TabIndex = 0;
            this.label32.Text = "Marka";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.label33.Location = new System.Drawing.Point(6, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(60, 15);
            this.label33.TabIndex = 0;
            this.label33.Text = "Stok Kodu";
            // 
            // UrunlerUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Bilgiler);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UrunlerUserControl";
            this.Size = new System.Drawing.Size(1205, 570);
            this.Load += new System.EventHandler(this.UrunlerUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Bilgiler.ResumeLayout(false);
            this.Bilgiler.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUrunAd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button VerileriGetir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtStokMiktar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBirimFiyat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIskonto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtKDV;
        private System.Windows.Forms.Button Sil;
        private System.Windows.Forms.Button btnArma;
        private System.Windows.Forms.GroupBox Bilgiler;
        private System.Windows.Forms.MaskedTextBox txtMarBarkod;
        private System.Windows.Forms.ComboBox cmbBirim;
        private System.Windows.Forms.MaskedTextBox maskedStokCode;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Txtmarka;
        private System.Windows.Forms.TextBox AranacakUrun;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn StokKodu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marka;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cinsi;
        private System.Windows.Forms.DataGridViewTextBoxColumn BarkodNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birim;
        private System.Windows.Forms.DataGridViewTextBoxColumn StokMiktar;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirimFiyat;
        private System.Windows.Forms.DataGridViewTextBoxColumn IskontoOrani;
        private System.Windows.Forms.DataGridViewTextBoxColumn KDVOrani;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
    }
}
