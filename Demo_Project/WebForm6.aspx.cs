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
    public partial class WebForm6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (Cache["Data"] == null)
            {
                string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
                using (SqlConnection con = new SqlConnection(cs))
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM  Product_Inventory", con);
                    DataSet ds = new DataSet();
                    da.Fill(ds);

                    Cache["Data"] = ds;
                    GridView1.DataSource = ds;
                    GridView1.DataBind();
                    

                }
                Label1.Text = "DataSource from Database";
            }
            else
            {
                GridView1.DataSource = (DataSet)Cache["Data"];
                GridView1.DataBind();
                Label1.Text = "DataSource from Cache";
            }
            
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            if(Cache["Data"] != null )
            {
                Cache.Remove("Data");
                Label1.Text = "The datset is removed from the cache ";
            }
            else
            {
                Label1.Text = "There is nothing in the cache to removed ";
            }
        }
    }
}