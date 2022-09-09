using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Demo_Project
{
    public partial class Asp_Net_35 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                multiViewEmployee.ActiveViewIndex = 0;
            }
        }

        // Forward 
        protected void btnGoToStep2_Click(object sender, EventArgs e)
        {
            multiViewEmployee.ActiveViewIndex = 1;
        }

        protected void btnGoToStep3_Click(object sender, EventArgs e)
        {
            lblFirstName.Text = txtFirstName.Text;
            lblLastName.Text = txtLastName.Text;
            lblGender.Text = ddlGender.SelectedValue;

            lblEmail.Text = txtEmail.Text;
            lblMobile.Text = txtMobile.Text;

            multiViewEmployee.ActiveViewIndex = 2;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(CS))
            {
                con.Open();
                
                SqlCommand cmd = new SqlCommand("spPutEmployeeData", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@First_Name", SqlDbType.NVarChar).Value = lblFirstName.Text;
                cmd.Parameters.AddWithValue("@Last_Name", SqlDbType.NVarChar).Value = lblLastName.Text;
                cmd.Parameters.AddWithValue("@Gender", SqlDbType.NVarChar).Value = lblGender.Text;
                cmd.Parameters.AddWithValue("@Emial", SqlDbType.NVarChar).Value = lblEmail.Text;
                cmd.Parameters.AddWithValue("@Mobile_Number", SqlDbType.BigInt).Value = lblMobile.Text;
                cmd.ExecuteNonQuery();
            }
            Response.Redirect("~/Confirmation.aspx");

        }

        // Previous 
        protected void btnBackToStep1_Click(object sender, EventArgs e)
        {
            multiViewEmployee.ActiveViewIndex = 0;
        }

        protected void btnbacktostep2_click(object sender, EventArgs e)
        {
            multiViewEmployee.ActiveViewIndex = 1;
        }
    }
}