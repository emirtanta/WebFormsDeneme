using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DiziYorumProje.Entity;

namespace DiziYorumProje
{
    public partial class BlogDetay : System.Web.UI.Page
    {
        BlogDiziEntities db = new BlogDiziEntities();

        //Blog Detay sayfası
        protected void Page_Load(object sender, EventArgs e)
        {
            //diğer formdan gelen BLOGID değerini tututk
            int id = Convert.ToInt32(Request.QueryString["BLOGID"]);

            var blog = db.TBL_Blog.Where(x => x.BLOGID == id).ToList();

            Repeater1.DataSource = blog;
            Repeater1.DataBind();

            //diziye yapılan yorumları listeler
            var yorumlar = db.TBL_Yorum.Where(x => x.YORUMBLOG == id).ToList();
            Repeater2.DataSource = yorumlar;
            Repeater2.DataBind();
        }

        //yorum yap butonu
        protected void btnYorumYap_Click(object sender, EventArgs e)
        {
            //diğer formdan gelen BLOGID değerini tututk
            int id = Convert.ToInt32(Request.QueryString["BLOGID"]);

            TBL_Yorum t = new TBL_Yorum();
            t.KULLANICIAD = txtKullaniciAd.Text;
            t.MAIL = txtMail.Text;
            t.YORUMICERIK = txtAciklama.Text;
            t.YORUMBLOG = id;

            db.TBL_Yorum.Add(t);

            db.SaveChanges();

            Response.Redirect("BlogDetay.Aspx?BLOGID="+id);
            
        }
    }
}