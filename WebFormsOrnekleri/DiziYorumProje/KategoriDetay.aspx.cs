using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DiziYorumProje.Entity;

namespace DiziYorumProje
{
    public partial class KategoriDetay : System.Web.UI.Page
    {
        BlogDiziEntities db = new BlogDiziEntities();

        //kategori detay sayfası
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["KATEGORIID"]);

            //kategoriye ait blogları listeler
            var bloglar = db.TBL_Blog.Where(x=>x.BLOGKATEGORI==id).ToList();

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
        }
    }
}