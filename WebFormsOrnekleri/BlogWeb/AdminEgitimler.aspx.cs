using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb
{
    public partial class AdminEgitimler : System.Web.UI.Page
    {
        //Eğitim listesi bölümü
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSetTableAdapters.TBL_EgitimTableAdapter dt = new DataSetTableAdapters.TBL_EgitimTableAdapter();

            Repeater1.DataSource = dt.EgitimListesi();
            Repeater1.DataBind();
        }
    }
}