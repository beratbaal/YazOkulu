using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using EntitiyLayer;

namespace DataAccessLayer
{
    public class DALDersler
    {
        public static List<EntitiyDers> DersListesi()
        {
            List<EntitiyDers> degerler = new List<EntitiyDers>();
            SqlCommand komut = new SqlCommand("Select * From tbl_dersler", Connection.bgl);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                EntitiyDers ent = new EntitiyDers();
                ent.ID = Convert.ToInt32(oku["DERSID"].ToString());
                ent.DERSAD = oku["DERSID"].ToString();
                ent.MIN = Convert.ToInt32(oku["DERSMINKONT"].ToString());
             //   ent.MAX = Convert.ToInt32(oku["DERSMAXKONT"].ToString());
                degerler.Add(ent);

            }
            oku.Close();
            return degerler;
        }
    }
}
