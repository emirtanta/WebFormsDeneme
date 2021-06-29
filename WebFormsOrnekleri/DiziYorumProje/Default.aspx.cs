using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DiziYorumProje.Entity;

namespace DiziYorumProje
{
    public partial class Default : System.Web.UI.Page
    {
        BlogDiziEntities db = new BlogDiziEntities();

        protected void Page_Load(object sender, EventArgs e)
        {
            //Bloglar tablosundaki verileri listeler
            var bloglar = db.TBL_Blog.ToList();

            Repeater1.DataSource = bloglar;
            Repeater1.DataBind();

            //Kategoriler tablosundan kategorileri listeleme
            var bloglar2 = db.TBL_Kategori.ToList();

            Repeater2.DataSource = bloglar2;
            Repeater2.DataBind();

            //Bloglar tablosundan son 5 bloğu listeleme
            var bloglar3 = db.TBL_Blog.Take(5).ToList();

            Repeater3.DataSource = bloglar3;
            Repeater3.DataBind();

            //son 3 yorumu listeler
            var bloglar4 = db.TBL_Yorum.Take(3).ToList();
            Repeater4.DataSource = bloglar4;
            Repeater4.DataBind();
        }
    }
}