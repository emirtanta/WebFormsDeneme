using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb
{
    public partial class AdminEgitimGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(Request.QueryString["ID"]);

            txtId.Text = id.ToString();

            if (Page.IsPostBack == false)
            {
                //tablodaki kolonları getirir
                DataSetTableAdapters.TBL_EgitimTableAdapter dt = new DataSetTableAdapters.TBL_EgitimTableAdapter();
                txtBaslik.Text = dt.EgitimGetir(Convert.ToInt16(id))[0].BASLIK;
                txtAltBaslik.Text = dt.EgitimGetir(Convert.ToInt16(id))[0].ALTBASLIK;
                txtAciklama.Text = dt.EgitimGetir(Convert.ToInt16(id))[0].ACIKLAMA;
                txtGenelNot.Text = dt.EgitimGetir(Convert.ToInt16(id))[0].GNOT;
                txtTarih.Text = dt.EgitimGetir(Convert.ToInt16(id))[0].TARIH;
            }
        }

        //güncelle butonu bölümü
        protected void btnGuncelle_Click(object sender, EventArgs e)
        {
            DataSetTableAdapters.TBL_EgitimTableAdapter dt = new DataSetTableAdapters.TBL_EgitimTableAdapter();

            dt.EgitimGuncelle(txtBaslik.Text, txtAltBaslik.Text, txtAciklama.Text,txtGenelNot.Text, txtTarih.Text, Convert.ToInt16(txtId.Text));

            Response.Redirect("AdminEgitimler.Aspx");
        }
    }
}