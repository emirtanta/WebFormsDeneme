using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
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

        string password, kullanici;

        //Giriş yap butonu
        protected void btnGirisYap_Click(object sender, EventArgs e)
        {
            //var sorgu = from x in db.TBL_Admin
            //            where x.KULLANICI == txtKullaniciAdi.Text && x.SIFRE == txtSifre.Text
            //            select x;

            ////kullanıcı giriş yaptığında
            //if (sorgu.Any())
            //{
            //    Session.Add("KULLANICI", txtKullaniciAdi.Text);

            //    Response.Redirect("/AdminSayfalar/Bloglar.Aspx");
            //}

            //else
            //{
            //    Response.Write("Hata");
            //}



            if (ModelState.IsValid)
            {


                var f_password = GetMD5(password);
                var data = db.TBL_Admin.Where(s => s.KULLANICI.Equals(kullanici) && s.SIFRE.Equals(f_password)).ToList();
                if (data.Count() > 0)
                {
                    //add session
                    Session["KULLANICI"] = data.FirstOrDefault().KULLANICI;
                    //Session["idUser"] = data.FirstOrDefault().ID;

                    Response.Redirect("Hakkimizda.Aspx");
                }
                else
                {
                    //ViewBag.error = "Login failed";
                    Response.Redirect("Login.Aspx");
                }
            }
            
        }

        public static string GetMD5(string str)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] fromData = Encoding.UTF8.GetBytes(str);
            byte[] targetData = md5.ComputeHash(fromData);
            string byte2String = null;

            for (int i = 0; i < targetData.Length; i++)
            {
                byte2String += targetData[i].ToString("x2");

            }
            return byte2String;
        }
    }
}