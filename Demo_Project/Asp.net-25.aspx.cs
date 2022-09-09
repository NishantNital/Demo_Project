using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Demo_Project
{
    public partial class Asp_net_25 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            foreach (ListItem li in ListBox1.Items)
            {
                if (li.Selected)
                {
                    Response.Write("text = " + li.Text + ", ");
                    Response.Write("value = " + li.Value + ", ");
                    Response.Write("index = " + ListBox1.Items.IndexOf(li).ToString());
                    Response.Write("<br/>");
                }
            }
            
        }

        //protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    for (int i=0; i < ListBox1.Items.Count; i++)
        //    {
        //        if (ListBox1.Items[1].Selected)
        //        {
        //            Response.Redirect("https://www.google.com/");
        //        }
        //        else if (ListBox1.Items[0].Selected)
        //        {
        //            Response.Redirect("https://csharp-video-tutorials.blogspot.com/2012/11/aspnet-listbox-control-part-25.html");
        //        }
        //    }
        //    {
               
        //    }
        
    }
}