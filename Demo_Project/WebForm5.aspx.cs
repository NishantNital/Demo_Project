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
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlDataAdapter da = new SqlDataAdapter("spGetDate", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;

                DataSet ds = new DataSet();
                da.Fill(ds);

                ds.Tables[0].TableName = "Products";
                ds.Tables[1].TableName = "Category";

                GridView1.DataSource = ds.Tables["Products"];
                GridView1.DataBind();

                GridView2.DataSource = ds.Tables["Category"];
                GridView2.DataBind();


            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}