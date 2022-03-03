using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;


namespace ReceiptTask
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void btn_login_Click1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["marketcon"].ConnectionString);
            SqlCommand cmd = new SqlCommand("select CustomerID from Customers where Email=@Email and Password=@Password", con);

            if (txt_email.Text != "" && txt_password.Text != "")
            {
                cmd.Parameters.AddWithValue("Email", txt_email.Text);
                cmd.Parameters.AddWithValue("Password", txt_password.Text);
                con.Open();
                object rd = cmd.ExecuteScalar();
                if ( rd != null)
                {
                    Label1.Text = "correct";
                    con.Close();

                    SqlCommand cmd2 = new SqlCommand("insert into Orders(CustomerID,OrderDate,Status,TotalOrderedPrice) values(@CustomerID,@OrderDate,@Status,@TotalOrderedPrice)", con);
                    cmd2.Parameters.AddWithValue("CustomerID", rd.ToString());
                    cmd2.Parameters.AddWithValue("OrderDate", DateTime.Now);
                    cmd2.Parameters.AddWithValue("Status", "Shopping");
                    cmd2.Parameters.AddWithValue("TotalOrderedPrice", 0);
       
                    con.Open();
                    cmd2.ExecuteNonQuery();
                    con.Close();

                    SqlCommand cmd3 = new SqlCommand("select OrderID from Orders where CustomerID = @CustomerID",con);
                    cmd3.Parameters.AddWithValue("CustomerID", rd.ToString());
                    
                    con.Open();
                    object rd2 = cmd3.ExecuteScalar();
                    Session.Add("OrderID", rd2);
                    con.Close();

                    Response.Redirect("~/Market.aspx");
                }
                else Label1.Text = "error";
                con.Close();
            }
            else Label1.Text = "error";
        }
    }
}