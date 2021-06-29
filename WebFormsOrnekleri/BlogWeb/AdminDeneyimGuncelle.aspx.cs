using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb
{
    public partial class AdminDeneyimGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(Request.QueryString["ID"]);

            TxtId.Text = id.ToString();

            if (Page.IsPostBack==false)
            {
                //tablodaki kolonları getirir
                DataSetTableAdapters.TBL_DeneyimTableAdapter dt = new DataSetTableAdapters.TBL_DeneyimTableAdapter();
                TxtBaslik.Text = dt.DeneyimGetir(Convert.ToInt16(id))[0].BASLIK;
                TxtAltBaslik.Text = dt.DeneyimGetir(Convert.ToInt16(id))[0].ALTBASLIK;
                TxtAciklama.Text = dt.DeneyimGetir(Convert.ToInt16(id))[0].ACIKLAMA;
                TxtTarih.Text = dt.DeneyimGetir(Convert.ToInt16(id))[0].TARIH;
            }

            
        }

        //güncelle butonu bölümü
        protected void btnGuncelle_Click(object sender, EventArgs e)
        {
            DataSetTableAdapters.TBL_DeneyimTableAdapter dt = new DataSetTableAdapters.TBL_DeneyimTableAdapter();

            dt.DeneyimGuncelle(TxtBaslik.Text, TxtAltBaslik.Text, TxtAciklama.Text, TxtTarih.Text, Convert.ToInt16(TxtId.Text));

            Response.Redirect("AdminDeneyimler.Aspx");
        }
    }
}