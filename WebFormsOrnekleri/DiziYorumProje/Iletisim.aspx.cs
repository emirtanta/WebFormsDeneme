using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DiziYorumProje.Entity;

namespace DiziYorumProje
{
    public partial class Iletisim : System.Web.UI.Page
    {
        BlogDiziEntities db = new BlogDiziEntities();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //Mesaj gönder butonu
        protected void btnGonder_Click(object sender, EventArgs e)
        {
            TBL_Iletisim t = new TBL_Iletisim();
            t.ADSOYAD = txtAdSoyad.Text;
            t.KONU = txtKonu.Text;
            t.MAIL = txtMail.Text;
            t.TELEFON = txtTelefon.Text;
            t.MESAJ = txtMesaj.Text;

            db.TBL_Iletisim.Add(t);

            db.SaveChanges();
        }
    }
}