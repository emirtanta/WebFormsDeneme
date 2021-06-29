using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb
{
    public partial class AdminYetenekGuncelle : System.Web.UI.Page
    {
        //güncelleme sayfasına geldiğinde textboxlar içerisine verileri getirdik
        protected void Page_Load(object sender, EventArgs e)
        {
            

            int id = Convert.ToInt16(Request.QueryString["ID"]);

            txtId.Text = id.ToString();
            txtId.Enabled = false;

            if (Page.IsPostBack==false)
            {
                DataSetTableAdapters.TBL_YeteneklerTableAdapter dt = new DataSetTableAdapters.TBL_YeteneklerTableAdapter();
                txtYetenek.Text = dt.YetenekGetir(Convert.ToInt16(id))[0].YETENEK;
            }

            
        }

        //güncelle butonu
        protected void btnYetenekGuncelle_Click(object sender, EventArgs e)
        {
            DataSetTableAdapters.TBL_YeteneklerTableAdapter dt = new DataSetTableAdapters.TBL_YeteneklerTableAdapter();

            dt.YetenekGuncelle(txtYetenek.Text, Convert.ToInt16(txtId.Text));

            Response.Redirect("AdminYetenekler.Aspx");
        }
    }
}