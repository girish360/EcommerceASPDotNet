using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class admin_AdminLogin : System.Web.UI.Page
{
    int i;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void b1_Click(object sender, EventArgs e)
    {
        i = 0;
        string connectionString = @"Server=ASIFNEWAZ\SQLEXPRESS; Database=Ecommerce; Integrated Security=True ";
        SqlConnection connection = new SqlConnection(connectionString);

        connection.Open();

        SqlCommand command = connection.CreateCommand();
        command.CommandType = CommandType.Text;
        command.CommandText = "Select * from adminLogin where username = '"+t1.Text+"' and password = '"+t2.Text+"'";

        command.ExecuteNonQuery();

        DataTable dt = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter(command);

        da.Fill(dt);
        i = Convert.ToInt32(dt.Rows.Count.ToString());

        if (i == 1)
        {
            Response.Redirect("TestAdmin.aspx");
        }
        else
        {
            l1.Text = "Invalid User Name Or Password";
        }
        connection.Close();


    }
}