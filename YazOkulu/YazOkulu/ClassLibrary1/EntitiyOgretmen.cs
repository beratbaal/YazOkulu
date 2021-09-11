using System;
using System.Collections.Generic;
using System.Text;

namespace EntitiyLayer
{
    class EntitiyOgretmen
    {
        private int ogrtid;
        private string ogrtad;
        private string ogrtbrans;

        public int OGRTID { get => ogrtid; set => ogrtid = value; }
        public string OGRTAD { get => ogrtad; set => ogrtad = value; }
        public string OGRTBRANS { get => ogrtbrans; set => ogrtbrans = value; }
    }
}
