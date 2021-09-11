using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using EntitiyLayer;

namespace DataAccessLayer
{
   public class DALOgrenci
    {
        public static int OgrenciEkle(EntitiyOgrenci parametre) {
            SqlCommand komut1 = new SqlCommand("insert into tbl_ogrenciler  (OGRAD,OGRSOYAD,OGRNO,OGRFOTOGRAF,OGRSIFRE,OGRBAKIYE) values (@p1,@p2,@p3,@p4,@p5,@p6)",Connection.bgl);
            if(komut1.Connection.State != ConnectionState.Open)
            {
                komut1.Connection.Open();
            }
            komut1.Parameters.AddWithValue("@p1", parametre.AD);        
            komut1.Parameters.AddWithValue("@p2", parametre.SOYAD);
            komut1.Parameters.AddWithValue("@p3", parametre.NUMARA);
            komut1.Parameters.AddWithValue("@p4", parametre.FOTOGRAF);
            komut1.Parameters.AddWithValue("@p5", parametre.SIFRE);
            komut1.Parameters.AddWithValue("@p6", parametre.BAKIYE);
            return komut1.ExecuteNonQuery();
    }
        public static List<EntitiyOgrenci> OgrenciListesi()
        {
            List<EntitiyOgrenci> degerler = new List<EntitiyOgrenci>();
            SqlCommand komut2 = new SqlCommand("Select * From tbl_ogrenciler", Connection.bgl);
            if (komut2.Connection.State != ConnectionState.Open)
            {
                komut2.Connection.Open();
            }
            SqlDataReader oku = komut2.ExecuteReader();
            while (oku.Read())
            {
                EntitiyOgrenci ent = new EntitiyOgrenci();
                ent.ID = Convert.ToInt32(oku["OGRID"].ToString());
                ent.AD = oku["OGRAD"].ToString();
                ent.SOYAD = oku["OGRSOYAD"].ToString();
                //ent.NUMARA = oku["OGRNUMARA"].ToString();
                //ent.FOTOGRAF = oku["OGRFOTOGRAF"].ToString();
                ent.SIFRE = oku["OGRSIFRE"].ToString();
                ent.BAKIYE = Convert.ToDouble(oku["OGRBAKIYE"].ToString());
                degerler.Add(ent);      
                    
            }
            oku.Close();
            return degerler;
        }
        public static bool OgrenciSil(int parametre)
        {
            SqlCommand komut3 = new SqlCommand("Delete From tbl_ogrenciler where OGRID=@p1", Connection.bgl);
            if (komut3.Connection.State != ConnectionState.Open)
            {
                komut3.Connection.Open();
            }
            komut3.Parameters.AddWithValue("@p1", parametre);
            return komut3.ExecuteNonQuery() > 0;
        }
        public static List<EntitiyOgrenci> OgrenciDetay(int id)
        {
            List<EntitiyOgrenci> degerler = new List<EntitiyOgrenci>();
            SqlCommand komut4 = new SqlCommand("Select * From tbl_ogrenciler Where OGRID=@p1", Connection.bgl);
            komut4.Parameters.AddWithValue("p1", id);
            if (komut4.Connection.State != ConnectionState.Open)
            {
                komut4.Connection.Open();
            } 
            SqlDataReader oku = komut4.ExecuteReader();
            while (oku.Read())
            {
                EntitiyOgrenci ent = new EntitiyOgrenci();
               
                ent.AD = oku["OGRAD"].ToString();
                ent.SOYAD = oku["OGRSOYAD"].ToString();
                //ent.NUMARA = oku["OGRNUMARA"].ToString();
                //ent.FOTOGRAF = oku["OGRFOTOGRAF"].ToString();
                ent.SIFRE = oku["OGRSIFRE"].ToString();
                ent.BAKIYE = Convert.ToDouble(oku["OGRBAKIYE"].ToString());
                degerler.Add(ent);

            }
            oku.Close();
            return degerler;
        }
        public static bool OgrenciGuncelle(EntitiyOgrenci deger)
        {
            SqlCommand komut5 = new SqlCommand("Update tbl_ogrenciler set OGRAD=@p1, OGRSOYAD=@p2, OGRNUMARA=@p3, OGRFOTOGRAF=@P4, OGRSIFRE=@p5 WHERE OGRDID=@p6", Connection.bgl);
            komut5.Parameters.AddWithValue("@p1", deger.AD);
            komut5.Parameters.AddWithValue("@p2", deger.SOYAD);
            komut5.Parameters.AddWithValue("@p3", deger.NUMARA);
            komut5.Parameters.AddWithValue("@p4", deger.FOTOGRAF);
            komut5.Parameters.AddWithValue("@p5", deger.SIFRE);
            komut5.Parameters.AddWithValue("@p6", deger.ID);
            if (komut5.Connection.State != ConnectionState.Open)
            {
                komut5.Connection.Open();
            }
            return komut5.ExecuteNonQuery() > 0; 


        }
    }

}
