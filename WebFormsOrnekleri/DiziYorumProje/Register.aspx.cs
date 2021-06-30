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
    public partial class Register : System.Web.UI.Page
    {
        BlogDiziEntities db = new BlogDiziEntities();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //Kayıt ol butonu
        protected void btnKayitOl_Click(object sender, EventArgs e)
        {

            TBL_Admin admin = new TBL_Admin();

            admin.KULLANICI = txtKullaniciAdi.Text;
            admin.SIFRE = txtSifre.Text;
            admin.SEHIR = dpdSehir.SelectedValue;
            admin.CINSIYET = rbCinsiyet.SelectedValue;

            db.TBL_Admin.Add(admin);

            db.SaveChanges();

            Response.Redirect("Login.Aspx");


            //TBL_Admin admin = new TBL_Admin();

            //if (ModelState.IsValid)
            //{
            //    var check = db.TBL_Admin.FirstOrDefault(s => s.KULLANICI == admin.KULLANICI);
            //    if (check == null)
            //    {
            //        admin.SIFRE = GetMD5(admin.SIFRE);
            //        db.Configuration.ValidateOnSaveEnabled = false;
            //        db.TBL_Admin.Add(admin);
            //        db.SaveChanges();

            //        Response.Redirect("Login.Aspx");
            //    }
            //    else
            //    {
            //        //ViewBag.error = "Email already exists";

            //        Response.Redirect("Register.Aspx");
            //    }


            //}
            //return View();

        }

        //create a string MD5
        //public static string GetMD5(string str)
        //{
        //    MD5 md5 = new MD5CryptoServiceProvider();
        //    byte[] fromData = Encoding.UTF8.GetBytes(str);
        //    byte[] targetData = md5.ComputeHash(fromData);
        //    string byte2String = null;

        //    for (int i = 0; i < targetData.Length; i++)
        //    {
        //        byte2String += targetData[i].ToString("x2");

        //    }
        //    return byte2String;
        //}


    }
}