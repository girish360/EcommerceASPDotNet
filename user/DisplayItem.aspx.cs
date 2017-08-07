using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class user_DisplayItem : System.Web.UI.Page
{
    SqlConnection connection = new SqlConnection(@"Server=ASIFNEWAZ\SQLEXPRESS; Database=Ecommerce; Integrated Security=True ");

    protected void Page_Load(object sender, EventArgs e)
    {
        connection.Open();

        SqlCommand command = connection.CreateCommand();
        command.CommandType = CommandType.Text;
        command.CommandText = "Select * from product";

        command.ExecuteNonQuery();
        DataTable dt = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter(command);
        da.Fill(dt);
        d1.DataSource = dt;
        d1.DataBind();


        connection.Close();
    }
}