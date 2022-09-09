using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;

namespace Demo_Project
{
    public partial class WebForm9 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            DataSet ds = new DataSet();
            string str = Server.MapPath("XMLFile1.xml");
            ds.ReadXml(str);
            DropDownList1.DataTextField = "CountryName";
            DropDownList1.DataValueField = "CountryId";
            DropDownList1.DataSource = ds;
            DropDownList1.DataBind();

            ListItem li = new ListItem("Select","1");
            DropDownList1.Items.Insert(0,li);



        }
    }
}          