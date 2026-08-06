using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practical_4
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string name = TextBox1.Text;
            string email = TextBox2.Text;
            string Enr = TextBox4.Text;
            string Address = TextBox3.Text;
            string gender = "";
            if (RadioButton1.Checked)
            {
                gender = "Male";
            }
            else if (RadioButton2.Checked) { 
                gender = "Female";
            }
            string country = DropDownList1.SelectedValue;
            string hobbies = "";
            if (CheckBox1.Checked)
            {
                hobbies += "Reading ";
            }
            if (CheckBox2.Checked)
            {
                hobbies += "Writing ";
            }
            if(CheckBox3.Checked)
            {
                hobbies += "Drawing ";
            }

            Label9.Text = "Name: " + name + "<br/>Email: " + email + "<br/>Enrollment No: " + Enr + "<br/>Address: " + Address + "<br/>Gender: " + gender + "<br/>Country: " + country + "<br/>Hobbies: " + hobbies;
        }

        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
            {
            if(RadioButton1.Checked || RadioButton2.Checked)
            {
                args.IsValid = true;
            }
            else
            {
                args.IsValid = false;
            }
        }

        protected void CustomValidator2_ServerValidate(object source, ServerValidateEventArgs args)
        {
            if(CheckBox1.Checked || CheckBox2.Checked || CheckBox3.Checked)
            {
                args.IsValid = true;
            }
            else
            {
                args.IsValid = false;
            }
        }
    }
}