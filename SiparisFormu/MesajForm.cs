using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;

namespace SiparisFormu
{
    public partial class MesajForm : Form
    {

        public MesajForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            //
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        //
        //oval form
        private static extern IntPtr CreateRoundRectRgn
         (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
         );
        //
        private void Button1_Click(object sender, EventArgs e)
        {
            if (txtadet.Text==string.Empty)
            {
                MessageBox.Show("Lütfen bir miktar giriniz.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //MessageBox.Show(ad.ToString());
                string[] arr = new string[9];
                ListViewItem itm;
                arr[0] = ad;
                arr[1] = marka;
                arr[2] = ustokCode;
                arr[3] = ubarcode;
                arr[4] = umiktar;
                arr[5] = txtadet.Text;
                arr[6] = uIskonto;
                arr[7] = ukdv;
                barkod(ubarcode);
                itm = new ListViewItem(arr);
                listView1.Items.Add(itm);
                this.Hide();
                txtadet.Text = "";
                ToplamAl();
                richTextBox1.Text = Sirad + " Şirketine" + Environment.NewLine + "Sayın " + MusAd + " " + MusSoad + Environment.NewLine + mAdres + Environment.NewLine + mIl + "/" + MIlce + Environment.NewLine + msTel + Environment.NewLine + mEposta;
            }
        }
        public void barkod(string kod)
        {
            Zen.Barcode.Code128BarcodeDraw brc = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
            pictureBox1.Image = brc.Draw(kod, 35);
        }

        string ad;
        string marka;
        string ustokCode;
        string ubarcode;
        string umiktar;
        string uIskonto;
        string ukdv;
        public void urunBilgileri(string urunad, string urunmarka, string stokCode, string barcode, string miktar, string Iskonto, string Kdv)
        {
            ad = urunad;
            marka = urunmarka;
            ustokCode = stokCode;
            ubarcode = barcode;
            umiktar = miktar;
            uIskonto = Iskonto;
            ukdv = Kdv;
        }

        string Sirad;
        string MusAd;
        string MusSoad;
        string msTel;
        string mIl;
        string MIlce;
        string mAdres;
        string mEposta;

        public void MusteriBilgileri(string sirketAd, string musAd, string musSoyad, string musTel, string Il, string Ilce, string Adres, string eposta)
        {
            Sirad = sirketAd;
            MusAd = musAd;
            MusSoad = musSoyad;
            msTel = musTel;
            mIl = Il;
            MIlce = Ilce;
            mAdres = Adres;
            mEposta = eposta;
        }

        DialogResult ask;
        private void Button2_Click(object sender, EventArgs e)
        {
            if(txtadet.Text==string.Empty)
            {
                ask = MessageBox.Show("Miktar sayısını onaylamadan çıkıyorsunuz ürün  sipariş listesine eklenmicektir.Çıkmak istediğinizden emin misiniz.", "Teyit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            else
            {
                ask = MessageBox.Show("Çıkmak İstediğinizden emin misiniz? Ürün eklenmicektir.", "Teyit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            if(ask==DialogResult.Yes)
            {
                this.Hide();
            }
        }

        private void ToplamAl()
        {
            decimal indirim = 0;
            decimal gTotal = 0;
            foreach (ListViewItem lvi in listView1.Items)
            {
                decimal tIskon = 0;
                decimal bFiyat = Convert.ToDecimal(lvi.SubItems[4].Text);
                decimal fiyat = Convert.ToDecimal(lvi.SubItems[5].Text) * Convert.ToDecimal(lvi.SubItems[4].Text);
                if (lvi.SubItems[6].Text != string.Empty)
                {
                    decimal tIskonto = Convert.ToDecimal(lvi.SubItems[4].Text) / 100 * Convert.ToDecimal(lvi.SubItems[6].Text) * Convert.ToDecimal(lvi.SubItems[5].Text);
                    tIskon += tIskonto;
                    indirim += tIskon;
                    gTotal += fiyat;
                    gTotal -= tIskon;
                    txtToplam.Text = gTotal.ToString("c");
                    txtIndirim.Text = indirim.ToString("c");
                }
                else
                {
                    gTotal += fiyat;
                    txtToplam.Text = gTotal.ToString("c");
                }
            }
        }

        private void BtnGizle_Click(object sender, EventArgs e)
        {
            this.Hide();
            panelSiparisForm.Visible = false;
        }

        private void BtnBaskiOnizleme_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void BtnSayfaAyarlari_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.ShowDialog();
        }

        private void BtnYazdir_Click(object sender, EventArgs e)
        {
            DialogResult pdr = printDialog1.ShowDialog();
            if (pdr == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void PrintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //Yazı fontumu ve çizgi çizmek için fırçamı ve kalem nesnemi oluşturdum
            Font myFont = new Font("Calibri", 28);
            Font adressFont = new Font("Arial", 10);
            SolidBrush sbrush = new SolidBrush(Color.Black);
            Pen myPen = new Pen(Color.Black);

            //logo için
            e.Graphics.DrawImage(Properties.Resources.logo, 120, 20);

            //Bu kısımda sipariş formu yazısını ve çizgileri yazdırıyorum
            e.Graphics.DrawLine(myPen, 120, 120, 750, 120);
            e.Graphics.DrawLine(myPen, 120, 180, 750, 180);
            e.Graphics.DrawString("SİPARİŞ LİSTESİ", myFont, sbrush, 120, 120);

            e.Graphics.DrawLine(myPen, 120, 400, 750, 400);
            // adres
            //e.Graphics.DrawString(richbox, adressFont, sbrush, 125, 185);
            //
            myFont = new Font("Calibri", 9, FontStyle.Bold);
            e.Graphics.DrawString("Ürün Markası", myFont, sbrush, 120, 408);
            e.Graphics.DrawString("Ürün Adı", myFont, sbrush, 205, 408);
            e.Graphics.DrawString("Stok Kodu", myFont, sbrush, 281, 408);
            e.Graphics.DrawString("İskonto", myFont, sbrush, 416, 408);
            e.Graphics.DrawString("KDV", myFont, sbrush, 497, 408);
            e.Graphics.DrawString("Miktar", myFont, sbrush, 540, 408);
            e.Graphics.DrawString("Birim Fiyatı", myFont, sbrush, 595, 408);
            e.Graphics.DrawString("Fiyat", myFont, sbrush, 695, 408);

            e.Graphics.DrawLine(myPen, 120, 428, 750, 428);

            int y = 450;

            StringFormat myStringFormat = new StringFormat
            {
                Alignment = StringAlignment.Far
            };

            decimal indirim = 0;
            decimal gTotal = 0;
            decimal tutar = 0;
            foreach (ListViewItem lvi in listView1.Items)
            {
                decimal tIskon = 0;
                //listview elmanları yazıyor ilk elmean
                e.Graphics.DrawString(lvi.SubItems[1].Text, myFont, sbrush, 160, y-20, myStringFormat);
                //ürün
                e.Graphics.DrawString(lvi.SubItems[0].Text, myFont, sbrush, 210, y-20);
                e.Graphics.DrawString(lvi.SubItems[2].Text, myFont, sbrush, 280, y-20);
                e.Graphics.DrawString(lvi.SubItems[6].Text, myFont, sbrush, 415, y-20);
                e.Graphics.DrawString(lvi.SubItems[7].Text, myFont, sbrush, 500, y-20);
                e.Graphics.DrawString(lvi.SubItems[5].Text, myFont, sbrush, 540, y-20);

                decimal bFiyat = Convert.ToDecimal(lvi.SubItems[4].Text);
                decimal fiyat = Convert.ToDecimal(lvi.SubItems[5].Text) * Convert.ToDecimal(lvi.SubItems[4].Text);
                if (lvi.SubItems[6].Text != string.Empty)
                {
                    decimal tIskonto = Convert.ToDecimal(lvi.SubItems[4].Text) / 100 * Convert.ToDecimal(lvi.SubItems[6].Text) * Convert.ToDecimal(lvi.SubItems[5].Text);
                    tIskon += tIskonto;
                    indirim += tIskon;
                    gTotal += fiyat;
                    tutar += fiyat;
                    gTotal -= tIskon;
                    txtToplam.Text = gTotal.ToString("c");
                }
                else
                {
                    tutar += fiyat;
                    gTotal += fiyat;
                    txtToplam.Text = gTotal.ToString("c");
                }
                e.Graphics.DrawString(bFiyat.ToString("c"), myFont, sbrush, 650, y-20, myStringFormat);
                e.Graphics.DrawString(fiyat.ToString("c"), myFont, sbrush, 750, y-20, myStringFormat);
                //aradaki boşluk
                y += 15;
            }
            string tarih = DateTime.Now.ToShortDateString();
            string teslim = DateTime.Now.AddDays(5).ToShortDateString();
            // "c" tl formatı için 
            e.Graphics.DrawLine(myPen, 120, y, 750, y);
            e.Graphics.DrawString("Sipariş Tarihi:", adressFont, sbrush, 565, 180);
            e.Graphics.DrawString(tarih, adressFont, sbrush, 660, 180);
            e.Graphics.DrawString("Teslim Tarihi:", adressFont, sbrush, 565, 200);
            e.Graphics.DrawString("NOT: Ürününüz belirtilen tarihler arasında gelmez ise iptal edebilir veya şikayet edebilirsiniz.", adressFont, sbrush, 120, y+208);
            e.Graphics.DrawString(teslim, adressFont, sbrush, 660, 200);
            e.Graphics.DrawString("Toplam:", myFont, sbrush, 620, y + 10, myStringFormat);
            e.Graphics.DrawString(tutar.ToString("c"), myFont, sbrush, 700, y + 10, myStringFormat);
            e.Graphics.DrawString("İndirim:", myFont, sbrush, 620, y + 25, myStringFormat);
            e.Graphics.DrawString(indirim.ToString("c"), myFont, sbrush, 700, y + 25, myStringFormat);
            e.Graphics.DrawString("Ödenecek:", myFont, sbrush, 620, y + 38, myStringFormat);
            e.Graphics.DrawString(gTotal.ToString("c"), myFont, sbrush, 700, y + 38, myStringFormat);
            e.Graphics.DrawString("SATIŞ SORUMLUSU", myFont, sbrush, 700, y + 60, myStringFormat);
            e.Graphics.DrawString("TESLİM ALAN", myFont, sbrush, 200, y + 60, myStringFormat);
            e.Graphics.DrawString("AD SOYAD", myFont, sbrush, 187, y + 80, myStringFormat);
            e.Graphics.DrawString("AD SOYAD", myFont, sbrush, 670, y + 80, myStringFormat);

            //adın uzunluguna göre x deki uzaklıgı ayarladım
            if (MusAd==null)
            {
                MessageBox.Show("Bir şirket seçmediniz.", "HATA",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                if (MusAd.Length < 5)
                {
                    e.Graphics.DrawString(MusAd + " " + MusSoad, myFont, sbrush, 180, y + 105, myStringFormat);
                }
                else if (MusAd.Length == 5)
                {
                    e.Graphics.DrawString(MusAd + " " + MusSoad, myFont, sbrush, 200, y + 105, myStringFormat);
                }
                else
                {
                    e.Graphics.DrawString(MusAd + " " + MusSoad, myFont, sbrush, 210, y + 105, myStringFormat);
                }
            }
            //imza için
            e.Graphics.DrawImage(Properties.Resources.imza, 550, y + 95);
            //dikey çizgiler
            e.Graphics.DrawLine(myPen, 120, 120, 120, y + 225);
            e.Graphics.DrawLine(myPen, 750, 120, 750, y + 225);
            e.Graphics.DrawLine(myPen, 120, y + 225, 750, y + 225);
            // barcode çizdirme
            Bitmap bm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.DrawToBitmap(bm, new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height));
            e.Graphics.DrawImage(bm, 560, 50);
            bm.Dispose();


            //adres yazdırma
            e.Graphics.DrawLine(myPen, 120, 290, 320, 290);
            e.Graphics.DrawString(richTextBox1.Text, adressFont, sbrush, 120, 295);
            e.Graphics.DrawString("ÖRNEK ŞİRKET PAZ. VE İMAL VE ÜRETİM SAN. TİC LTD"+Environment.NewLine+"Merkez mah. Şehit  Necmettin Sok. NO:157"+Environment.NewLine+"Gaziosmanpaşa/İSTANBUL"+Environment.NewLine+"0212 497 0000"+Environment.NewLine+"www.örenksite.com"+Environment.NewLine+"VKN:2530696987", adressFont, sbrush, 120, 190);
        }

        private void MesajForm_Load(object sender, EventArgs e)
        {
            ToplamAl();
           
        }

        private void Txtadet_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Sadece Sayı Girdirme
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            // boşluk engellem
            if ((int)e.KeyChar == 32)
            {
                e.Handled = true;
            }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            // silme işelmini yap
            listView1.SelectedItems[0].Remove();
            MessageBox.Show("Ürün silinmiştir", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ToplamAl();
        }

        private void ListView1_MouseClick(object sender, MouseEventArgs e)
        {
            listView1.Focus();
        }
    }
}
