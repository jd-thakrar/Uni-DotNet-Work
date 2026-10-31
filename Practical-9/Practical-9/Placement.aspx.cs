
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PlacementDashboard
{
    public partial class Placement : System.Web.UI.Page
    {
        string cs = ConfigurationManager
            .ConnectionStrings["PlacementConnection"]
            .ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindRecords();
            }
        }

        // Display all placement records
        void BindRecords()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                string query = "SELECT * FROM Placement";

                SqlDataAdapter da = new SqlDataAdapter(query, con);

                DataTable dt = new DataTable();

                da.Fill(dt);

                Repeater1.DataSource = dt;
                Repeater1.DataBind();
            }
        }

        // Insert and Update
        protected void btnSave_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();

                string query;

                if (ViewState["EditId"] == null)
                {
                    // Insert new student
                    query = @"INSERT INTO Placement
                              (GRNo, Name, Department, PlacementStatus)
                              VALUES
                              (@GRNo, @Name, @Department, @Status)";
                }
                else
                {
                    // Update existing student
                    query = @"UPDATE Placement
                              SET GRNo = @GRNo,
                                  Name = @Name,
                                  Department = @Department,
                                  PlacementStatus = @Status
                              WHERE Id = @Id";
                }

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@GRNo", txtGRNo.Text);
                cmd.Parameters.AddWithValue("@Name", txtName.Text);
                cmd.Parameters.AddWithValue("@Department", txtDepartment.Text);
                cmd.Parameters.AddWithValue("@Status", ddlStatus.SelectedValue);

                if (ViewState["EditId"] != null)
                {
                    cmd.Parameters.AddWithValue("@Id", ViewState["EditId"]);
                }

                cmd.ExecuteNonQuery();
            }

            lblMessage.Text = "Record saved successfully.";

            ClearFields();
            BindRecords();
        }

        // Edit and Delete
        protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            int id = Convert.ToInt32(e.CommandArgument);

            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();

                if (e.CommandName == "EditRecord")
                {
                    // Get selected student details
                    string query = "SELECT * FROM Placement WHERE Id = @Id";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Id", id);

                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        txtGRNo.Text = dr["GRNo"].ToString();
                        txtName.Text = dr["Name"].ToString();
                        txtDepartment.Text = dr["Department"].ToString();
                        ddlStatus.SelectedValue = dr["PlacementStatus"].ToString();

                        ViewState["EditId"] = id;

                        btnSave.Text = "Update";
                        lblMessage.Text = "Edit student details and click Update.";
                    }

                    dr.Close();
                }
                else if (e.CommandName == "DeleteRecord")
                {
                    // Delete selected student
                    string query = "DELETE FROM Placement WHERE Id = @Id";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Id", id);

                    cmd.ExecuteNonQuery();

                    lblMessage.Text = "Record deleted successfully.";

                    ClearFields();
                }
            }

            BindRecords();
        }

        // Clear form fields
        void ClearFields()
        {
            txtGRNo.Text = "";
            txtName.Text = "";
            txtDepartment.Text = "";

            ddlStatus.SelectedIndex = 0;

            ViewState["EditId"] = null;

            btnSave.Text = "Insert";
        }
    }
}
