using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DiziYorumProje.Entity;

namespace DiziYorumProje.AdminSayfalar
{
    public partial class YeniRoller : System.Web.UI.Page
    {
        BlogDiziEntities db = new BlogDiziEntities();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //Rol Ekle butonu
        protected void btnEkle_Click(object sender, EventArgs e)
        {
            TBL_Roller roller = new TBL_Roller();
            roller.ROLAD = txtRolAd.Text;

            db.TBL_Roller.Add(roller);

            db.SaveChanges();

            Response.Redirect("Roller.Aspx");

        }
    }
}