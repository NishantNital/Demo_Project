using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Demo_Project
{
    public partial class Asp_Net_33 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DateTime selectedDate in Calendar1.SelectedDates)
            {
                Response.Write(selectedDate.ToShortDateString() + "<br/>");
                Response.Write(selectedDate.ToLongDateString());
            }
        }
        protected void Calendar1_DayRender(object sender, DayRenderEventArgs e)
        {
            if (!e.Day.IsOtherMonth && e.Day.Date.Day % 2 == 0)
            {
                e.Cell.Text = "x";
                e.Cell.Font.Bold = true;
                e.Cell.ForeColor = System.Drawing.Color.White;
                e.Cell.BackColor = System.Drawing.Color.Red;
                e.Cell.ToolTip = "Booked";
            }
            else
            {
                e.Cell.ToolTip = "Available";
            }
        }
        protected void Calendar1_VisibleMonthChanged(object sender, MonthChangedEventArgs e)
        {
            Response.Write("Month changed from ");
            Response.Write(GetMonthName(e.PreviousDate.Month));
            Response.Write(" to ");
            Response.Write(GetMonthName(e.NewDate.Month));
        }
        private string GetMonthName(int MonthNumber)
        {
            switch (MonthNumber)
            {
                case 1:
                    return "Jan";
                case 2:
                    return "Feb";
                case 3:
                    return "Mar";
                case 4:
                    return "Apr";
                case 5:
                    return "May";
                case 6:
                    return "Jun";
                case 7:
                    return "Jul";
                case 8:
                    return "Aug";
                case 9:
                    return "Sep";
                case 10:
                    return "Oct";
                case 11:
                    return "Nov";
                case 12:
                    return "Dec";
                default:
                    return "Invalid Month";
            }
        }
    }
}