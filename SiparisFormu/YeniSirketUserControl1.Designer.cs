namespace SiparisFormu
{
    partial class YeniSirketUserControl1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMusterisim = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.maskTel = new System.Windows.Forms.MaskedTextBox();
            this.musterigrobbox = new System.Windows.Forms.GroupBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtIsyerisim = new System.Windows.Forms.TextBox();
            this.musterikayitbtn = new System.Windows.Forms.Button();
            this.TxtIlce = new System.Windows.Forms.TextBox();
            this.txtIl = new System.Windows.Forms.TextBox();
            this.txtMusterSoyisim = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.musterigrobbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(18, 322);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "*Adres:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(18, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "*Müsteri İsimi:";
            // 
            // txtMusterisim
            // 
            this.txtMusterisim.Location = new System.Drawing.Point(206, 21);
            this.txtMusterisim.Name = "txtMusterisim";
            this.txtMusterisim.Size = new System.Drawing.Size(130, 21);
            this.txtMusterisim.TabIndex = 0;
            this.txtMusterisim.Tag = "*Müsteri İsimi:";
            this.txtMusterisim.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox1_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(18, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Müsteri Telefon No:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(18, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "*İl:";
            // 
            // maskTel
            // 
            this.maskTel.Location = new System.Drawing.Point(206, 102);
            this.maskTel.Mask = "(999) 000-0000";
            this.maskTel.Name = "maskTel";
            this.maskTel.Size = new System.Drawing.Size(130, 21);
            this.maskTel.TabIndex = 2;
            this.maskTel.Tag = "Müsteri Telefon No:";
            this.maskTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MaskedTextBox1_KeyPress);
            // 
            // musterigrobbox
            // 
            this.musterigrobbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.musterigrobbox.Controls.Add(this.txtAdres);
            this.musterigrobbox.Controls.Add(this.txtIsyerisim);
            this.musterigrobbox.Controls.Add(this.musterikayitbtn);
            this.musterigrobbox.Controls.Add(this.TxtIlce);
            this.musterigrobbox.Controls.Add(this.txtIl);
            this.musterigrobbox.Controls.Add(this.txtMusterSoyisim);
            this.musterigrobbox.Controls.Add(this.label8);
            this.musterigrobbox.Controls.Add(this.label5);
            this.musterigrobbox.Controls.Add(this.txtMail);
            this.musterigrobbox.Controls.Add(this.maskTel);
            this.musterigrobbox.Controls.Add(this.label1);
            this.musterigrobbox.Controls.Add(this.label3);
            this.musterigrobbox.Controls.Add(this.label7);
            this.musterigrobbox.Controls.Add(this.label4);
            this.musterigrobbox.Controls.Add(this.label6);
            this.musterigrobbox.Controls.Add(this.label2);
            this.musterigrobbox.Controls.Add(this.txtMusterisim);
            this.musterigrobbox.Dock = System.Windows.Forms.DockStyle.Left;
            this.musterigrobbox.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.musterigrobbox.Location = new System.Drawing.Point(0, 0);
            this.musterigrobbox.Name = "musterigrobbox";
            this.musterigrobbox.Size = new System.Drawing.Size(459, 570);
            this.musterigrobbox.TabIndex = 7;
            this.musterigrobbox.TabStop = false;
            this.musterigrobbox.Text = "Müsteri Bilgileri";
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(206, 322);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(213, 105);
            this.txtAdres.TabIndex = 7;
            this.txtAdres.Tag = "*Adres:";
            this.txtAdres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox7_KeyPress);
            // 
            // txtIsyerisim
            // 
            this.txtIsyerisim.Location = new System.Drawing.Point(206, 183);
            this.txtIsyerisim.Name = "txtIsyerisim";
            this.txtIsyerisim.Size = new System.Drawing.Size(130, 21);
            this.txtIsyerisim.TabIndex = 4;
            this.txtIsyerisim.Tag = "*İş Yeri İsmi:";
            this.txtIsyerisim.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox1_KeyPress);
            // 
            // musterikayitbtn
            // 
            this.musterikayitbtn.BackColor = System.Drawing.Color.SkyBlue;
            this.musterikayitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.musterikayitbtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.musterikayitbtn.Location = new System.Drawing.Point(308, 511);
            this.musterikayitbtn.Name = "musterikayitbtn";
            this.musterikayitbtn.Size = new System.Drawing.Size(111, 28);
            this.musterikayitbtn.TabIndex = 8;
            this.musterikayitbtn.Text = "Kayıt Oluştur";
            this.musterikayitbtn.UseVisualStyleBackColor = false;
            this.musterikayitbtn.Click += new System.EventHandler(this.Musterikayitbtn_Click);
            // 
            // TxtIlce
            // 
            this.TxtIlce.Location = new System.Drawing.Point(206, 273);
            this.TxtIlce.Name = "TxtIlce";
            this.TxtIlce.Size = new System.Drawing.Size(130, 21);
            this.TxtIlce.TabIndex = 6;
            this.TxtIlce.Tag = "*İlçe";
            this.TxtIlce.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox1_KeyPress);
            // 
            // txtIl
            // 
            this.txtIl.Location = new System.Drawing.Point(206, 221);
            this.txtIl.Name = "txtIl";
            this.txtIl.Size = new System.Drawing.Size(130, 21);
            this.txtIl.TabIndex = 5;
            this.txtIl.Tag = "*İl:";
            this.txtIl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox1_KeyPress);
            // 
            // txtMusterSoyisim
            // 
            this.txtMusterSoyisim.Location = new System.Drawing.Point(206, 63);
            this.txtMusterSoyisim.Name = "txtMusterSoyisim";
            this.txtMusterSoyisim.Size = new System.Drawing.Size(130, 21);
            this.txtMusterSoyisim.TabIndex = 1;
            this.txtMusterSoyisim.Tag = "*Müsteri Soyismi:";
            this.txtMusterSoyisim.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox1_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(18, 183);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 18);
            this.label8.TabIndex = 8;
            this.label8.Text = "*İş Yeri İsmi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(18, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "*Müsteri Mail:";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(206, 145);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(130, 21);
            this.txtMail.TabIndex = 3;
            this.txtMail.Tag = "*Müsteri Mail:";
            this.txtMail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox2_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(18, 276);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 18);
            this.label7.TabIndex = 5;
            this.label7.Text = "*İlçe";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(18, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 18);
            this.label6.TabIndex = 2;
            this.label6.Text = "*Müsteri Soyismi:";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::SiparisFormu.Properties.Resources.indir;
            this.pictureBox4.Location = new System.Drawing.Point(836, 213);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(366, 357);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::SiparisFormu.Properties.Resources.images__1_;
            this.pictureBox3.Location = new System.Drawing.Point(857, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(348, 242);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SiparisFormu.Properties.Resources.indir__2_;
            this.pictureBox2.Location = new System.Drawing.Point(454, 235);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(406, 335);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SiparisFormu.Properties.Resources.images1;
            this.pictureBox1.Location = new System.Drawing.Point(454, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(406, 242);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // YeniSirketUserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.musterigrobbox);
            this.Name = "YeniSirketUserControl1";
            this.Size = new System.Drawing.Size(1205, 570);
            this.musterigrobbox.ResumeLayout(false);
            this.musterigrobbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMusterisim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox maskTel;
        private System.Windows.Forms.GroupBox musterigrobbox;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtIlce;
        private System.Windows.Forms.TextBox txtIl;
        private System.Windows.Forms.TextBox txtMusterSoyisim;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button musterikayitbtn;
        private System.Windows.Forms.TextBox txtIsyerisim;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}
