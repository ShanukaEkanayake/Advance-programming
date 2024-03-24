using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LabApplication.Doctor
{
    public partial class NewService : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand cmd;
        string query;
        string str = ConfigurationManager.ConnectionStrings["Shanuka"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["doctor"] == null)
            {
                Response.Redirect("../User/Login.aspx");
            }
            Session["title"] = "Add Service";
            if (!IsPostBack)
            {
                fillData();
            }
        }
        private void fillData()
        {
            if (Request.QueryString["id"] != null)
            {
                con = new SqlConnection(str);
                query = "Select * from LServices where ServiceId = '" + Request.QueryString["id"] + "' ";
                cmd = new SqlCommand(query, con);
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.HasRows)
                {
                    while (sdr.Read())
                    {
                        txtServiceTitle.Text = sdr["Headding"].ToString();
                        txtNoOfSlot.Text = sdr["SCount"].ToString();
                        txtDescription.Text = sdr["SDescription"].ToString();
                        txtQualification.Text = sdr["Qualification"].ToString();
                        txtLastDate.Text = Convert.ToDateTime(sdr["ApplyBefore"]).ToString("yyyy-MM-dd");
                        txtFee.Text = sdr["SFee"].ToString();
                        ddlServiceType.SelectedValue = sdr["SType"].ToString();
                        txtCompany.Text = sdr["DName"].ToString();
                        txtAddress.Text = sdr["SAddress"].ToString();
                        txtNo.Text = sdr["SContact"].ToString();
                        ddlstate.SelectedValue = sdr["State"].ToString();
                        btnAdd.Text = "Update";
                        linkBack.Visible = true;
                        Session["Headding"] = "Edit Service";

                    }
                }
                else
                {
                    lblMsg.Text = "Service not Found..";
                    lblMsg.CssClass = "alert alert-danger";
                }
                sdr.Close();
                con.Close();
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string type, concatQuery, imagePath = string.Empty;
                bool isValidToExecute = false;
                con = new SqlConnection(str);
                if (Request.QueryString["id"] != null)
                {
                    if (fuCompanyLogo.HasFile)
                    {
                        if (Utils.IsValidExtension(fuCompanyLogo.FileName))
                        {
                            concatQuery = "SLogo=@SLogo,";
                        }
                        else
                        {
                            concatQuery = string.Empty;
                        }
                    }
                    else
                    {
                        concatQuery = string.Empty;
                    }

                    query = @"Update LServices set  Headding=@Headding,SCount=@SCount,SDescription=@SDescription,Qualification=@Qualification,
                            ApplyBefore=@ApplyBefore,SFee=@SFee,SType=@SType,
                            DName=@DName, " + concatQuery + @"SAddress=@SAddress,SContact=@SContact,
                            State=@State where ServiceId=@id";
                    type = "updated";

                    cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Headding", txtServiceTitle.Text.Trim());
                    cmd.Parameters.AddWithValue("@SCount", txtNoOfSlot.Text.Trim());
                    cmd.Parameters.AddWithValue("@SDescription", txtDescription.Text.Trim());
                    cmd.Parameters.AddWithValue("@Qualification", txtQualification.Text.Trim());
                    cmd.Parameters.AddWithValue("@ApplyBefore", txtLastDate.Text.Trim());
                    cmd.Parameters.AddWithValue("@SFee", txtFee.Text.Trim());
                    cmd.Parameters.AddWithValue("@SType", ddlServiceType.SelectedValue);
                    cmd.Parameters.AddWithValue("@SLogo", txtCompany.Text.Trim());
                    cmd.Parameters.AddWithValue("@DName", txtAddress.Text.Trim());
                    cmd.Parameters.AddWithValue("@SAddress", txtAddress.Text.Trim());
                    cmd.Parameters.AddWithValue("@SContact", txtNo.Text.Trim());
                    cmd.Parameters.AddWithValue("@State", ddlstate.SelectedValue);
                    cmd.Parameters.AddWithValue("@id", Request.QueryString["id"].ToString());
                    if (fuCompanyLogo.HasFile)
                    {
                        if (Utils.IsValidExtension(fuCompanyLogo.FileName))
                        {
                            Guid obj = Guid.NewGuid();
                            imagePath = "Images/" + obj.ToString() + fuCompanyLogo.FileName;
                            fuCompanyLogo.PostedFile.SaveAs(Server.MapPath("~/Images/") + obj.ToString() + fuCompanyLogo.FileName);

                            cmd.Parameters.AddWithValue("@SLogo", imagePath);
                            isValidToExecute = true;
                        }
                        else
                        {
                            lblMsg.Text = "Please select .jpg, .jpeg, .png file for Logo";
                            lblMsg.CssClass = "alert alert-danger";
                        }
                    }
                    else
                    {
                        isValidToExecute = true;
                    }


                }
                else
                {
                    query = "Insert into LServices values(@Headding,@SCount,@SDescription,@Qualification," +
                   "@ApplyBefore,@SFee,@SType,@DName,@SLogo,@SAddress,@SContact,@State,@AddDate)";
                    type = "saved";
                    DateTime time = DateTime.Now;
                    cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Headding", txtServiceTitle.Text.Trim());
                    cmd.Parameters.AddWithValue("@SCount", txtNoOfSlot.Text.Trim());
                    cmd.Parameters.AddWithValue("@SDescription", txtDescription.Text.Trim());
                    cmd.Parameters.AddWithValue("@Qualification", txtQualification.Text.Trim());
                    cmd.Parameters.AddWithValue("@ApplyBefore", txtLastDate.Text.Trim());
                    cmd.Parameters.AddWithValue("@SFee", txtFee.Text.Trim());
                    cmd.Parameters.AddWithValue("@SType", ddlServiceType.SelectedValue);
                    cmd.Parameters.AddWithValue("@DName", txtCompany.Text.Trim());
                    cmd.Parameters.AddWithValue("@SAddress", txtAddress.Text.Trim());
                    cmd.Parameters.AddWithValue("@SContact", txtNo.Text.Trim());
                    cmd.Parameters.AddWithValue("@State", ddlstate.SelectedValue);
                    cmd.Parameters.AddWithValue("@AddDate", time.ToString("yyyy-MM-dd HH:mm:ss"));
                    if (fuCompanyLogo.HasFile)
                    {
                        if (Utils.IsValidExtension(fuCompanyLogo.FileName))
                        {
                            Guid obj = Guid.NewGuid();
                            imagePath = "Images/" + obj.ToString() + fuCompanyLogo.FileName;
                            fuCompanyLogo.PostedFile.SaveAs(Server.MapPath("~/Images/") + obj.ToString() + fuCompanyLogo.FileName);

                            cmd.Parameters.AddWithValue("@SLogo", imagePath);
                            isValidToExecute = true;
                        }
                        else
                        {
                            lblMsg.Text = "Please select .jpg, .jpeg, .png file for Logo";
                            lblMsg.CssClass = "alert alert-danger";
                        }
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@SLogo", imagePath);
                        isValidToExecute = true;
                    }
                }
                if (isValidToExecute)
                {
                    con.Open();
                    int res = cmd.ExecuteNonQuery();
                    if (res > 0)
                    {
                        lblMsg.Text = "Service " + type + " Successfull..";
                        lblMsg.CssClass = "alert alert-success";
                        clear();
                    }
                    else
                    {
                        lblMsg.Text = "Cannot" + type + "the records, please try after sometime..";
                        lblMsg.CssClass = "alert alert-danger";
                    }
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

        private void clear()
        {
            txtServiceTitle.Text = string.Empty;
            txtNoOfSlot.Text = string.Empty;
            txtDescription.Text = string.Empty;
            txtQualification.Text = string.Empty;
            txtLastDate.Text = string.Empty;
            txtFee.Text = string.Empty;
            txtCompany.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtNo.Text = string.Empty;
            ddlServiceType.ClearSelection();
            ddlstate.ClearSelection();
        }
    }
}