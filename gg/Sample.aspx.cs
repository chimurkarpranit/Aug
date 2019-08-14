using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;
using System.Web.UI.WebControls;

namespace Day_2_4
{
    public partial class Sample : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                gvbind();

            }
        }
        protected void gvbind()
        {
            string connectionstrng = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
            MySqlConnection con = new MySqlConnection(connectionstrng);
            MySqlCommand cmd1 = new MySqlCommand("select EmployeeID,FirstName,LastName,Address,Salary,Notes from employees", con);
            MySqlDataAdapter sda1 = new MySqlDataAdapter();
            sda1.SelectCommand = cmd1;
            DataSet dset = new DataSet();
            sda1.Fill(dset);


            GridView1.DataSource = dset;
            GridView1.DataBind();
        }
        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            gvbind();
        }
        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            gvbind();
        }
        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string connectionstrng = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
            MySqlConnection conn = new MySqlConnection(connectionstrng);
            GridViewRow row = (GridViewRow)GridView1.Rows[e.RowIndex];
            Label lbldeleteid = (Label)row.FindControl("lblID");
            conn.Open();
          // MySqlCommand cmd = new MySqlCommand();
           //cmd.ExecuteNonQuery();
            MySqlCommand cmd1 = new MySqlCommand("SET FOREIGN_KEY_CHECKS = 0;" + "delete FROM employees where EmployeeID=" + Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString()) + "", conn);
            cmd1.ExecuteNonQuery();
            //MySqlCommand cmd3 = new MySqlCommand("SET FOREIGN_KEY_CHECKS = 1;");
            //cmd3.ExecuteNonQuery();
            conn.Close();
            gvbind();
        }
        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            string connectionstrng = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
            MySqlConnection conn = new MySqlConnection(connectionstrng);
            int userid = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
            GridViewRow row = (GridViewRow)GridView1.Rows[e.RowIndex];
            Label lblID = (Label)row.FindControl("lblID");
              
            TextBox textFirstName = (TextBox)row.Cells[1].Controls[0];
            TextBox textLastName = (TextBox)row.Cells[2].Controls[0];
            TextBox textadd = (TextBox)row.Cells[3].Controls[0];
            TextBox textsalary = (TextBox)row.Cells[4].Controls[0];
            TextBox textnotes= (TextBox)row.Cells[5].Controls[0];

            GridView1.EditIndex = -1;
            conn.Open();
              
            MySqlCommand cmd = new MySqlCommand("update employees set FirstName='" + textFirstName.Text + "',LastName='" + textLastName.Text + "',address='" + textadd.Text + "',Salary='" + textsalary.Text + "',Notes='" + textnotes.Text + "' where EmployeeID='" + userid + "'", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            gvbind();
             
        }
        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e) 
        {
            GridView1.EditIndex = e.NewEditIndex;
            gvbind();
        }
        protected void Insert(object sender, EventArgs e)
        {
            
            string Fname = txtFirstName.Text;
            string Lname = txtLastName.Text;
            string address = txtAddress.Text;
            string salary = txtSalary.Text;
            string notes = txtNotes.Text;
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtAddress.Text = "";
            txtSalary.Text = "";
            txtNotes.Text = "";
            //string query = "INSERT INTO employees VALUES(@FirstName, @LastName, @Address, @Salary, @Notes)";
            string constr = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
            MySqlConnection con = new MySqlConnection(constr);
            MySqlCommand cmd = new MySqlCommand("INSERT INTO employees(FirstName, LastName, Address, Salary, Notes ) VALUES ( " + "'" + Fname + "'" +  "," + "'" + Lname + "'" + "," + "'" + address + "'" + "," + salary + "," + "'" + notes + "'" + ")", con);
            //cmd.Parameters.AddWithValue("@FirstName", Fname);
            //cmd.Parameters.AddWithValue("@LastName", Lname);
            //cmd.Parameters.AddWithValue("@Address", address);
            //cmd.Parameters.AddWithValue("@Salary", salary);
            //cmd.Parameters.AddWithValue("@Notes", notes);
            //cmd.Connection = con;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            gvbind();



        }

    }
    }
    
    
