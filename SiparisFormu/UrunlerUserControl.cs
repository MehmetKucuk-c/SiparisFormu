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
    public partial class UrunlerUserControl : UserControl
    {
        public UrunlerUserControl()
        {
            InitializeComponent();
        }
        public int idtut { get; set; }
        private void UrunlerUserControl_Load(object sender, EventArgs e)
        {
            //datagrit veri çekiyoruz
            CsUrunLer urunler = new CsUrunLer();
            dataGridView1.DataSource = urunler.tablola();
            //
            DataBase dataBase = new DataBase();
            if(dataBase.sqlConnection.State==ConnectionState.Open)
            {
                dataBase.sqlConnection.Close();
            }
            try
            {
                dataBase.sqlConnection.Open();
                SqlCommand listlele = new SqlCommand("select *from Birimler", dataBase.sqlConnection);
                SqlDataReader oku = listlele.ExecuteReader();
                while(oku.Read())
                {
                    cmbBirim.Items.Add(oku["Birim"]);
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

        private string konBirim = "";
        private string konBirimFiyat = "";
        private string konStokMiktar = "";
        private string konIskonto = "";
        private string konKDV = "";
        private string konUrunAd = "";
        private string konMarka = "";

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //id çekiyoruz
            int id = Convert.ToInt16(dataGridView1.Rows[e.RowIndex].Cells["id"].Value);
            idtut = id;
            //
            //veri yansıt textBoxsa
            maskedStokCode.Text =   dataGridView1.Rows[e.RowIndex].Cells["StokKodu"].Value.ToString();
            txtUrunAd.Text =        dataGridView1.Rows[e.RowIndex].Cells["Cinsi"].Value.ToString();
            txtMarBarkod.Text =     dataGridView1.Rows[e.RowIndex].Cells["BarkodNo"].Value.ToString();
            cmbBirim.Text =         dataGridView1.Rows[e.RowIndex].Cells["Birim"].Value.ToString();
            txtBirimFiyat.Text =    dataGridView1.Rows[e.RowIndex].Cells["BirimFiyat"].Value.ToString();
            txtStokMiktar.Text =    dataGridView1.Rows[e.RowIndex].Cells["StokMiktar"].Value.ToString();
            txtIskonto.Text =       dataGridView1.Rows[e.RowIndex].Cells["IskontoOrani"].Value.ToString();
            txtKDV.Text =           dataGridView1.Rows[e.RowIndex].Cells["KDVOrani"].Value.ToString();
            Txtmarka.Text =         dataGridView1.Rows[e.RowIndex].Cells["Marka"].Value.ToString();
            //
            //kontrol
            //
            konUrunAd = txtUrunAd.Text.ToString();
            konBirim = cmbBirim.Text.ToString();
            konBirimFiyat = txtBirimFiyat.Text.ToString();
            konStokMiktar = txtStokMiktar.Text.ToString();
            konIskonto = txtIskonto.Text.ToString();
            konKDV = txtKDV.Text.ToString();
            konMarka = Txtmarka.Text.ToString();
        }

        private void BtnArma_Click(object sender, EventArgs e)
        {
            bildirimFrm bil = new bildirimFrm();
            if (AranacakUrun.Text==string.Empty)
            {
                MessageBox.Show("Lütfen arananacak bir ürün adını yazınız.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                CsUrunLer urun = new CsUrunLer();
                bil.stext(AranacakUrun + " bilgileri getirilmiştir");
                dataGridView1.DataSource = urun.UrunAra(AranacakUrun.Text); 
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            bildirimFrm gbil = new bildirimFrm();
            DialogResult ask;
            if(Txtmarka.Text==string.Empty || txtBirimFiyat.Text==string.Empty || maskedStokCode.Text==string.Empty || txtKDV.Text==string.Empty || txtMarBarkod.Text==string.Empty || txtStokMiktar.Text==string.Empty ||txtUrunAd.Text==string.Empty || cmbBirim.Text==string.Empty)
            {
                MessageBox.Show("Lütfen bir ürün seçiniz.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (konUrunAd != txtUrunAd.Text || konBirim != cmbBirim.Text || konBirimFiyat != txtBirimFiyat.Text || konStokMiktar != txtStokMiktar.Text || konIskonto != txtIskonto.Text || konMarka != Txtmarka.Text || konKDV != txtKDV.Text)
                {
                    ask = MessageBox.Show(Txtmarka.Text.ToString() + " " + txtUrunAd.Text.ToString() + " isimli ve " + maskedStokCode.Text.ToString() + " stok numaralı ürünü güncellemek istediğinizden emin misiniz?", "Tegit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (ask == DialogResult.Yes)
                    {
                        CsUrunLer urun = new CsUrunLer();
                        urun.UrunGuncelle(idtut, maskedStokCode.Text.ToString(), CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtUrunAd.Text.ToString()), txtMarBarkod.Text, cmbBirim.Text, txtStokMiktar.Text, txtBirimFiyat.Text, txtIskonto.Text, txtKDV.Text, CultureInfo.CurrentCulture.TextInfo.ToTitleCase(Txtmarka.Text.ToString()));
                        dataGridView1.DataSource = urun.tablola();
                        gbil.stext(maskedStokCode.Text.ToString() + " stok numaralı ve" + Environment.NewLine + Txtmarka.Text.ToString() + " " + txtUrunAd.Text.ToString() + " adlı ürün güncelleme işlemi " + Environment.NewLine + "başarıyla gerçekleştirilmiştir.");
                        gbil.Show();
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
                }
                else
                {
                    MessageBox.Show("Hiç bir bilgi değiştirmediniz.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private string Ad { get; set; }

        private void Sil_Click(object sender, EventArgs e)
        {
            bildirimFrm frm = new bildirimFrm();
            DialogResult ask;
            if (Txtmarka.Text==string.Empty && txtBirimFiyat.Text == string.Empty && maskedStokCode.Text == string.Empty && txtKDV.Text == string.Empty && txtMarBarkod.Text == string.Empty && txtStokMiktar.Text == string.Empty && txtUrunAd.Text == string.Empty && cmbBirim.Text == string.Empty)
            {
                MessageBox.Show("Lütfen silinicek bir ürün seçiniz.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ask = MessageBox.Show(Txtmarka.Text.ToString()+" "+txtUrunAd.Text.ToString() + " isimli ve " + maskedStokCode.Text.ToString() + " stok numaralı ürünü silmek istediğinizden emin misiniz?", "Teyit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                Ad = Txtmarka.Text.ToString() + " " + txtUrunAd.Text.ToString();
                if (ask==DialogResult.Yes)
                {
                    CsUrunLer urun = new CsUrunLer();
                    urun.UrunSil(idtut);
                    frm.stext(maskedStokCode.Text.ToString() + " stok numaralı ve" + Environment.NewLine + Ad + " adlı ürün silme işlemi" + Environment.NewLine + "başarıyla gerçekleştirilmiştir.");
                    dataGridView1.DataSource = urun.tablola();
                    frm.Show();
                    foreach (Control item in Bilgiler.Controls)
                    {
                        if (item is TextBox)
                        {
                            item.Text = "";
                        }
                    }
                }
            }
        }

        private void VerileriGetir_Click(object sender, EventArgs e)
        {
            CsUrunLer urun = new CsUrunLer();
            dataGridView1.DataSource = urun.tablola();
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

        private void TxtStokMiktar_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Sadece Sayı Girdirme
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            // boşluk engellem
            if ((int)e.KeyChar == 32)
            {
                e.Handled = true;
            }
        }

        private void Aranacak_KeyPress(object sender, KeyPressEventArgs e)
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

        private void AranacakUrun_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == 32)
            {
                e.Handled = true;
            }
        }
    }
}
