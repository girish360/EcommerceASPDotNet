using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class AddProduct : System.Web.UI.Page
{
    
    String a, b;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void b1_Click(object sender, EventArgs e)
    {
        string connectionString = @"Server=ASIFNEWAZ\SQLEXPRESS; Database=Ecommerce; Integrated Security=True ";
        SqlConnection connection = new SqlConnection(connectionString);

        a = Class1.GetRandomPassword(10).ToString();

        fu1.SaveAs(Request.PhysicalApplicationPath+"./images/"+a+fu1.FileName.ToString());
        b = "images/" + a + fu1.FileName.ToString();

        connection.Open();

        SqlCommand command = connection.CreateCommand();
        command.CommandType = CommandType.Text;
        command.CommandText = "insert into product values('"+t1.Text+"','"+t2.Text+"',"+t3.Text+","+t4.Text+",'"+b.ToString()+"')";

        command.ExecuteNonQuery();

        connection.Close();
    }
}