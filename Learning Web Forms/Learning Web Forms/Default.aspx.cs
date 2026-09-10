using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Learning_Web_Forms
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindGrid();
            }    
        }

        
        private void BindGrid()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Roll No.");
            dt.Columns.Add("Name");
            dt.Rows.Add("1", "Adi");
            dt.Rows.Add("2", "Chirag");
            dt.Rows.Add("3", "Jeet");
            dg.DataSource = dt;
            dg.DataBind();
            
            gv.DataSource = dt;
            gv.DataBind();
        }
     
        protected void ad_AdCreated(object sender, AdCreatedEventArgs e)
        {
            sponsor.Text = "Source = " + e.AlternateText;
        }

        protected void dg_PageIndexChanged(object source, DataGridPageChangedEventArgs e)
        {
            dg.CurrentPageIndex = e.NewPageIndex;
            BindGrid();
        }

        protected void gv_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gv.PageIndex = e.NewPageIndex;
            BindGrid();
        }
    }
}