//Created By : Aditya Mhetre
//Date : 2019/08/13
//Description : To load employee table and display records 
using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;

namespace Day_2_4
{
    public partial class Default_4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //databse connection
            string connectionstrng = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
            MySqlConnection con = new MySqlConnection(connectionstrng);
            MySqlCommand cmd1 = new MySqlCommand("select EmployeeID,FirstName,LastName,Address,Salary from employees", con);
            MySqlDataAdapter sda1 = new MySqlDataAdapter();
            sda1.SelectCommand = cmd1;
            //dataset 
            DataSet dset = new DataSet();
            sda1.Fill(dset, "employees");

            //store table employee in session
            Session["Employees"] = dset.Tables["employees"];

            //bind the data to gridview
            GridView1.DataSource = Session["Employees"];
            GridView1.DataBind();
        }
    }
}