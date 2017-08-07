using System;
using System.Activities.Statements;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class user_ProductDescription : System.Web.UI.Page
{
    SqlConnection connection = new SqlConnection(@"Server=ASIFNEWAZ\SQLEXPRESS; Database=Ecommerce; Integrated Security=True ");
    int id;
    protected void Page_Load(object sender, EventArgs e)
    {
        if(Request.QueryString["id"]==null)
        {
            Response.Redirect("DisplayItem.aspx");
        }
    else
        {
            
    
        id = Convert.ToInt32(Request.QueryString["id"].ToString());
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
}