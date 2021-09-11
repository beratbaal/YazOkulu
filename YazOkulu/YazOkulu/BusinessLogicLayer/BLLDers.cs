using System;
using System.Collections.Generic;
using System.Text;
using EntitiyLayer;
using DataAccessLayer;

namespace BusinessLogicLayer
{
  public class BLLDers
    {
        public static List<EntitiyDers> BllListele()
        {   
            return DALDersler.DersListesi();
        }
    }
}
