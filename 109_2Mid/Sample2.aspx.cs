using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _109_2Mid {
    public partial class Sample2 : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void btn_Sub_Click(object sender, EventArgs e)
        {
            string result ="";
            result += ddl_Area.SelectedValue+"<br/>";
            result += ddl_Place.SelectedValue + "<br/>";
            result += tb_Name.Text+"<br/>";
            if (tb_Des.Text != "")
            {
                result += tb_Des.Text;
            }

            lb_Msg.Text = result;
        }

        protected void ddl_Area_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            
           
            
        }

        protected void ddl_Place_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        protected void rbl_Res_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rbl_Res.SelectedIndex == 1)
            {
                tb_Des.Visible = true;
            }
            else
            {
                tb_Des.Visible = false;
            }
        }
    }
}