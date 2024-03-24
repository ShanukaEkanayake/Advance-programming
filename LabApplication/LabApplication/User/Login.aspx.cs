using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LabApplication.User
{
    public partial class Login : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader sdr;
        string str = ConfigurationManager.ConnectionStrings["Shanuka"].ConnectionString;
        string username, password = string.Empty;
        string doctorUsername, doctorPassword = string.Empty;


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnlogin_Click(object sender, EventArgs e)
        {
            try
            {
                if(ddlLoginType.SelectedValue == "Admin")
                {
                    username = ConfigurationManager.AppSettings["username"];
                    password = ConfigurationManager.AppSettings["password"];
                    if(username == txtUserName.Text.Trim() && password == txtPassword.Text.Trim())
                    {
                        Session["admin"] = username;
                        Response.Redirect("../Admin/Dashboard.aspx", false);
                    }
                    else
                    {
                        showErrorMsg("Admin");
                    }
                }
                else if (ddlLoginType.SelectedValue == "Doctor")
                {
                    doctorUsername = ConfigurationManager.AppSettings["doctorUsername"];
                    doctorPassword = ConfigurationManager.AppSettings["doctorPassword"];
                    if (doctorUsername == txtUserName.Text.Trim() && doctorPassword == txtPassword.Text.Trim())
                    {
                        Session["doctor"] = doctorUsername;
                        Response.Redirect("../Doctor/Dashboard.aspx", false);
                    }
                    else
                    {
                        showErrorMsg("Doctor");
                    }
                }
                else
                {
                    con = new SqlConnection(str);
                    string query = @"Select * from Registration where UserName=@UserName and UserPassword=@UserPassword";
                    cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@UserName", txtUserName.Text.Trim());
                    cmd.Parameters.AddWithValue("@UserPassword", txtPassword.Text.Trim());
                    con.Open();
                    sdr = cmd.ExecuteReader();
                    if (sdr.Read())         
                    {
                        Session["user"] = sdr["UserName"].ToString();
                        Session["userId"] = sdr["UserId"].ToString();
                        Response.Redirect("Default.aspx", false);
                    }
                    else
                    {
                        showErrorMsg("User");
                    }
                    con.Close();
                }
            }
            catch (Exception ex) 
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
                con.Close();
            }    
        }

        private void showErrorMsg(string userType)
        {
            lblMsg.Visible = true;
            lblMsg.Text = "<b>" + userType + "</b> Inputs are incorrect..";
            lblMsg.CssClass = "alert alert-danger";
        }
    }
}