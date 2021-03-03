using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;

namespace SiparisFormu
{
    
    public partial class UrunEkleUserControl : UserControl
    {
        public UrunEkleUserControl()
        {
            InitializeComponent();
        }

        private void UrunEkleUserControl_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Enabled = true;
            pictureBox1.Image = ımageList1.Images[0];
            DataBase dataBase = new DataBase();
            degistir kontrol = new degistir();
            Rnd sayirüret = new Rnd();
            if (dataBase.sqlConnection.State == ConnectionState.Open)
            {
                dataBase.sqlConnection.Close();
            }
            try
            {
                maskedStokCode.Text = sayirüret.random(0, 9, 12).ToString();
                txtMarBarkod.Text = sayirüret.sayi(0, 9, 16).ToString();
                // aynı sayı olmaması için kontorol
                maskedStokCode.Text=kontrol.kontrol(maskedStokCode.Text.ToString(), "StokKodu");
                txtMarBarkod.Text= kontrol.kontrol(txtMarBarkod.Text.ToString(), "BarkodNo");

                dataBase.sqlConnection.Open();
                //combo box veri çekiyorum
                SqlCommand listlele = new SqlCommand("select *from Birimler", dataBase.sqlConnection);
                SqlDataReader oku = listlele.ExecuteReader();
                while (oku.Read())
                {
                    cmbBirim.Items.Add(oku["Birim"]);
                    cmbBirimSil.Items.Add(oku["Birim"]);
                }
                dataBase.sqlConnection.Close();
                oku.Close();
                listlele.Dispose();
            }
            catch { }
            finally
            {
                dataBase.sqlConnection.Close();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Rnd sayi = new Rnd();
            degistir kontrol = new degistir();
            DataBase dataBase = new DataBase();
            bildirimFrm bil = new bildirimFrm(); 
            if (dataBase.sqlConnection.State == ConnectionState.Open)
            {
                dataBase.sqlConnection.Close();
            }
            try
            {
                if(txtBirimFiyat.Text==string.Empty || txtKDV.Text==string.Empty || txtStokMiktar.Text==string.Empty || txtUrunAdi.Text==string.Empty ||txtMarka.Text==string.Empty)
                {
                    MessageBox.Show("Lütfen başında ' * '  olan tüm alanları doldurunuz.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dataBase.sqlConnection.Open();
                    SqlCommand ekle = new SqlCommand("insert into urunler values(@StokKodu,@Cinsi,@BarkodNo,@Birim,@StokMiktar,@BirimFiyat,@IskontoOrani,@KDVOrani,@Marka)", dataBase.sqlConnection);
                    ekle.Parameters.AddWithValue("@StokKodu", maskedStokCode.Text.ToString());
                    ekle.Parameters.AddWithValue("@Cinsi", CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtUrunAdi.Text.ToString()));
                    ekle.Parameters.AddWithValue("@BarkodNo", txtMarBarkod.Text.ToString());
                    ekle.Parameters.AddWithValue("@Birim", cmbBirim.Text.ToString());
                    ekle.Parameters.AddWithValue("@StokMiktar", txtStokMiktar.Text.ToString());
                    ekle.Parameters.AddWithValue("@BirimFiyat", txtBirimFiyat.Text.ToString());
                    ekle.Parameters.AddWithValue("@IskontoOrani", txtIskonto.Text.ToString());
                    ekle.Parameters.AddWithValue("@KDVOrani", txtKDV.Text.ToString());
                    ekle.Parameters.AddWithValue("@Marka", CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtMarka.Text.ToString()));
                    ekle.ExecuteNonQuery();
                    bil.stext(maskedStokCode.Text.ToString() + " stok numaralı ve" +Environment.NewLine + txtUrunAdi.Text.ToString() + " isimli ürün kayıt edilmiştir");
                    bil.Show();
                    foreach (Control item in UrunBilgileri.Controls)
                    {
                        if (item is TextBox)
                        {
                            item.Text = "";
                        }
                        if (item is MaskedTextBox)
                        {
                            item.Text = sayi.random(0, 9, 16);
                            item.Text = sayi.sayi(0, 9, 16);
                            item.Text = kontrol.kontrol(txtMarBarkod.Text.ToString(), "BarkodNo");
                        }
                    } 
                }
            }
            catch { }
            finally
            {
                dataBase.sqlConnection.Close();
            }
        }

