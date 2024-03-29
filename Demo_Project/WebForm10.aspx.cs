﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Demo_Project
{
    public partial class WebForm10 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DropDownList1.SelectedValue = "1";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedValue != "-1")
            {
                Response.Write("Selected Item Text = " + DropDownList1.SelectedItem.Text + "<br/>");
                Response.Write("Selected Item Value = " + DropDownList1.SelectedItem.Value + "<br/>");
                Response.Write("Selected Item Index = " + DropDownList1.SelectedIndex.ToString());
            }
            else
            {
                Response.Write("Please select the continent");
            }
        }
    }
}