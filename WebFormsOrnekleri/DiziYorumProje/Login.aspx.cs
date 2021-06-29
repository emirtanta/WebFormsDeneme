using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DiziYorumProje.Entity;

namespace DiziYorumProje
{
    public partial class Login : System.Web.UI.Page
    {
        BlogDiziEntities db = new BlogDiziEntities();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //Giriş yap butonu
        protected void btnGirisYap_Click(object sender, EventArgs e)
        {
            var sorgu = from x in db.TBL_Admin
                        where x.KULLANICI == txtKullaniciAdi.Text && x.SIFRE == txtSifre.Text
                        select x;

            //kullanıcı giriş yaptığında
            if (sorgu.Any())
            {
                Session.Add("KULLANICI", txtKullaniciAdi.Text);

                Response.Redirect("/AdminSayfalar/Bloglar.Aspx");
            }

            else
            {
                Response.Write("Hata");
            }
        }
    }
}