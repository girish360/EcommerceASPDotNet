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
    string product_name, product_description, product_price, product_qty, product_image;
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
        command.CommandText = "Select * from product where id =" + id + "";

        command.ExecuteNonQuery();
        DataTable dt = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter(command);
        da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                product_name = dr["product_name"].ToString();
                product_description = dr["product_description"].ToString();
                product_price = dr["product_price"].ToString();
                product_qty = dr["product_qty"].ToString();
                product_image = dr["product_image"].ToString();
            }

        connection.Close();
            
        }
    }

    protected void b1_Click(object sender, EventArgs e)
    {
        connection.Open();

        SqlCommand command = connection.CreateCommand();
        command.CommandType = CommandType.Text;
        command.CommandText = "Select * from product where id ="+id+"";

        command.ExecuteNonQuery();
        DataTable dt = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter(command);
        da.Fill(dt);
        d1.DataSource = dt;
        d1.DataBind();


        connection.Close();

        if (Request.Cookies["aa"]==null)
            {
                Response.Cookies["aa"].Value = product_name.ToString() + "," + product_description.ToString() + "," +
                                               product_price.ToString() + "," +
                                               product_qty.ToString() + "," + product_image.ToString();
                Response.Cookies["aa"].Expires = DateTime.Now.AddDays(1);
            }
            else
            {
                Response.Cookies["aa"].Value = Request.Cookies["aa"].Value + "|"+ product_name.ToString() + "," + product_description.ToString() + "," +
                                               product_price.ToString() + "," +
                                               product_qty.ToString() + "," + product_image.ToString();
                Response.Cookies["aa"].Expires = DateTime.Now.AddDays(1);
            }
    }
}