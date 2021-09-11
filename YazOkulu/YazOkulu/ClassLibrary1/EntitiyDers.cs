using System;
using System.Collections.Generic;
using System.Text;

namespace EntitiyLayer
{
    public class EntitiyDers
    {
        private string dersAd;
        private int min;
        private int max;
        private int id;

        public string DERSAD { get => dersAd; set => dersAd = value; }
        public int MIN { get => min; set => min = value; }
        public int MAX { get => max; set => max = value; }
        public int ID { get => id; set => id = value; }
    }
}