        private void TxtKDV_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Sadece Sayı Girdirme
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            // boşluk engellem
            if ((int)e.KeyChar == 32)
            {
                e.Handled = true;
            }
        }

        private void TxtUrunAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            //özel karekter engelleme
            if (e.KeyChar == '£' || e.KeyChar == '½' || e.KeyChar == '€' || e.KeyChar == '₺' || e.KeyChar == '¨' || e.KeyChar == 'æ' || e.KeyChar == 'ß' || e.KeyChar == '´')
            {
                e.Handled = true;
            }
            if ((int)e.KeyChar >= 33 && (int)e.KeyChar <= 47)
            {
                e.Handled = true;
            }
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

        private void Button2_Click(object sender, EventArgs e)
        {
            DataBase dataBase = new DataBase();
            if(dataBase.sqlConnection.State==ConnectionState.Open)
            {
                dataBase.sqlConnection.Close();
            }
            try
            {
                dataBase.sqlConnection.Open();
                if(textBoxBirim.Text==string.Empty)
                {
                    MessageBox.Show("Lütfen bir birim giriniz.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    SqlCommand brmekle = new SqlCommand("insert into Birimler values (@Birim)", dataBase.sqlConnection);
                    brmekle.Parameters.AddWithValue("@Birim", CultureInfo.CurrentCulture.TextInfo.ToTitleCase(textBoxBirim.Text.ToString()));
                    brmekle.ExecuteNonQuery();
                    MessageBox.Show(textBoxBirim.Text.ToString() + " birimi kayıt edelmiştir.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataBase.sqlConnection.Close();
                    brmekle.Dispose();
                    textBoxBirim.Text = "";
                }
            }
            catch { }
            finally
            {
                dataBase.sqlConnection.Close();
            }
        }

        private void TextBoxBirim_KeyPress(object sender, KeyPressEventArgs e)
        {
            //sadece harf girmek
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
            //boşluk engelleme
            if ((int)e.KeyChar == 32)
            {
                e.Handled = true;
            }
        }

        private void Birimsil_Click(object sender, EventArgs e)
        {
            DialogResult ask;
            DataBase dataBase = new DataBase();
            if (dataBase.sqlConnection.State == ConnectionState.Open)
            {
                dataBase.sqlConnection.Close();
            }
            try
            {
                dataBase.sqlConnection.Open();
                if (cmbBirimSil.Text == string.Empty)
                {
                    MessageBox.Show("Lütfen silinicek birimi şeçiniz.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ask= MessageBox.Show("''"+cmbBirimSil.Text.ToString()+"''"+" birimini silmek istediğinizden emin misiniz?", "Teyit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if(ask==DialogResult.Yes)
                    {
                        SqlCommand brmsil = new SqlCommand("delete Birimler where Birim=@Birim", dataBase.sqlConnection);
                        brmsil.Parameters.AddWithValue("@Birim", cmbBirimSil.Text.ToString());
                        brmsil.ExecuteNonQuery();
                        MessageBox.Show("''" + cmbBirimSil.Text.ToString()+"''" + " birimi başarıyla silinmiştir.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                        dataBase.sqlConnection.Close();
                        brmsil.Dispose();
                    }
                }
            }
            catch { }
            finally
            {
                dataBase.sqlConnection.Close();
            }
        }
        int i;
        private void Timer1_Tick(object sender, EventArgs e)
        {
            i++;
            if (i == 6)
                i = 0;
            pictureBox1.Image = ımageList1.Images[i];
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if(button3.Text== "Slaytı Durdur")
            {
                timer1.Stop();
                button3.Text = "Slaytı Başlat";
            }
            else
            {
                button3.Text = "Slaytı Durdur";
                timer1.Start();
            }
        }
    }
}
