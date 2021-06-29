using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DiziYorumProje.Entity;

namespace DiziYorumProje.AdminSayfalar
{
    public partial class YorumGuncelle : System.Web.UI.Page
    {
        BlogDiziEntities db = new BlogDiziEntities();

        protected void Page_Load(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["YORUMID"]);

            if (Page.IsPostBack == false)
            {
                

                var deger = db.TBL_Yorum.Find(id);
                txtBlogBaslik.Text = deger.TBL_Blog.BLOGBASLIK;
                txtKullaniciAdi.Text = deger.KULLANICIAD;
                txtYorumIcerik.Text = deger.YORUMICERIK;
                
            }
        }

        //Yorum Güncelle butonu
        protected void btnYorumGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["YORUMID"]);
            var yorum = db.TBL_Yorum.Find(id);

            yorum.KULLANICIAD = txtKullaniciAdi.Text;
            yorum.YORUMICERIK = txtYorumIcerik.Text;

            db.SaveChanges();

            Response.Redirect("Yorumlar.Aspx");
        }
    }
}