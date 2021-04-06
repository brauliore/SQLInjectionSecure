using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace asp.netloginpage
{
    public partial class Dashboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] == null)
                Response.Redirect("login.aspx");
            lblUserDetails.Text = "Username: " + Session["username"];
            lblUserPass.Text = "Password: " + Session["password"];
            DataList1.DataSource = Session["dt"];
            DataList1.DataBind();
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("Login.aspx");
        }

        protected void DataList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}