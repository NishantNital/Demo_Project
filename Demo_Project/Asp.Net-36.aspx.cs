using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;

namespace Demo_Project
{
    public partial class Asp_Net_36 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Wizard1_NextButtonClick(object sender, WizardNavigationEventArgs e)
        {
            if (e.NextStepIndex == 2)
            {
                lblFirstName.Text = txtFirstName.Text;
                lblLastName.Text = txtLastName.Text;
                lblGender.Text = ddlGender.SelectedValue;

                lblEmail.Text = txtEmail.Text;
                lblMobile.Text = txtMobile.Text;
            }
        }

        protected void Wizard1_FinishButtonClick(object sender, WizardNavigationEventArgs e)
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
    }
}