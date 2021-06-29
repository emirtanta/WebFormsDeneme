using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace BlogWeb
{
    public partial class GirisYap : System.Web.UI.Page
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-QVN1TMN;Initial Catalog=BlogWebFormsDB;User ID=sa;Password=1234");

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGirisYap_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From TBL_Admin Where KULLANICI=@p1 and SIFRE=@p2", baglanti);
            komut.Parameters.AddWithValue("@p1", txtUsername.Text);
            komut.Parameters.AddWithValue("@p2", txtPassword.Text);

            SqlDataReader dr = komut.ExecuteReader();

            if (dr.Read())
            {
                Response.Redirect("AdminDeneyimler.Aspx");
            }

            else
            {
                Response.Write("Hatalı kullanıcı adı ya da şifre");

                
            }

            baglanti.Close();
        }
    }
}