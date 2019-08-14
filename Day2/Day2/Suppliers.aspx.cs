using System;
using System.Collections;
using System.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Day2
{
    public partial class Suppliers : System.Web.UI.Page
    {
        SupplierService ss;
        ArrayList arr;
        string conString = ConfigurationManager.ConnectionStrings["DBConnection"].ToString();
        protected void Page_Load(object sender, EventArgs e) //Page Load Method
        {
            if (!Page.IsPostBack)
            {
                BindGridView();
            }
        }
        protected void BindGridView()  // For Populating the GridView with Database
        {
            try
            {
                ss = new SupplierService();
                arr = ss.GetSuppliers();
                GridView1.DataSource = arr;
                GridView1.DataBind();
            }
            catch(Exception ex)
            {
                Response.Write(ex.Message);
            }
        }
        protected void OnPageIndexChanging(object sender, GridViewPageEventArgs e)  // For Clicking on Page Number
        {
            GridView1.PageIndex = e.NewPageIndex;
            BindGridView();
        }
    }
}