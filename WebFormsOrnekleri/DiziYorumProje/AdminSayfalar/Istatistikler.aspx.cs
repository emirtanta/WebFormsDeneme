using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DiziYorumProje.Entity;

namespace DiziYorumProje.AdminSayfalar
{
    public partial class Istatistikler : System.Web.UI.Page
    {
        BlogDiziEntities db = new BlogDiziEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            //toplam blog sayısı
            Label1.Text = db.TBL_Blog.Count().ToString();

            //toplam yorum sayısı
            Label2.Text = db.TBL_Yorum.Count().ToString();

            //toplam film sayısı
            Label3.Text = db.TBL_Blog.Where(x => x.BLOGTUR == 2).Count().ToString();

            //toplam dizi sayısı
            Label4.Text = db.TBL_Blog.Where(x => x.TBL_Tur.TURAD == "Dizi").Count().ToString();

            //toplam animasyon film sayısı
            Label5.Text = db.TBL_Blog.Where(x => x.TBL_Tur.TURAD == "Animasyon").Count().ToString();

            //en fazla yorum yapılan blog. Key komutu gruplandırma için gerekli olan blog değerlerini gösterir
            Label6.Text = db.TBL_Blog.Where(y=>y.BLOGID==(db.TBL_Yorum.GroupBy(x => x.YORUMBLOG).OrderByDescending(x => x.Count()).Select(z => z.Key).FirstOrDefault())).Select(k=>k.BLOGBASLIK).FirstOrDefault();
        }
    }
}