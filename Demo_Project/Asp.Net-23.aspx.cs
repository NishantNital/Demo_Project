﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Demo_Project
{
    public partial class Asp_Net_23 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            foreach (ListItem li in checkboxListEducation.Items)
            {
                // If the list item is selected
                if (li.Selected)
                {
                    // Retrieve the text of the selected list item
                    Response.Write("Text = " + li.Text + ", ");
                    // Retrieve the value of the selected list item

                    Response.Write("Value = " + li.Value + ", ");
                    // Retrieve the index of the selected list item
                    Response.Write("Index = " + checkboxListEducation.Items.IndexOf(li).ToString());
                    Response.Write("<br/>");
                }
            }
        }
    }
}