using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace SiparisFormu
{
    class CsUrunLer
    {
        DataBase dataBase = new DataBase();
        public DataTable tablola()
        {
            if(dataBase.sqlConnection.State==ConnectionState.Open)
            {
                dataBase.sqlConnection.Close();
            }
            try
            {
                dataBase.sqlConnection.Open();
                SqlCommand VeriAl = new SqlCommand("select *from urunler", dataBase.sqlConnection);
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
        public void UrunGuncelle(int id,string StokKod,string UrunAd,string BarkodKod,string Birim,string stokMiktar,string BirimFiyat,string Iskonto,string KDV,string marka)
        {
            if(dataBase.sqlConnection.State==ConnectionState.Open)
            {
                dataBase.sqlConnection.Close();
            }
            try
            {
                dataBase.sqlConnection.Open();
                SqlCommand guncelle = new SqlCommand("update urunler set StokKodu=@StokKodu,Cinsi=@Cinsi,BarkodNo=@BarkodNo,Birim=@Birim,StokMiktar=@StokMiktar,BirimFiyat=@BirimFiyat,IskontoOrani=@IskontoOrani,KDVOrani=@KDVOrani,Marka=@Marka where id=@id", dataBase.sqlConnection);
                guncelle.Parameters.AddWithValue("@StokKodu", StokKod);
                guncelle.Parameters.AddWithValue("@Cinsi", UrunAd);
                guncelle.Parameters.AddWithValue("@BarkodNo", BarkodKod);
                guncelle.Parameters.AddWithValue("@Birim", Birim);
                guncelle.Parameters.AddWithValue("@StokMiktar", stokMiktar);
                guncelle.Parameters.AddWithValue("@BirimFiyat", BirimFiyat);
                guncelle.Parameters.AddWithValue("@IskontoOrani", Iskonto);
                guncelle.Parameters.AddWithValue("@KDVOrani", KDV);
                guncelle.Parameters.AddWithValue("@Marka", marka);
                guncelle.Parameters.AddWithValue("@id", id);
                guncelle.ExecuteNonQuery();
            }
            catch {}
            finally
            {
                dataBase.sqlConnection.Close();
            }
        }
        public void UrunSil(int id)
        {
            if(dataBase.sqlConnection.State==ConnectionState.Open)
            {
                dataBase.sqlConnection.Close();
            }
            try
            {
                dataBase.sqlConnection.Open();
                SqlCommand sil = new SqlCommand("delete urunler where id=@id", dataBase.sqlConnection);
                sil.Parameters.AddWithValue("@id", id);
                sil.ExecuteNonQuery();
            }
            catch { }
            finally
            {
                dataBase.sqlConnection.Close();
            }
        }

        public DataTable UrunAra(string Urunad)
        {
            bildirimFrm bil = new bildirimFrm();
            if (dataBase.sqlConnection.State == ConnectionState.Open)
            {
                dataBase.sqlConnection.Close();
            }
            try
            {
                dataBase.sqlConnection.Open();
                // 4 koloma göre arama yapılıyor
                SqlCommand ara = new SqlCommand("select *from urunler where Cinsi LIKE '%'+@Cinsi+'%' OR BarkodNo LIKE '%'+@Cinsi+'%' OR StokKodu LIKE '%'+@Cinsi+'%' OR Marka LIKE '%'+@Cinsi+'%' ", dataBase.sqlConnection);
                ara.Parameters.AddWithValue("@Cinsi", Urunad);
                SqlDataAdapter adabtor = new SqlDataAdapter(ara);
                DataTable tablo = new DataTable();
                adabtor.Fill(tablo);
                bil.stext(Urunad + " bilgileri getirilmiştir");
                bil.Show();
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
