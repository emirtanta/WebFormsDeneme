using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb
{
    public partial class AdminDeneyimEkle : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        //Deneyim Ekle butonu
        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSetTableAdapters.TBL_DeneyimTableAdapter dt = new DataSetTableAdapters.TBL_DeneyimTableAdapter();

            dt.DeneyimEkle(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text);

            Response.Redirect("AdminDeneyimler.Aspx");
        }
    }
}