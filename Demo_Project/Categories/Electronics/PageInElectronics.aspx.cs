using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Demo_Project.Categories.Electronics
{
    public partial class PageInElectronics : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write(". returns " + Server.MapPath(".") + "<br/>");
            Response.Write(".. returns " + Server.MapPath("..") + "<br/>");
            Response.Write("~ returns " + Server.MapPath("~") + "<br/>");

        }
    }
}