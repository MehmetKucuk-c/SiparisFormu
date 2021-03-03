namespace SiparisFormu
{
    partial class SirketleriDuzenleUserControl
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
            this.Bilgiler = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnArma = new System.Windows.Forms.Button();
            this.AranacakMusteri = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.MaskedTextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtMusteriSoyisim = new System.Windows.Forms.TextBox();
            this.txtSirketisim = new System.Windows.Forms.TextBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.VerileriGetir = new System.Windows.Forms.Button();
            this.txtMusteriisim = new System.Windows.Forms.TextBox();
            this.Sil = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEposta = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIlce = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIL = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SirketAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdSoyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soyisim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SehirIlce = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eposta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mAdres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.Bilgiler.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Bilgiler
            // 
            this.Bilgiler.Controls.Add(this.groupBox1);
            this.Bilgiler.Controls.Add(this.txtTel);
            this.Bilgiler.Controls.Add(this.txtAdres);
            this.Bilgiler.Controls.Add(this.txtMusteriSoyisim);
            this.Bilgiler.Controls.Add(this.txtSirketisim);
            this.Bilgiler.Controls.Add(this.btnGuncelle);
            this.Bilgiler.Controls.Add(this.VerileriGetir);
            this.Bilgiler.Controls.Add(this.txtMusteriisim);
            this.Bilgiler.Controls.Add(this.Sil);
            this.Bilgiler.Controls.Add(this.label4);
            this.Bilgiler.Controls.Add(this.label1);
            this.Bilgiler.Controls.Add(this.label2);
            this.Bilgiler.Controls.Add(this.txtEposta);
            this.Bilgiler.Controls.Add(this.label8);
            this.Bilgiler.Controls.Add(this.label5);
            this.Bilgiler.Controls.Add(this.txtIlce);
            this.Bilgiler.Controls.Add(this.label3);
            this.Bilgiler.Controls.Add(this.label6);
            this.Bilgiler.Controls.Add(this.label7);
            this.Bilgiler.Controls.Add(this.txtIL);
            this.Bilgiler.Dock = System.Windows.Forms.DockStyle.Top;
            this.Bilgiler.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.Bilgiler.Location = new System.Drawing.Point(0, 0);
            this.Bilgiler.Name = "Bilgiler";
            this.Bilgiler.Size = new System.Drawing.Size(1205, 132);
            this.Bilgiler.TabIndex = 7;
            this.Bilgiler.TabStop = false;
            this.Bilgiler.Text = "Bilgiler";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnArma);
            this.groupBox1.Controls.Add(this.AranacakMusteri);
            this.groupBox1.Location = new System.Drawing.Point(992, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 100);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Arama";
            // 
            // btnArma
            // 
            this.btnArma.BackColor = System.Drawing.Color.SkyBlue;
            this.btnArma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArma.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnArma.Location = new System.Drawing.Point(132, 34);
            this.btnArma.Name = "btnArma";
            this.btnArma.Size = new System.Drawing.Size(78, 28);
            this.btnArma.TabIndex = 1;
            this.btnArma.Text = "Ara";
            this.btnArma.UseVisualStyleBackColor = false;
            this.btnArma.Click += new System.EventHandler(this.BtnArma_Click);
            // 
            // AranacakMusteri
            // 
            this.AranacakMusteri.Location = new System.Drawing.Point(6, 38);
            this.AranacakMusteri.Name = "AranacakMusteri";
            this.AranacakMusteri.Size = new System.Drawing.Size(120, 21);
            this.AranacakMusteri.TabIndex = 14;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(128, 102);
            this.txtTel.Mask = "(999) 000-0000";
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(120, 21);
            this.txtTel.TabIndex = 19;
            this.txtTel.Tag = "Müşteri Tel";
            this.txtTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTel_KeyPress);
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(590, 19);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(192, 98);
            this.txtAdres.TabIndex = 18;
            this.txtAdres.Tag = "Adres";
            this.txtAdres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtAdres_KeyPress);
            // 
            // txtMusteriSoyisim
            // 
            this.txtMusteriSoyisim.Location = new System.Drawing.Point(127, 69);
            this.txtMusteriSoyisim.Name = "txtMusteriSoyisim";
            this.txtMusteriSoyisim.Size = new System.Drawing.Size(121, 21);
            this.txtMusteriSoyisim.TabIndex = 16;
            this.txtMusteriSoyisim.Tag = "Müşteri Soyisim";
            this.txtMusteriSoyisim.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtIlce_KeyPress);
            // 
            // txtSirketisim
            // 
            this.txtSirketisim.Location = new System.Drawing.Point(128, 16);
            this.txtSirketisim.Name = "txtSirketisim";
            this.txtSirketisim.Size = new System.Drawing.Size(120, 21);
            this.txtSirketisim.TabIndex = 15;
            this.txtSirketisim.Tag = "Şirket İsimi";
            this.txtSirketisim.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtIlce_KeyPress);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.SkyBlue;
            this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuncelle.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnGuncelle.Location = new System.Drawing.Point(837, 24);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(114, 26);
            this.btnGuncelle.TabIndex = 1;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // VerileriGetir
            // 
            this.VerileriGetir.BackColor = System.Drawing.Color.SkyBlue;
            this.VerileriGetir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VerileriGetir.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.VerileriGetir.Location = new System.Drawing.Point(837, 99);
            this.VerileriGetir.Name = "VerileriGetir";
            this.VerileriGetir.Size = new System.Drawing.Size(114, 26);
            this.VerileriGetir.TabIndex = 1;
            this.VerileriGetir.Text = "Verileri Getir";
            this.VerileriGetir.UseVisualStyleBackColor = false;
            this.VerileriGetir.Click += new System.EventHandler(this.VerileriGetir_Click);
            // 
            // txtMusteriisim
            // 
            this.txtMusteriisim.Location = new System.Drawing.Point(128, 43);
            this.txtMusteriisim.Name = "txtMusteriisim";
            this.txtMusteriisim.Size = new System.Drawing.Size(120, 21);
            this.txtMusteriisim.TabIndex = 5;
            this.txtMusteriisim.Tag = "Müşteri İsim";
            this.txtMusteriisim.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtIlce_KeyPress);
            // 
            // Sil
            // 
            this.Sil.BackColor = System.Drawing.Color.SkyBlue;
            this.Sil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sil.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.Sil.Location = new System.Drawing.Point(837, 63);
            this.Sil.Name = "Sil";
            this.Sil.Size = new System.Drawing.Size(114, 26);
            this.Sil.TabIndex = 1;
            this.Sil.Text = "Sil";
            this.Sil.UseVisualStyleBackColor = false;
            this.Sil.Click += new System.EventHandler(this.Sil_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(1, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Müşteri Tel:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(1, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Şirket İsimi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(1, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Müşteri İsim:";
            // 
            // txtEposta
            // 
            this.txtEposta.Location = new System.Drawing.Point(381, 76);
            this.txtEposta.Name = "txtEposta";
            this.txtEposta.Size = new System.Drawing.Size(120, 21);
            this.txtEposta.TabIndex = 4;
            this.txtEposta.Tag = "E-posta";
            this.txtEposta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtEposta_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(530, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 18);
            this.label8.TabIndex = 2;
            this.label8.Text = "Adres:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(266, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "İl:";
            // 
            // txtIlce
            // 
            this.txtIlce.Location = new System.Drawing.Point(381, 48);
            this.txtIlce.Name = "txtIlce";
            this.txtIlce.Size = new System.Drawing.Size(120, 21);
            this.txtIlce.TabIndex = 4;
            this.txtIlce.Tag = "İlçe";
            this.txtIlce.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtIlce_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(1, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Müşteri Soyisim:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(266, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 18);
            this.label6.TabIndex = 2;
            this.label6.Text = "İlçe:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(266, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 18);
            this.label7.TabIndex = 2;
            this.label7.Text = "E-posta:";
            // 
            // txtIL
            // 
            this.txtIL.Location = new System.Drawing.Point(381, 19);
            this.txtIL.Name = "txtIL";
            this.txtIL.Size = new System.Drawing.Size(120, 21);
            this.txtIL.TabIndex = 4;
            this.txtIL.Tag = "İl";
            this.txtIL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtIlce_KeyPress);
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
            this.SirketAd,
            this.AdSoyad,
            this.Soyisim,
            this.SehirIlce,
            this.IL,
            this.Eposta,
            this.Tel,
            this.mAdres});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 132);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Size = new System.Drawing.Size(1205, 438);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "idTut";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // SirketAd
            // 
            this.SirketAd.DataPropertyName = "SirketAd";
            this.SirketAd.HeaderText = "Şirket İsmi";
            this.SirketAd.Name = "SirketAd";
            this.SirketAd.Width = 150;
            // 
            // AdSoyad
            // 
            this.AdSoyad.DataPropertyName = "AdSoyad";
            this.AdSoyad.HeaderText = "İsim";
            this.AdSoyad.Name = "AdSoyad";
            this.AdSoyad.Width = 150;
            // 
            // Soyisim
            // 
            this.Soyisim.DataPropertyName = "Soyisim";
            this.Soyisim.HeaderText = "Soyisim";
            this.Soyisim.Name = "Soyisim";
            this.Soyisim.Width = 150;
            // 
            // SehirIlce
            // 
            this.SehirIlce.DataPropertyName = "SehirIlce";
            this.SehirIlce.HeaderText = "İlçe";
            this.SehirIlce.Name = "SehirIlce";
            this.SehirIlce.Width = 150;
            // 
            // IL
            // 
            this.IL.DataPropertyName = "IL";
            this.IL.HeaderText = "İl";
            this.IL.Name = "IL";
            this.IL.Width = 130;
            // 
            // Eposta
            // 
            this.Eposta.DataPropertyName = "Eposta";
            this.Eposta.HeaderText = "E-Posta";
            this.Eposta.Name = "Eposta";
            this.Eposta.Width = 150;
            // 
            // Tel
            // 
            this.Tel.DataPropertyName = "Tel";
            this.Tel.HeaderText = "Telefon";
            this.Tel.Name = "Tel";
            this.Tel.Width = 130;
            // 
            // mAdres
            // 
            this.mAdres.DataPropertyName = "mAdres";
            this.mAdres.HeaderText = "Adres";
            this.mAdres.Name = "mAdres";
            this.mAdres.Width = 190;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.label25);
            this.panel1.Controls.Add(this.label24);
            this.panel1.Controls.Add(this.label23);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Location = new System.Drawing.Point(0, 132);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1205, 22);
            this.panel1.TabIndex = 24;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Century Gothic", 9.25F, System.Drawing.FontStyle.Bold);
            this.label25.Location = new System.Drawing.Point(448, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(46, 16);
            this.label25.TabIndex = 0;
            this.label25.Text = "Adres";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Century Gothic", 9.25F, System.Drawing.FontStyle.Bold);
            this.label24.Location = new System.Drawing.Point(917, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(54, 16);
            this.label24.TabIndex = 0;
            this.label24.Text = "Telefon";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Century Gothic", 9.25F, System.Drawing.FontStyle.Bold);
            this.label23.Location = new System.Drawing.Point(1048, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(56, 16);
            this.label23.TabIndex = 0;
            this.label23.Text = "E-posta";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Century Gothic", 9.25F, System.Drawing.FontStyle.Bold);
            this.label22.Location = new System.Drawing.Point(639, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(16, 16);
            this.label22.TabIndex = 0;
            this.label22.Text = "İl";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Century Gothic", 9.25F, System.Drawing.FontStyle.Bold);
            this.label21.Location = new System.Drawing.Point(771, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(32, 16);
            this.label21.TabIndex = 0;
            this.label21.Text = "İlçe";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Century Gothic", 9.25F, System.Drawing.FontStyle.Bold);
            this.label20.Location = new System.Drawing.Point(299, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(57, 16);
            this.label20.TabIndex = 0;
            this.label20.Text = "Soyisim";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 9.25F, System.Drawing.FontStyle.Bold);
            this.label19.Location = new System.Drawing.Point(149, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(34, 16);
            this.label19.TabIndex = 0;
            this.label19.Text = "İsim";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 9.25F, System.Drawing.FontStyle.Bold);
            this.label18.Location = new System.Drawing.Point(1, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(74, 16);
            this.label18.TabIndex = 0;
            this.label18.Text = "Şirket İsmi";
            // 
            // SirketleriDuzenleUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Bilgiler);
            this.Name = "SirketleriDuzenleUserControl";
            this.Size = new System.Drawing.Size(1205, 570);
            this.Load += new System.EventHandler(this.SirketleriDuzenleUserControl_Load);
            this.Bilgiler.ResumeLayout(false);
            this.Bilgiler.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Bilgiler;
        private System.Windows.Forms.TextBox AranacakMusteri;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button VerileriGetir;
        private System.Windows.Forms.TextBox txtMusteriisim;
        private System.Windows.Forms.Button Sil;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnArma;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEposta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIlce;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIL;
        private System.Windows.Forms.TextBox txtSirketisim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtMusteriSoyisim;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn SirketAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdSoyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soyisim;
        private System.Windows.Forms.DataGridViewTextBoxColumn SehirIlce;
        private System.Windows.Forms.DataGridViewTextBoxColumn IL;
        private System.Windows.Forms.DataGridViewTextBoxColumn Eposta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAdres;
        private System.Windows.Forms.MaskedTextBox txtTel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
    }
}
