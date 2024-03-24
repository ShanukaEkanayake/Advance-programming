using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;

namespace LabApplication.Doctor
{
    public partial class Dashboard : System.Web.UI.Page
    {
        SqlConnection con;
        SqlDataAdapter sda;
        DataTable dt;
        string str = ConfigurationManager.ConnectionStrings["Shanuka"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["doctor"] == null)
            {
                Response.Redirect("../User/Login.aspx");
            }

            if (!IsPostBack)
            {
                users();
                services();
                AppliedServices();
                contactCount();
            }
        }
        private void contactCount()
        {
            con = new SqlConnection(str);
            sda = new SqlDataAdapter("Select Count(*) from PMessages", con);
            dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                Session["PMessages"] = dt.Rows[0][0];
            }
            else
            {
                Session["PMessages"] = 0;
            }
        }

        private void AppliedServices()
        {
            con = new SqlConnection(str);
            sda = new SqlDataAdapter("Select Count(*) from Appointments", con);
            dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                Session["Appointments"] = dt.Rows[0][0];
            }
            else
            {
                Session["Appointments"] = 0;
            }
        }

        private void services()
        {
            con = new SqlConnection(str);
            sda = new SqlDataAdapter("Select Count(*) from LServices", con);
            dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                Session["LServices"] = dt.Rows[0][0];
            }
            else
            {
                Session["LServices"] = 0;
            }
        }

        private void users()
        {
            con = new SqlConnection(str);
            sda = new SqlDataAdapter("Select Count(*) from Registration", con);
            dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                Session["Registration"] = dt.Rows[0][0];
            }
            else
            {
                Session["Registration"] = 0;
            }
        }
    }
}