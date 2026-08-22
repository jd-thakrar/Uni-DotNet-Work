using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practical_5
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Username"] == null)
            {
                Response.Redirect("Login.aspx");
            }
        }

        protected void Calendar1_DayRender(object sender, DayRenderEventArgs e)
        {
            DateTime d1 = new DateTime(2026, 9, 16);
            DateTime d2 = new DateTime(2026, 9, 17);
            DateTime d3 = new DateTime(2026, 9, 18);

            DateTime[] specificdate = { d1, d2, d3 };

            if (e.Day.Date.DayOfWeek == DayOfWeek.Sunday)
            {
                e.Day.IsSelectable = false;
                e.Cell.BackColor = System.Drawing.Color.Gray;
                e.Cell.ToolTip = "Sunday";
            }
            if (specificdate.Contains(e.Day.Date))
            {
                e.Cell.BackColor = System.Drawing.Color.Yellow;
                e.Cell.ToolTip = "Mid Exam";
            }
            if (e.Day.IsOtherMonth)
            {
                e.Day.IsSelectable = false;
                e.Cell.BackColor = System.Drawing.Color.WhiteSmoke;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Calendar1.SelectedDates.Count == 1)
            {
                string dateToSend = Calendar1.SelectedDate.ToString("yyyy-MM-dd");
                Response.Redirect("Leave.aspx?Selecteddate=" + dateToSend);
            }
        }
    }
}