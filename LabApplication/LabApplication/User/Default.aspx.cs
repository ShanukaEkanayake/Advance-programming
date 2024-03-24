using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LabApplication.User
{
    public partial class Default : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter sda;
        DataTable dt;
        public int serviceCount = 0;
        string str = ConfigurationManager.ConnectionStrings["Shanuka"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

    }
}
