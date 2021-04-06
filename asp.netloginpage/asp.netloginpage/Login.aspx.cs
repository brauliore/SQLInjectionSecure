using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace asp.netloginpage
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblErrorMessage.Visible = false;
            string username = (Request["username"] ?? String.Empty).ToString();
            string password = (Request["password"] ?? String.Empty).ToString();
            if (!username.Equals(String.Empty) && !password.Equals(String.Empty))
            {
                login(username, password);
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            login(txtUserName.Text, txtPassword.Text);
        }

        private void login (string username, string password)
        {
            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-N2GDKAV;initial Catalog=LoginDB;Integrated Security=True;"))
            {
                sqlCon.Open();
                sqlCon.Open();
                string query = "SELECT COUNT(1) FROM tblUser WHERE username=@username AND password=@password";
                SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
                sqlCmd.Parameters.AddWithValue("@username", txtUserName.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@password", txtPassword.Text.Trim());
                int count = Convert.ToInt32(sqlCmd.ExecuteScalar());
                if (count == 1)
                {
                    Session["username"] = username;
                    Session["password"] = password;
                    Response.Redirect("Dashboard.aspx");
                }
                else
                {
                    lblErrorMessage.Visible = true;
                }
            }
        }
    }
} 