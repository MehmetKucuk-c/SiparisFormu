using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SiparisFormu
{
    public partial class SiparisUserControl : UserControl
    {
        public int urunid { get; set; }
        public SiparisUserControl()
        {
            InitializeComponent();
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //id çekiyoruz
            int id = Convert.ToInt16(dataGridView1.Rows[e.RowIndex].Cells["id"].Value);
            urunid = id;
            //
            //veri yansıt textBoxsa
            maskedStokCode.Text = dataGridView1.Rows[e.RowIndex].Cells["StokKodu"].Value.ToString();
            txtUrunAd.Text = dataGridView1.Rows[e.RowIndex].Cells["Cinsi"].Value.ToString();
            txtMarBarkod.Text = dataGridView1.Rows[e.RowIndex].Cells["BarkodNo"].Value.ToString();
            cmbBirim.Text = dataGridView1.Rows[e.RowIndex].Cells["Birim"].Value.ToString();
            txtBirimFiyat.Text = dataGridView1.Rows[e.RowIndex].Cells["BirimFiyat"].Value.ToString();
            txtStokMiktar.Text = dataGridView1.Rows[e.RowIndex].Cells["StokMiktar"].Value.ToString();
            txtIskonto.Text = dataGridView1.Rows[e.RowIndex].Cells["IskontoOrani"].Value.ToString();
            txtKDV.Text = dataGridView1.Rows[e.RowIndex].Cells["KDVOrani"].Value.ToString();
            Txtmarka.Text = dataGridView1.Rows[e.RowIndex].Cells["Marka"].Value.ToString();
        }

        CsMusteriler musteri = new CsMusteriler();
        CsUrunLer urunler = new CsUrunLer();
        private void SiparisUserControl_Load(object sender, EventArgs e)
        {

            dataGridView1.DataSource = urunler.tablola();

            dataGridView2.DataSource = musteri.tablola();
            //
            DataBase dataBase = new DataBase();
            if (dataBase.sqlConnection.State == ConnectionState.Open)
            {
                dataBase.sqlConnection.Close();
            }
            try
            {
                dataBase.sqlConnection.Open();
                SqlCommand listlele = new SqlCommand("select *from Birimler", dataBase.sqlConnection);
                SqlDataReader oku = listlele.ExecuteReader();
                while (oku.Read())
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

        private void Urunara_Click(object sender, EventArgs e)
        {
            if (AranacakUrun.Text == string.Empty)
            {
                MessageBox.Show("Lütfen arananacak bir ürün adını yazınız.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                dataGridView1.DataSource = urunler.UrunAra(AranacakUrun.Text);
            }
        }

        private void BtnArma_Click(object sender, EventArgs e)
        {
            if (AranacakMusteri.Text == string.Empty)
            {
                MessageBox.Show("Arananacak müsteri hakkında bir bilgi yazınız lütfen.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                dataGridView2.DataSource = musteri.MusteriAra(AranacakMusteri.Text);
            }
        }

        private void Btnveriler_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = urunler.tablola();
            dataGridView2.DataSource = musteri.tablola();

            foreach (Control item in UrunBilgiler.Controls)
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
            AranacakMusteri.Text = "";
            AranacakUrun.Text = "";
        }
        public int musteriid{ set; get; }
        private void DataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //id çekiyoruz
            int id = Convert.ToInt16(dataGridView2.Rows[e.RowIndex].Cells["mid"].Value);
            musteriid = id;
            //
            //veri yansıt textBoxsa
            txtSirketisim.Text = dataGridView2.Rows[e.RowIndex].Cells["SirketAd"].Value.ToString();
            txtAdres.Text = dataGridView2.Rows[e.RowIndex].Cells["mAdres"].Value.ToString();
            txtMusteriisim.Text = dataGridView2.Rows[e.RowIndex].Cells["AdSoyad"].Value.ToString();
            txtIlce.Text = dataGridView2.Rows[e.RowIndex].Cells["SehirIlce"].Value.ToString();
            txtTel.Text = dataGridView2.Rows[e.RowIndex].Cells["Tel"].Value.ToString();
            txtEposta.Text = dataGridView2.Rows[e.RowIndex].Cells["Eposta"].Value.ToString();
            txtMusteriSoyisim.Text = dataGridView2.Rows[e.RowIndex].Cells["Soyisim"].Value.ToString();
            txtIL.Text = dataGridView2.Rows[e.RowIndex].Cells["IL"].Value.ToString();
        }

        MesajForm msj = new MesajForm();

        private void BtnListeyeEkle_Click(object sender, EventArgs e)
        {
            if(Txtmarka.Text==string.Empty || txtBirimFiyat.Text==string.Empty || txtUrunAd.Text == string.Empty || maskedStokCode.Text==string.Empty || txtMarBarkod.Text==string.Empty  || txtKDV.Text==string.Empty)
            {
                MessageBox.Show("Lütfen bir ürün seçiniz.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                msj.urunBilgileri(txtUrunAd.Text, Txtmarka.Text, maskedStokCode.Text, txtMarBarkod.Text, txtBirimFiyat.Text, txtIskonto.Text, txtKDV.Text);
                if (txtSirketisim.Text==string.Empty || txtMusteriisim.Text==string.Empty || txtMusteriSoyisim.Text==string.Empty || txtIL.Text==string.Empty || txtIlce.Text==string.Empty || txtAdres.Text==string.Empty || txtEposta.Text==string.Empty)
                {
                    MessageBox.Show("Lütfen bir müsteri seçiniz", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    msj.Show();
                    msj.txtadet.Focus();
                    msj.MusteriBilgileri(txtSirketisim.Text, txtMusteriisim.Text, txtMusteriSoyisim.Text, txtTel.Text, txtIL.Text, txtIlce.Text, txtAdres.Text, txtEposta.Text);
                    dataGridView2.Visible = false;
                    panel1.Visible = false;
                    groupBox1.Visible = false;
                    dataGridView1.Height = 490;
                    groupBox5.Visible = true;
                }
            }
        }

        private void BtnListeyiGoster_Click(object sender, EventArgs e)
        {
            msj.panelSiparisForm.Visible = true;
            msj.Show();
        }

        private void BtnSirketDegistir_Click(object sender, EventArgs e)
        {
            dataGridView2.Visible = true;
            panel1.Visible = true;
            groupBox1.Visible = true;
            dataGridView1.Height = 197;
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

        private void DataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (txtSirketisim.Text == string.Empty || txtMusteriisim.Text == string.Empty || txtMusteriSoyisim.Text == string.Empty || txtIL.Text == string.Empty || txtIlce.Text == string.Empty || txtAdres.Text == string.Empty || txtEposta.Text == string.Empty)
            {
                MessageBox.Show("Lütfen bir müsteri seçiniz", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //adresin değişmesi için bir ürün ekle
                msj.txtadet.Focus();
                msj.MusteriBilgileri(txtSirketisim.Text, txtMusteriisim.Text, txtMusteriSoyisim.Text, txtTel.Text, txtIL.Text, txtIlce.Text, txtAdres.Text, txtEposta.Text);
                dataGridView2.Visible = false;
                panel1.Visible = false;
                groupBox1.Visible = false;
                dataGridView1.Height = 490;
                groupBox5.Visible = true;
            }
        }

        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Txtmarka.Text == string.Empty || txtBirimFiyat.Text == string.Empty || txtUrunAd.Text == string.Empty || maskedStokCode.Text == string.Empty || txtMarBarkod.Text == string.Empty || txtKDV.Text == string.Empty)
            {
                MessageBox.Show("Lütfen bir ürün seçiniz.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                msj.urunBilgileri(txtUrunAd.Text, Txtmarka.Text, maskedStokCode.Text, txtMarBarkod.Text, txtBirimFiyat.Text, txtIskonto.Text, txtKDV.Text);
                if (txtSirketisim.Text == string.Empty || txtMusteriisim.Text == string.Empty || txtMusteriSoyisim.Text == string.Empty || txtIL.Text == string.Empty || txtIlce.Text == string.Empty || txtAdres.Text == string.Empty || txtEposta.Text == string.Empty)
                {
                    MessageBox.Show("Lütfen bir müsteri seçiniz", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    msj.Show();
                    msj.txtadet.Focus();
                    msj.MusteriBilgileri(txtSirketisim.Text, txtMusteriisim.Text, txtMusteriSoyisim.Text, txtTel.Text, txtIL.Text, txtIlce.Text, txtAdres.Text, txtEposta.Text);
                    dataGridView2.Visible = false;
                    panel1.Visible = false;
                    groupBox1.Visible = false;
                    dataGridView1.Height = 490;
                    groupBox5.Visible = true;
                }
            }
        }
    }
}
