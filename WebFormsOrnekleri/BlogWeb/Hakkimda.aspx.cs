using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb
{
    public partial class Hakkimda : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //sayfa yüklendiğinde değerleri hafıza tutmaya yarar.böylece textbox içerisindeki değerleri hafızaya alarak güncelleme işlemlerinde rahatlıkla kullanılır
            if (Page.IsPostBack==false)
            {
                //Hakkımda tablosundan sayfa veri çekme işlemi yaptık

                DataSetTableAdapters.TBL_HakkimdaTableAdapter dt = new DataSetTableAdapters.TBL_HakkimdaTableAdapter();

                //textboxlar içerisine verileri getirme
                TextBox1.Text = dt.HakkimdaListele()[0].AD;
                TextBox2.Text = dt.HakkimdaListele()[0].SOYAD;
                TextBox3.Text = dt.HakkimdaListele()[0].ADRES;
                TextBox4.Text = dt.HakkimdaListele()[0].MAIL;
                TextBox5.Text = dt.HakkimdaListele()[0].TELEFON;
                TextBox6.Text = dt.HakkimdaListele()[0].KISANOT;
                TextBox7.Text = dt.HakkimdaListele()[0].FOTOGRAF;
            }

            
        }

        //güncelle butonu bölümü
        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSetTableAdapters.TBL_HakkimdaTableAdapter dt1 = new DataSetTableAdapters.TBL_HakkimdaTableAdapter();
            dt1.HakkimdaGuncelle(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text, TextBox6.Text, TextBox7.Text);

            Response.Redirect("Default.Aspx");
        }
    }
}