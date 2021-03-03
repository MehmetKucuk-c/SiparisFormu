using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SiparisFormu
{
    public partial class MusteriKayit : Form
    {
        public MusteriKayit()
        {
            InitializeComponent();
        }
        // form hareketi için
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                    {
                        m.Result = (IntPtr)0x2;
                    }

                    return;
            }
            base.WndProc(ref m);
        }

        private void BtnAnaSayfa_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnAnaSayfa.Height;
            SidePanel.Top = btnAnaSayfa.Top;
            anaEkranUserControl1.BringToFront();
        }

        private void BtnStok_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnStok.Height;
            SidePanel.Top = btnStok.Top;
            urunlerUserControl1.BringToFront();
        }

        private void ShutDown_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MusteriKayit_Load(object sender, EventArgs e)
        {
            SidePanel.Height = btnAnaSayfa.Height;
            SidePanel.Top = btnAnaSayfa.Top;
            anaEkranUserControl1.BringToFront();
            bildirimFrm msj = new bildirimFrm();
            msj.stext("Hoşgeldiniz, umrarım gününüz iyi geçer");
            msj.Show();
        }

        private void BtnNewPro_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnNewPro.Height;
            SidePanel.Top = btnNewPro.Top;
            urunEkleUserControl1.BringToFront();
        }

        private void BtnYeniSirket_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnYeniSirket.Height;
            SidePanel.Top = btnYeniSirket.Top;
            yeniSirketUserControl11.BringToFront();
        }

        private void BtnSirketDuzenle_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnSirketDuzenle.Height;
            SidePanel.Top = btnSirketDuzenle.Top;
            sirketleriDuzenleUserControl1.BringToFront();
        }

        private void BrnSitarisListe_Click(object sender, EventArgs e)
        {
            SidePanel.Height = brnSitarisListe.Height;
            SidePanel.Top = brnSitarisListe.Top;
            siparisUserControl1.BringToFront();
        }
    }
}
