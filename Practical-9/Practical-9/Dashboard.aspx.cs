
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace Practical_9
{
    public partial class Dashboard : System.Web.UI.Page
    {
        string cs = ConfigurationManager.ConnectionStrings["PlacementConnection"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindDashboard();
            }
        }

        void BindDashboard()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();

                // Total Students
                SqlCommand cmd1 = new SqlCommand(
                    "SELECT COUNT(*) FROM Placement", con);

                lblTotal.Text = cmd1.ExecuteScalar().ToString();

                // Students Placed
                SqlCommand cmd2 = new SqlCommand(
                    "SELECT COUNT(*) FROM Placement WHERE PlacementStatus = 'Placed'", con);

                lblPlaced.Text = cmd2.ExecuteScalar().ToString();

                // Students Not Placed
                SqlCommand cmd3 = new SqlCommand(
                    "SELECT COUNT(*) FROM Placement WHERE PlacementStatus = 'Not Placed'", con);

                lblNotPlaced.Text = cmd3.ExecuteScalar().ToString();
            }

            // Display all student records
            using (SqlConnection con = new SqlConnection(cs))
            {
                string query = "SELECT * FROM Placement";

                SqlDataAdapter da = new SqlDataAdapter(query, con);

                DataTable dt = new DataTable();

                da.Fill(dt);

                Repeater2.DataSource = dt;
                Repeater2.DataBind();
            }
        }
    }
}
