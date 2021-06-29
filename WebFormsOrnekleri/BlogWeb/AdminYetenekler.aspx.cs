using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb
{
    public partial class AdminYetenekler : System.Web.UI.Page
    {
        //Yetenek listesi sayfası
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSetTableAdapters.TBL_YeteneklerTableAdapter dt = new DataSetTableAdapters.TBL_YeteneklerTableAdapter();

            Repeater1.DataSource = dt.YetenekListesi();
            Repeater1.DataBind();
        }
    }
}