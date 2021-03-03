using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using System.Globalization;

namespace SiparisFormu
{
    public partial class YeniSirketUserControl1 : UserControl
    {
        public YeniSirketUserControl1()
        {
            InitializeComponent();
        }
        private string adSoyad { get; set; }
        // ilk harf Büyük metodu
        public string Metot(string kelime)
        {
            return _ = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(kelime).ToString();
        }
        private void Musterikayitbtn_Click(object sender, EventArgs e)
        {
            int kontrol = 0;
            adSoyad = Metot(txtMusterisim.Text.ToString()) + " " +txtMusterSoyisim.Text.ToUpper().ToString();
            DataBase dataBase = new DataBase();
            try
            {
                // mail formatı
                Regex r = new Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
                if (r.IsMatch(txtMail.Text))
                {
                    if (dataBase.sqlConnection.State == ConnectionState.Open)
                    {
                        dataBase.sqlConnection.Close();
                    }
                    dataBase.sqlConnection.Open();
                    SqlCommand musteriEkle = new SqlCommand("insert into Musteriler values(@SirketAd,@Adres,@AdSoyad,@SehirIlce,@Tel,@Eposta,@Soyisim,@IL)", dataBase.sqlConnection);
                    musteriEkle.Parameters.AddWithValue("@SirketAd", Metot(txtIsyerisim.Text.ToString()));
                    musteriEkle.Parameters.AddWithValue("@Adres", Metot(txtAdres.Text.ToString()));
                    musteriEkle.Parameters.AddWithValue("@AdSoyad", Metot(txtMusterisim.Text.ToString()));
                    musteriEkle.Parameters.AddWithValue("@SehirIlce", Metot(TxtIlce.Text.ToString()));
                    musteriEkle.Parameters.AddWithValue("@Tel", maskTel.Text.ToString());
                    musteriEkle.Parameters.AddWithValue("@Eposta", txtMail.Text.ToString());
                    musteriEkle.Parameters.AddWithValue("@IL",txtIl.Text.ToString().ToUpper());
                    musteriEkle.Parameters.AddWithValue("@Soyisim",txtMusterSoyisim.Text.ToString().ToUpper());
                    //textboxları kontrol ediyorum
                    foreach (Control ctl in musterigrobbox.Controls)
                    {
                        if (ctl is TextBox)
                        {
                            if (ctl.Text == String.Empty)
                            {
                                MessageBox.Show("Lütfen "+Convert.ToString(((TextBox)ctl).Tag + " alanını doldurun."),"HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                            }
                            else
                            {
                                //textbox sayısı kadar arıtcak
                                kontrol++;
                            }
                        }
                    }
                    bildirimFrm bil = new bildirimFrm();
                    if(kontrol >= 7)
                    {
                        musteriEkle.ExecuteNonQuery();
                        bil.stext(adSoyad + " isimli müsteri başarıyla kayıt edilmiştir");
                        bil.Show();
                        foreach (Control item in musterigrobbox.Controls)
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
                }
                else
                {
                    MessageBox.Show("Uyuşmayan E-posta adresi lütfen düzeltin","HATA",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("" + hata);
            }
            finally
            {
                dataBase.sqlConnection.Close();
            }
        }

        private void MaskedTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Sadece Sayı Girdirme
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            // boşluk engellem
            if ((int)e.KeyChar == 32)
            {
                e.Handled = true;
            }
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void TextBox2_KeyPress(object sender, KeyPressEventArgs e)
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

        private void TextBox7_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}




//textBox Kontrol
//  foreach (Control ctl in this.Controls)
//                if (ctl is TextBox)
//                {
//    if (ctl.Text == String.Empty)
//    {
//        MessageBox.Show(Convert.ToString(((TextBox)ctl).Tag + " boş!"));
//    }
//}
