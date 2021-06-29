using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DiziYorumProje.Entity;

namespace DiziYorumProje.AdminSayfalar
{
    public partial class Bloglar : System.Web.UI.Page
    {
        BlogDiziEntities db = new BlogDiziEntities();

        protected void Page_Load(object sender, EventArgs e)
        {
            //bloglar sayfasına erişimi girişe göre ayarlamak için Session kısmı oluşturuldu

            //kullanıcı giriş yapmazsa login sayfasına yönlendirdik
            if (Session["KULLANICI"]==null)
            {
                Response.Redirect("~/Login.Aspx");
            }

            //kullanıcı giriş yaptığında
            else
            {
                Response.Write("Hoşgeldiniz: " + Session["KULLANICI"].ToString());
            }

            Repeater1.DataSource = db.TBL_Blog.ToList();
            Repeater1.DataBind();
        }
    }
}