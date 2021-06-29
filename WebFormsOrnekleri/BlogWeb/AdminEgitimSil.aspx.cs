using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb
{
    public partial class AdminEgitimSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //diğer formdan id değerini taşımaya yarar
            int id = Convert.ToInt16(Request.QueryString["ID"]);

            DataSetTableAdapters.TBL_EgitimTableAdapter dt = new DataSetTableAdapters.TBL_EgitimTableAdapter();

            dt.EgitimSil(Convert.ToInt16(id));

            Response.Redirect("AdminEgitimler.Aspx");
        }
    }
}