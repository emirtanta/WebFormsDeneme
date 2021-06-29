using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DiziYorumProje.Entity;

namespace DiziYorumProje.AdminSayfalar
{
    public partial class BlogGuncelle : System.Web.UI.Page
    {
        BlogDiziEntities db = new BlogDiziEntities();

        protected void Page_Load(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["BLOGID"]);

            if (Page.IsPostBack == false)
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

                var deger = db.TBL_Blog.Find(id);
                txtBaslik.Text = deger.BLOGBASLIK;
                txtIcerik.Text = deger.BLOGICERIK;
                txtTarih.Text = deger.BLOGTARIH.ToString();
                txtGorsel.Text = deger.BLOGGORSEL;

                //dropdownlist içerisine güncellenecek data'nın verilerini getirdi
                drpTur.SelectedValue = deger.BLOGTUR.ToString();
                drpKategori.SelectedValue = deger.BLOGKATEGORI.ToString();
            }
        }

        //Blog güncelleme butonu
        protected void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["BLOGID"]);
            var blog = db.TBL_Blog.Find(id);

            blog.BLOGBASLIK = txtBaslik.Text;
            blog.BLOGTARIH =DateTime.Parse(txtTarih.Text);
            blog.BLOGGORSEL = txtGorsel.Text;
            blog.BLOGICERIK = txtIcerik.Text;
            blog.BLOGTUR = byte.Parse(drpTur.SelectedValue);
            blog.BLOGKATEGORI = byte.Parse(drpKategori.SelectedValue);

            db.SaveChanges();

            Response.Redirect("Bloglar.Aspx");
        }
    }
}