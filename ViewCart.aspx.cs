using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class ViewCart : System.Web.UI.Page
{
    string s;
    string t;
    string[] a = new string[5];
    
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void b1_Click(object sender, EventArgs e)
    {
        string[] strArr1 = new string[5];
        DataTable dt = new DataTable();
        dt.Columns.AddRange(new DataColumn[5] { new DataColumn("product_name"), new DataColumn("product_description"), new DataColumn("product_price"), new DataColumn("product_qty"), new DataColumn("product_image") });
        if (Request.Cookies["aa"] != null)
        {
            s = Convert.ToString(Request.Cookies["aa"].Value);
            strArr1 = s.Split('|');

            for (int i = 0; i < strArr1.Length; i++)
            {
               // strArr1 = new string[] {};
                t = Convert.ToString(strArr1[i].ToString());
                strArr1 = t.Split(',');

                for (int j = 0; j < strArr1.Length; j++)
                {
                    a[j] = strArr1[j].ToString();
                }

                dt.Rows.Add(a[0].ToString(), a[1].ToString(), a[2].ToString(), a[3].ToString(), a[4].ToString());
            }
        }
        d1.DataSource = dt;
        d1.DataBind();
    }

    public int strArr1 { get; set; }
}