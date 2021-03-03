using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SiparisFormu
{
    class CsMusteriler
    {
        DataBase dataBase = new DataBase();
        public DataTable tablola()
        {
            if (dataBase.sqlConnection.State == ConnectionState.Open)
            {
                dataBase.sqlConnection.Close();
            }

            try
            {
                dataBase.sqlConnection.Open();
                SqlCommand VeriAl = new SqlCommand("select *from Musteriler", dataBase.sqlConnection);
                SqlDataAdapter adabtor = new SqlDataAdapter(VeriAl);
                DataTable tablo = new DataTable();
                adabtor.Fill(tablo);
                return tablo;
            }

            catch { return null; }

            finally
            {
                dataBase.sqlConnection.Close();
            }
        }
        public void MusteriGuncelle(int id, string Sirketad, string mIsim, string mSoyisim, string mAdres, string Il, string Ilce, string Tel, string Eposta)
        {
            if (dataBase.sqlConnection.State == ConnectionState.Open)
            {
                dataBase.sqlConnection.Close();
            }
            try
            {
                dataBase.sqlConnection.Open();
                SqlCommand guncelle = new SqlCommand("update Musteriler set SirketAd=@SirketAd,mAdres=@mAdres,AdSoyad=@AdSoyad,SehirIlce=@SehirIlce,Tel=@Tel,Eposta=@Eposta,Soyisim=@Soyisim,IL=@IL where id=@id", dataBase.sqlConnection);
                guncelle.Parameters.AddWithValue("@SirketAd", Sirketad);
                guncelle.Parameters.AddWithValue("@mAdres", mAdres);
                guncelle.Parameters.AddWithValue("@AdSoyad", mIsim);
                guncelle.Parameters.AddWithValue("@SehirIlce", Ilce);
                guncelle.Parameters.AddWithValue("@Tel", Tel);
                guncelle.Parameters.AddWithValue("@Eposta", Eposta);
                guncelle.Parameters.AddWithValue("@Soyisim", mSoyisim);
                guncelle.Parameters.AddWithValue("@IL", Il);
                guncelle.Parameters.AddWithValue("@id", id);
                guncelle.ExecuteNonQuery();
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
        public void MusteriSil(int id)
        {
            if (dataBase.sqlConnection.State == ConnectionState.Open)
            {
                dataBase.sqlConnection.Close();
            }
            try
            {
                dataBase.sqlConnection.Open();
                SqlCommand sil = new SqlCommand("delete Musteriler where id=@id", dataBase.sqlConnection);
                sil.Parameters.AddWithValue("@id", id);
                sil.ExecuteNonQuery();
                sil.Dispose();
            }
            catch { }
            finally
            {
                dataBase.sqlConnection.Close();
            }
        }
        public DataTable MusteriAra(string aranacak)
        {
            if (dataBase.sqlConnection.State == ConnectionState.Open)
            {
                dataBase.sqlConnection.Close();
            }
            try
            {
                dataBase.sqlConnection.Open();
                // 4 koloma göre arama yapılıyor
                SqlCommand ara = new SqlCommand("select *from Musteriler where SirketAd LIKE '%'+@Cinsi+'%' OR AdSoyad LIKE '%'+@Cinsi+'%' OR Eposta LIKE '%'+@Cinsi+'%' OR Soyisim LIKE '%'+@Cinsi+'%' ", dataBase.sqlConnection);
                ara.Parameters.AddWithValue("@Cinsi", aranacak);
                SqlDataAdapter adabtor = new SqlDataAdapter(ara);
                DataTable tablo = new DataTable();
                adabtor.Fill(tablo);
                return tablo;
            }
            catch { return null; }
            finally
            {
                dataBase.sqlConnection.Close();
            }
        }
    }
}
