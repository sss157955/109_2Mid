﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _109_2Mid {
    public partial class Sample1Com : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            
            lb_Res.Text = Request.Form.Get("tb_Acc")+"<br/>"+ Request.Form.Get("tb_Pass") + "<br/>";

            if (Request.Form.Get("rb_book") != null)
            {
                lb_Res.Text += "看書" + "<br/>";
            }
            if (Request.Form.Get("rb_game") != null)
            {
                lb_Res.Text += "打電動" + "<br/>";
            }

            if (Request.Form.Get("rb_other") != null)
            {
                lb_Res.Text += "其他"+ "<br/>";
            }



        }
    }
}