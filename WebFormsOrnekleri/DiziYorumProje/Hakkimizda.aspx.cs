using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DiziYorumProje.Entity;

namespace DiziYorumProje
{
    public partial class Hakkimizda : System.Web.UI.Page
    {
        BlogDiziEntities db = new BlogDiziEntities();

        //hakkımızda sayfası
        protected void Page_Load(object sender, EventArgs e)
        {
            Repeater1.DataSource = db.TBL_Hakkimizda.ToList();
            Repeater1.DataBind();
        }
    }
}