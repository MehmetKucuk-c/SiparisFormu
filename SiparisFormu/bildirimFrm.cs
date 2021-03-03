using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace SiparisFormu
{
    public partial class bildirimFrm : Form
    {
        public bildirimFrm()
        {
            InitializeComponent();
        }

        private void BildirimFrm_Load(object sender, EventArgs e)
        {
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            this.Top = Screen.PrimaryScreen.Bounds.Height - this.Height - 80;
            this.Left = Screen.PrimaryScreen.Bounds.Width - this.Width - 70;
            if (bildirim != string.Empty)
            {
                label1.Location = new Point(12, 9);
                label1.Text = bildirim;
                bildirim = "";
            }

            timer1.Start();
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

        string bildirim;

        public string stext (string bilgi)
        {
            bildirim = bilgi;
            return bildirim;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            //fade kapanıs
            if (this.Opacity > 0.0)
            {
                this.Opacity -= 0.03;

            }
            else
            {
                timer1.Stop();
                this.Close();
            }
        }
    }
}
