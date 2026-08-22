using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practical_5
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.Cookies["username"] != null)
                {
                    Username.Text = Request.Cookies["username"].Value;
                    Remember.Checked = true;
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String username = Username.Text;
            String password = Password.Text;
            if (username == "Student" && password == "123456")
            {
                Session["Username"] = Username.Text;
                if (Remember.Checked)
                {
                    HttpCookie userCookie = new HttpCookie("username", Username.Text);
                    userCookie.Expires = DateTime.Now.AddDays(7);
                    Response.Cookies.Add(userCookie);
                }
                else
                {
                    if (Request.Cookies["username"] != null)
                    {
                        HttpCookie userCookie = new HttpCookie("username");
                        userCookie.Expires = DateTime.Now.AddDays(-1);
                        Response.Cookies.Add(userCookie);
                    }
                }
                Response.Redirect("Default.aspx");
            }
        }
    }
}