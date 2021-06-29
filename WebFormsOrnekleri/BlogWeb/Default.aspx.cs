using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //DataAdağter sınıfından bir nesne oluşturularak veritabanındaki tablolara erişim sağlanmaya çalışılır
            DataSetTableAdapters.TBL_HakkimdaTableAdapter dt = new DataSetTableAdapters.TBL_HakkimdaTableAdapter();

            //hakkımda tablosundaki değerleri listelemeye yarar
            Repeater1.DataSource = dt.HakkimdaListele();

            //veri siteye sokmaya yarar
            Repeater1.DataBind();

            //deneyim tablosu için verileri veritabanından alma
            DataSetTableAdapters.TBL_DeneyimTableAdapter dt2 = new DataSetTableAdapters.TBL_DeneyimTableAdapter();
            Repeater2.DataSource = dt2.DeneyimListesi();
            Repeater2.DataBind();

            //eğitim tablosu için verileri veritabanından alma
            DataSetTableAdapters.TBL_EgitimTableAdapter dt3 = new DataSetTableAdapters.TBL_EgitimTableAdapter();
            Repeater3.DataSource = dt3.EgitimListesi();
            Repeater3.DataBind();

            //TBL_Yetenek tablosu için verileri veritabanından alma
            DataSetTableAdapters.TBL_YeteneklerTableAdapter dt4 = new DataSetTableAdapters.TBL_YeteneklerTableAdapter();
            Repeater4.DataSource = dt4.YetenekListesi();
            Repeater4.DataBind();

            //TBL_Hobiler tablosu için verileri veritabanından alma
            DataSetTableAdapters.TBL_HobilerTableAdapter dt5 = new DataSetTableAdapters.TBL_HobilerTableAdapter();
            Repeater5.DataSource = dt5.HobiListesi();
            Repeater5.DataBind();

            //TBL_Konferanslar tablosu için verileri veritabanından alma
            DataSetTableAdapters.TBL_KonferanslarTableAdapter dt6 = new DataSetTableAdapters.TBL_KonferanslarTableAdapter();
            Repeater6.DataSource = dt6.KonferansListesi();
            Repeater6.DataBind();

            //resim güncelleme
            DataSetTableAdapters.TBL_HakkimdaTableAdapter dt7 = new DataSetTableAdapters.TBL_HakkimdaTableAdapter();
            Repeater7.DataSource = dt.HakkimdaListele();
            Repeater7.DataBind();


        }

        

       
    }
}