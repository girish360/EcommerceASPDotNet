using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class user_deleteCart : System.Web.UI.Page
{
    string s;
    string t;
    string[] a = new string[5];
    int id;
    string product_name, product_description, product_price, product_qty, product_image;
    int count = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        id = Convert.ToInt32(Request.QueryString["id"].ToString());
    }
}