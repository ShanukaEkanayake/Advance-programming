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
    public partial class Payment : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand cmd;
        string str = ConfigurationManager.ConnectionStrings["Shanuka"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] != null)
            {

            }
            else
            {
                Response.Redirect("Login.aspx");
            }
        }

        protected void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                // Creating SqlConnection object using connection string(p)
                con = new SqlConnection(str);

                // Creating SqlCommand object with query and SqlConnection object
                string query = @"Insert into Payments (CardName,CardNumber,ExDate,CardCVV,DoDate) values (@CardName,@CardNumber,@ExDate,@CardCVV,@DoDate)";
                DateTime time = DateTime.Now;
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@CardName", txtName.Text.Trim());
                cmd.Parameters.AddWithValue("@CardNumber", txtCardNo.Text.Trim());
                cmd.Parameters.AddWithValue("@ExDate", txtMonth.Text.Trim());
                cmd.Parameters.AddWithValue("@CardCVV", txtCvv.Text.Trim());
                cmd.Parameters.AddWithValue("@DoDate", time.ToString("yyyy-MM-dd HH:mm:ss"));
                con.Open();

                // Execute the query and get number of rows affected
                int r = cmd.ExecuteNonQuery();
                if (r > 0)
                {
                    lblMsg.Visible = true;
                    lblMsg.Text = "User Payment Successfull!!";
                    lblMsg.CssClass = "alert alert-success";
                    Clear();
                }
                else
                {
                    lblMsg.Visible = true;
                    lblMsg.Text = "Cannot Pay right now! plz try after some time";
                    lblMsg.CssClass = "alert alert-danger";
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
            finally
            {
                con.Close();
            }
        }

        private void Clear()
        {
            txtName.Text = string.Empty;
            txtCardNo.Text = string.Empty;
            txtMonth.Text = string.Empty;
            txtMonth.Text = string.Empty;
            txtCvv.Text = string.Empty;
        }
    }
}