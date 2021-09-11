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
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int x =Convert.ToInt32(Request.QueryString["OGRID"].ToString());
            TxtId.Text = x.ToString();
            TxtId.Enabled = false;

            if(Page.IsPostBack == false)
            {
                List<EntitiyOgrenci> OgrList = BLLOgrenci.BllDetay(x);
                TxtAd.Text = OgrList[0].AD.ToString();
                TxtSoyad.Text = OgrList[0].SOYAD.ToString();
                TxtNumara.Text = OgrList[0].NUMARA.ToString();
                TxtSifre.Text = OgrList[0].SIFRE.ToString();
                TxtFotograf.Text = OgrList[0].FOTOGRAF.ToString();
            }

        }

        protected void BtnGuncelle_Click(object sender, EventArgs e)
        {
            EntitiyOgrenci ent = new EntitiyOgrenci();
            ent.AD = TxtAd.Text;
            ent.SOYAD = TxtSoyad.Text;
            ent.NUMARA = TxtNumara.Text;
            ent.SIFRE = TxtSifre.Text;
            ent.FOTOGRAF = TxtFotograf.Text;
            ent.ID = Convert.ToInt32(TxtId.Text);
            BLLOgrenci.OgrenciGuncelleBll(ent);
            Response.Redirect("OgrenciListesi.Aspx");
        }
    }
}