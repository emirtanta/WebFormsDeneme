using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DiziYorumProje.Entity;


namespace DiziYorumProje.AdminSayfalar
{
    public partial class YeniBloglar : System.Web.UI.Page
    {
        BlogDiziEntities db = new BlogDiziEntities();

        //blog ekle sayfası yüklendiğinde
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack==false)
            {
                //tür dropdownlistine veri getirme
                var turler = (from x in db.TBL_Tur
                              select new
                              {
                                  x.TURAD,
                                  x.TURID
                              }).ToList();

                drpTur.DataSource = turler;
                drpTur.DataBind();

                //kategori dropdownlistine veri getirme
                var kategoriler = (from x in db.TBL_Kategori
                                   select new
                                   {
                                       x.KATEGORIAD,
                                       x.KATEGORIID
                                   }).ToList();

                drpKategori.DataSource = kategoriler;
                drpKategori.DataBind();
            }

            
        }

        //Blog Ekle butonu
        protected void btnEkle_Click(object sender, EventArgs e)
        {
            TBL_Blog t = new TBL_Blog();
            t.BLOGBASLIK = txtBaslik.Text;
            t.BLOGGORSEL = txtGorsel.Text;
            t.BLOGICERIK = txtIcerik.Text;
            t.BLOGTARIH = DateTime.Parse(txtTarih.Text);
            t.BLOGKATEGORI =byte.Parse(drpKategori.SelectedValue);
            t.BLOGTUR =byte.Parse(drpTur.SelectedValue);

            db.TBL_Blog.Add(t);

            db.SaveChanges();

            Response.Redirect("Bloglar.Aspx");
        }
    }
}