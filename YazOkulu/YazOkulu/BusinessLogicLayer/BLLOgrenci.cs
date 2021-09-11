using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using EntitiyLayer;
using DataAccessLayer;

namespace BusinessLogicLayer
{
   public class BLLOgrenci
    {
        public static int OgrenciEkleBLL(EntitiyOgrenci p)
        {
            if(p.AD!=null && p.SOYAD!=null && p.NUMARA!=null && p.SIFRE!=null && p.FOTOGRAF!=null){
                return DALOgrenci.OgrenciEkle(p);
            }
            return -1; 
        }
        public static List<EntitiyOgrenci> BllListele()
        {
            return DALOgrenci.OgrenciListesi();
        }
        public static bool OgrenciSİlBLL(int p)
        {
            if(p != null)
            {
                return DALOgrenci.OgrenciSil(p);
            }
            return false;
        }
        public static List<EntitiyOgrenci> BllDetay(int p)
        {
            return DALOgrenci.OgrenciDetay(p);
        }
        public static bool OgrenciGuncelleBll(EntitiyOgrenci p)
        {
            if (p.AD != null && p.SOYAD != null && p.NUMARA != null && p.SIFRE != null && p.FOTOGRAF != null && p.ID>0)
            {
                return DALOgrenci.OgrenciGuncelle(p);
            }
            return false;
        }
    }
}
