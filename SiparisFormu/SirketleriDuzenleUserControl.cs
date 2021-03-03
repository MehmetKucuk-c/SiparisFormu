using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using System.Text.RegularExpressions;

namespace SiparisFormu
{
    public partial class SirketleriDuzenleUserControl : UserControl
    {
        public SirketleriDuzenleUserControl()
        {
            InitializeComponent();
        }
        public string Metot(string kelime)
        {
            return _ = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(kelime).ToString();
        }
        CsMusteriler musteri = new CsMusteriler();

        private void SirketleriDuzenleUserControl_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = musteri.tablola();
        }

        public int idtut { get; set; }
        private string konIsım = "";
        private string konAdres = "";
        private string konSirket = "";
        private string konIlce = "";
        private string konIl = "";
        private string konTel = "";
        private string konEposta = "";
        private string konSoyisim = "";
        
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //
            //id çekiyoruz
            //
            int id = Convert.ToInt16(dataGridView1.Rows[e.RowIndex].Cells["id"].Value);
            idtut = id;
            //
            //veri yansıt textBoxsa
            //
            txtSirketisim.Text = dataGridView1.Rows[e.RowIndex].Cells["SirketAd"].Value.ToString();
            txtAdres.Text = dataGridView1.Rows[e.RowIndex].Cells["mAdres"].Value.ToString();
            txtMusteriisim.Text = dataGridView1.Rows[e.RowIndex].Cells["AdSoyad"].Value.ToString();
            txtIlce.Text = dataGridView1.Rows[e.RowIndex].Cells["SehirIlce"].Value.ToString();
            txtTel.Text = dataGridView1.Rows[e.RowIndex].Cells["Tel"].Value.ToString();
            txtEposta.Text = dataGridView1.Rows[e.RowIndex].Cells["Eposta"].Value.ToString();
            txtMusteriSoyisim.Text = dataGridView1.Rows[e.RowIndex].Cells["Soyisim"].Value.ToString();
            txtIL.Text = dataGridView1.Rows[e.RowIndex].Cells["IL"].Value.ToString();
            //
            //kotrol
            //
            konIsım = txtMusteriisim.Text.ToString();
            konSoyisim = txtMusteriSoyisim.Text.ToString();
            konAdres = txtAdres.Text.ToString();
            konSirket = txtSirketisim.Text.ToString();
            konIlce = txtIlce.Text.ToString();
            konIl = txtIL.Text.ToString();
            konTel = txtTel.Text.ToString();
            konEposta = txtEposta.Text.ToString();
            //
            ///////
            //
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            bildirimFrm bil = new bildirimFrm();
            int kontrol = 0;
            // textboxları kontrol ediyorum hangisi boşssa kullanıya bildiriliyor
            foreach (Control ctl in Bilgiler.Controls)
            {
                if (ctl is TextBox)
                {
                    if (ctl.Text == String.Empty)
                    {
                        MessageBox.Show(Convert.ToString(((TextBox)ctl).Tag + " alanını doldurun lütfen."), "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                    else
                    {
                        kontrol++;
                    }
                } 
            }
            DialogResult ask;
            if (konIsım != txtMusteriisim.Text || konSoyisim != txtMusteriSoyisim.Text || konAdres != txtAdres.Text || konSirket != txtSirketisim.Text || konIlce != txtIlce.Text || konIl != txtIL.Text || konTel != txtTel.Text || konEposta != txtEposta.Text)
            {
                ask = MessageBox.Show(Metot(txtMusteriisim.Text.ToString()) + " " + txtMusteriSoyisim.Text.ToString().ToUpper() + " isimli müşteriyi güncellemek istediğinizden emin misiniz?", "Tegit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ask==DialogResult.Yes)
                {
                    if (kontrol == 7)
                    {
                        Regex r = new Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");

                        if (r.IsMatch(txtEposta.Text))
                        {
                            musteri.MusteriGuncelle(idtut, Metot(txtSirketisim.Text.ToString()), Metot(txtMusteriisim.Text.ToString()), txtMusteriSoyisim.Text.ToString().ToUpper(), Metot(txtAdres.Text.ToString()), txtIL.Text.ToString().ToUpper(), Metot(txtIlce.Text.ToString()), txtTel.Text.ToString(), txtEposta.Text.ToString());
                            //MessageBox.Show(Metot(txtMusteriisim.Text.ToString()) + " " + txtMusteriSoyisim.Text.ToString().ToUpper() + " müşteri bilgileri başarı ile güncellenmiştir", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                            bil.stext(Metot(txtMusteriisim.Text.ToString()) + " " + txtMusteriSoyisim.Text.ToString().ToUpper() + " müşteri bilgileri güncellenmiştir");
                            bil.Show();
                            dataGridView1.DataSource = musteri.tablola();
                        }
                        else
                        {
                            MessageBox.Show("Uyuşmayan E-posta adresi lütfen düzeltin.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }   
                } 
            }
            else
            {
                MessageBox.Show("Hiç bir bilgi değiştirlmedi.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private DialogResult ask;

        private void Sil_Click(object sender, EventArgs e)
        {
            bildirimFrm bsil = new bildirimFrm();
            if(txtIL.Text==string.Empty && txtIlce.Text==string.Empty && txtAdres.Text==string.Empty && txtMusteriisim.Text==string.Empty && txtMusteriSoyisim.Text==string.Empty && txtSirketisim.Text==string.Empty && txtEposta.Text==string.Empty)
            {
                foreach (Control ctl in Bilgiler.Controls)
                {
                    if (ctl is TextBox)
                    {
                        if (ctl.Text == String.Empty)
                        {
                            MessageBox.Show(Convert.ToString(((TextBox)ctl).Tag + " alanını doldurun lütfen."), "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                            
                        }
                    }
                }
            }

            else
            {
                ask = MessageBox.Show(Metot(txtMusteriisim.Text.ToString()) + " " + txtMusteriSoyisim.Text.ToString().ToUpper() + " isimli müşteriyi silmek istediğinizden emin misiniz?", "Tegit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ask == DialogResult.Yes)
                {
                    bsil.stext(Metot(txtMusteriisim.Text.ToString()) + " " + txtMusteriSoyisim.Text.ToString().ToUpper() + " isimli müşteri başarı ile silinmiştir");
                    musteri.MusteriSil(idtut);
                    bsil.Show();
                    dataGridView1.DataSource = musteri.tablola();
                    //MessageBox.Show(Metot(txtMusteriisim.Text.ToString()) + " " + txtMusteriSoyisim.Text.ToString().ToUpper() + " isimli müşteri başarı ile silinmiştir", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void VerileriGetir_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = musteri.tablola();
            foreach (Control item in Bilgiler.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
                if (item is MaskedTextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void BtnArma_Click(object sender, EventArgs e)
        {
            bildirimFrm abil = new bildirimFrm();
            if (AranacakMusteri.Text == string.Empty)
            {
                MessageBox.Show("Arananacak müsteri hakkında bir bilgi yazınız lütfen.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                abil.stext(AranacakMusteri.Text.ToString() + " bilgileri getirilmiştir");
                abil.Show();
                dataGridView1.DataSource = musteri.MusteriAra(AranacakMusteri.Text);
            }
        }

        private void TxtAdres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '£' || e.KeyChar == '½' || e.KeyChar == '€' || e.KeyChar == '₺' || e.KeyChar == '¨' || e.KeyChar == 'æ' || e.KeyChar == 'ß' || e.KeyChar == '´')
            {
                e.Handled = true;
            }
            if ((int)e.KeyChar >= 123 && (int)e.KeyChar <= 127)
            {
                e.Handled = true;
            }
            if ((int)e.KeyChar >= 91 && (int)e.KeyChar <= 96)
            {
                e.Handled = true;
            }
        }

        private void TxtEposta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '£' || e.KeyChar == '½' || e.KeyChar == '€' || e.KeyChar == '₺' || e.KeyChar == '¨' || e.KeyChar == 'æ' || e.KeyChar == 'ß' || e.KeyChar == '´')
            {
                e.Handled = true;
            }
            if ((int)e.KeyChar == 32)
            {
                e.Handled = true;
            }
            if ((int)e.KeyChar >= 123 && (int)e.KeyChar <= 127)
            {
                e.Handled = true;
            }
        }

        private void TxtIlce_KeyPress(object sender, KeyPressEventArgs e)
        {
            //özel karekter engelleme
            if (e.KeyChar == '£' || e.KeyChar == '½' || e.KeyChar == '€' || e.KeyChar == '₺' || e.KeyChar == '¨' || e.KeyChar == 'æ' || e.KeyChar == 'ß' || e.KeyChar == '´')
            {
                e.Handled = true;
            }
            //shift engelle
            if ((int)e.KeyChar >= 33 && (int)e.KeyChar <= 47)
            {
                e.Handled = true;
            }
            //alt engelle
            if ((int)e.KeyChar >= 58 && (int)e.KeyChar <= 64)
            {
                e.Handled = true;
            }

            if ((int)e.KeyChar >= 91 && (int)e.KeyChar <= 96)
            {
                e.Handled = true;
            }
            if ((int)e.KeyChar >= 123 && (int)e.KeyChar <= 127)
            {
                e.Handled = true;
            }
            //sadece harf girmek
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
            //boşluk engelleme
            if ((int)e.KeyChar == 32)
            {
                e.Handled = true;
            }
        }

        private void TxtTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Sadece Sayı Girdirme
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            // boşluk engellem
            if ((int)e.KeyChar == 32)
            {
                e.Handled = true;
            }
        }
    }
}
