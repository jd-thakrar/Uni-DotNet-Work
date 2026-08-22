using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practical_5
{
    public partial class Leave : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["Username"] == null)
                {
                    Response.Redirect("Login.aspx");
                }


                if (Request.QueryString["selectedDate"] != null)
                {
                    string d = Request.QueryString["selectedDate"];
                    Date.Text = d;
                }
                else
                {
                    Date.Text = "NULL";

                }
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string name = Name.Text;
            string id = ID.Text;
            string reason = Reason.Text;
            string leaveDate = Date.Text;
            string swapFaculty = TextBox2.Text;

            Label9.Text = $"<b>Application Summary:</b><br/>" +
                          $"Name: {name}<br/>" +
                          $"ID: {id}<br/>" +
                          $"Leave Date: {leaveDate}<br/>" +
                          $"Reason: {reason}<br/>" +
                          $"Swap Faculty: {swapFaculty}";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Session.Abandon();

            Response.Redirect("Login.aspx");
        }
    }
}