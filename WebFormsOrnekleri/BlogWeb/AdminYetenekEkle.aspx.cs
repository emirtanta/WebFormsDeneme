using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb
{
    public partial class AdminYetenekEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnYetenekEkle_Click(object sender, EventArgs e)
        {
            DataSetTableAdapters.TBL_YeteneklerTableAdapter dt = new DataSetTableAdapters.TBL_YeteneklerTableAdapter();

            dt.YetenekEkle(txtYetenek.Text);

            Response.Redirect("AdminYetenekler.Aspx");
        }
    }
}