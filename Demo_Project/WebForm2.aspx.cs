using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace Demo_Project
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT ProductId,Product_Name,Unit_Price FROM Product_Inventory", con);
                using (SqlDataReader rdr = cmd.ExecuteReader())
                {
                    DataTable table = new DataTable();
                    table.Columns.Add("ID");
                    table.Columns.Add("Name");
                    table.Columns.Add("Price");
                    table.Columns.Add("Discounted Price");
                    while (rdr.Read())
                    {
                        DataRow dataRow = table.NewRow();
                        int OriginalPrice = Convert.ToInt32(rdr["Unit_Price"]);
                        double DiscountedPrice = OriginalPrice * 0.9;

                        dataRow["ID"] = rdr["ProductId"];
                        dataRow["Name"] = rdr["Product_Name"];
                        dataRow["Price"] = rdr["Unit_Price"];
                        dataRow["Discounted Price"] = DiscountedPrice;
                        table.Rows.Add(dataRow);

                    GridView1.DataSource = table;
                    GridView1.DataBind(); 
                    }
                }
                

            }

                
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {

        }
    }
}