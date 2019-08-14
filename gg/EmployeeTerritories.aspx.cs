//Created By : Aditya Mhetre
//Date : 2019/08/13
//Description : To load employee table and employeeterriotries display matching records 
using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;

namespace Day_2_4
{
    public partial class EmployeeTerritories : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                //index of employee table record
                string var = Request.QueryString["EmployeeID"];
                int id = Convert.ToInt32(var);

                //database connection
                string connectionstrng = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
                MySqlConnection con = new MySqlConnection(connectionstrng);

                //sql query to display macthing records
                MySqlCommand cmd1 = new MySqlCommand("select * from employeeterritories WHERE EmployeeID=" + id + " ", con);
                MySqlDataAdapter sda1 = new MySqlDataAdapter();
                sda1.SelectCommand = cmd1;
                DataSet dset = new DataSet();
                sda1.Fill(dset);
                GridView1.DataSource = dset;
                GridView1.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }
    }
    }
