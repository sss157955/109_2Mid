﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _109_2Mid {
    public partial class Sample2 : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

        }


        protected void ddl_Area_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddl_Area.SelectedIndex == 1)
            {
                for (int i = 0; i < 3; i++)
                {
                    ddl_Place.Items[i].Enabled = false;
                }
                for (int i = 3; i < 6; i++)
                {
                    ddl_Place.Items[i].Enabled = true;
                }

            }
            
            
           
            
        }

        protected void ddl_Place_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        protected void rbl_Res_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rbl_Res.SelectedIndex == 0)
            {
                tb_Des.Visible = false;
            }
            else
            {
                tb_Des.Visible = true;
            }
        }

        protected void btn_Sub_Click1(object sender, EventArgs e)
        {
            lb_Msg.Text += ddl_Area.SelectedValue + "<br/>" + ddl_Place.SelectedValue+"<br/>";
            if (tb_Name.Text != "")
            {
                lb_Msg.Text += tb_Name.Text+"<br/>";
            }
            if (tb_Des.Text != "")
            {
                lb_Msg.Text += tb_Des.Text+ "<br/>";
            }
            
        }
    }
}