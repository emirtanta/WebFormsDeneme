using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb
{
    public partial class AdminDeneyimler : System.Web.UI.Page
    {
        //Deneyim Listesi bölümü
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSetTableAdapters.TBL_DeneyimTableAdapter dt = new DataSetTableAdapters.TBL_DeneyimTableAdapter();

            Repeater1.DataSource = dt.DeneyimListesi();
            Repeater1.DataBind();
        }
    }
}