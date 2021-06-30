﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DiziYorumProje.Entity;

namespace DiziYorumProje.AdminSayfalar
{
    public partial class Roller : System.Web.UI.Page
    {
        BlogDiziEntities db = new BlogDiziEntities();


        protected void Page_Load(object sender, EventArgs e)
        {
            Repeater1.DataSource = db.TBL_Roller.ToList();
            Repeater1.DataBind();
        }
    }
}