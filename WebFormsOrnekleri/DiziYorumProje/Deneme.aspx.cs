using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DiziYorumProje.Entity;

namespace DiziYorumProje
{
    public partial class Deneme : System.Web.UI.Page
    {
        BlogDiziEntities db = new BlogDiziEntities();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                var country = (from x in db.TBL_Country
                               select new
                               {
                                   x.COUNTRYNAME,
                                   x.COUNTRYID
                               }).ToList();

                DropDownList1.DataSource = country;
                DropDownList1.DataBind();
            }

            

            
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownList2.Items.Clear();
            DropDownList2.Items.Add("Select State");

            //bölgeler
            int id = Convert.ToInt32(DropDownList1.SelectedItem.Value);
            var state = db.TBL_State.Where(x => x.COUNTRYID == id).ToList();

            DropDownList2.DataSource = state;
            DropDownList2.DataBind();

        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownList3.Items.Clear();
            DropDownList3.Items.Add("Select State");

            int id = Convert.ToInt32(DropDownList2.SelectedItem.Value);
            var city = db.TBL_City.Where(x => x.STATEID == id).ToList();

            DropDownList3.DataSource = city;
            DropDownList3.DataBind();
        }
    }
}