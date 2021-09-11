using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntitiyLayer;
using DataAccessLayer;
using BusinessLogicLayer;

namespace YazOkulu
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Request.QueryString["OGRID"]);
            Response.Write(x);
            EntitiyOgrenci ent = new EntitiyOgrenci();
            ent.ID = x;
            BLLOgrenci.OgrenciSİlBLL(ent.ID);
            Response.Redirect("Ogrenci.Aspx");
        }
    }
}