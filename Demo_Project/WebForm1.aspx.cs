using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;

namespace Demo_Project
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        int clickcount = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
           

           // string CS = "data source=(LocalDB)\\MSSQLLocalDB;database=Sample;integrated security=true";
            

           

                //cmd.CommandText = ("delete from table_1 where productid=7");
                //int TotalRowsDeleted = cmd.ExecuteNonQuery();
                //Response.Write("Total Rows Deleted" + TotalRowsDeleted.ToString() + "<br/>");

                //cmd.CommandText = ("delete from table_1 where productid=7");
                //int totalrowsdeleted1 = cmd.ExecuteNonQuery();
                //Response.Write("total rows" + totalrowsdeleted1.ToString() + "<br/>");

                //cmd.CommandText = ("INSERT INTO Table_1 VALUES(1,'Washing Machine',37000,15)");
                //int totalrowsinserted = cmd.ExecuteNonQuery();
                //Response.Write("total rows" + totalrowsinserted.ToString() + "<br/>");

                //cmd.CommandText = ("UPDATE Table_1 SET [Qty Available]=100 WHERE ProductId=6");
                //int TotalRowsUpdated = cmd.ExecuteNonQuery();
                //Response.Write("Total Rows updated" + TotalRowsUpdated.ToString() + "<br/>");
                // SqlDataReader rdr = cmd.ExecuteReader();

            }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            
            
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged1(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(CS))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("spAddEmployee", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Name", TextBox1.Text);
                cmd.Parameters.AddWithValue("@Gender", DropDownList1.SelectedValue);
                cmd.Parameters.AddWithValue("@salary", TextBox2.Text);

                SqlParameter outputparameter = new SqlParameter();
                outputparameter.ParameterName = "@EmployeeId";
                outputparameter.SqlDbType = System.Data.SqlDbType.Int;
                outputparameter.Direction = System.Data.ParameterDirection.Output;

                cmd.Parameters.Add(outputparameter);
                cmd.ExecuteNonQuery();

                string EmpId = outputparameter.Value.ToString();
                TextBox3.Text = "Employee Id " + EmpId;

            }
        }
    }
}







    
    