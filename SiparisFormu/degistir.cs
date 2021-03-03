using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace SiparisFormu
{
    class degistir
    {
        List<string> vs = new List<string>();
        List<string> barvs = new List<string>();
        public string kontrol(string sayi,string secim)
        {

            DataBase dataBase = new DataBase();
            try
            {
                Rnd uret = new Rnd();
                if (secim== "StokKodu")
                {
                    if (dataBase.sqlConnection.State == ConnectionState.Open)
                    {
                        dataBase.sqlConnection.Close();
                    }

                    dataBase.sqlConnection.Open();
                    SqlCommand sırala = new SqlCommand("SELECT * from urunler ORDER BY StokKodu asc", dataBase.sqlConnection);
                    SqlDataReader oku = sırala.ExecuteReader();

                    while (oku.Read())
                    {
                        vs.Add(oku["StokKodu"].ToString());
                    }
                    dataBase.sqlConnection.Close();
                    oku.Close();
                    sırala.Dispose();

                    foreach (var item in vs)
                    {
                        if (sayi == item)
                        {
                            sayi = uret.sayi(0, 9, 16).ToString();
                        }
                    } 
                }
                if(secim== "BarkodNo")
                {
                    if (dataBase.sqlConnection.State == ConnectionState.Open)
                    {
                        dataBase.sqlConnection.Close();
                    }
                    dataBase.sqlConnection.Open();
                    SqlCommand barsırala = new SqlCommand("SELECT * from urunler ORDER BY StokKodu asc", dataBase.sqlConnection);
                    SqlDataReader baroku = barsırala.ExecuteReader();
                    while (baroku.Read())
                    {
                        barvs.Add(baroku["StokKodu"].ToString());
                    }
                    dataBase.sqlConnection.Close();
                    baroku.Close();
                    barsırala.Dispose();
                    foreach (var item in barvs)
                    {
                        if (sayi == item)
                        {
                            sayi = uret.sayi(0, 9, 12).ToString();
                        }
                    } 
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
            return sayi;
        }

    }
}
