using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ReceiptTask
{
    public partial class Market : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["marketcon"].ConnectionString);
                SqlCommand cmd = new SqlCommand("select * from Products", con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                ddl_productsItems.DataSource = dr;
                ddl_productsItems.DataTextField = "Name";
                ddl_productsItems.DataValueField = "ProductID";
                ddl_productsItems.DataBind();

                con.Close();
            }
        }

        protected void btn_addorderItem_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["marketcon"].ConnectionString);
           
            SqlCommand cmd = new SqlCommand("select Price from Products where ProductID=@ProductID ", con);
            cmd.Parameters.AddWithValue("ProductID", ddl_productsItems.SelectedValue);
            con.Open();
            object rd = cmd.ExecuteScalar();
            int productPrice = int.Parse(rd.ToString());
            con.Close();

            SqlCommand cmd2 = new SqlCommand("insert into OrderDetails(OrderID,ProductID,EachPrice,QuantityOrdered)" +
                " values(@OrderID,@ProductID,@EachPrice,@QuantityOrdered)", con);
            cmd2.Parameters.AddWithValue("OrderID", Session["OrderID"].ToString());
            cmd2.Parameters.AddWithValue("ProductID", ddl_productsItems.SelectedValue);
            cmd2.Parameters.AddWithValue("EachPrice", productPrice);
            cmd2.Parameters.AddWithValue("QuantityOrdered", txt_quantity.Text);


            con.Open();
            cmd2.ExecuteNonQuery();
            con.Close();

        }

        protected void btn_receipt_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["marketcon"].ConnectionString);
            SqlCommand cmd = new SqlCommand("select P.Name ,OD.EachPrice ,OD.QuantityOrdered ,OD.TotalPrice from OrderDetails OD , Products P where P.ProductID = OD.ProductID and OD.OrderID = @OrderID", con);
            cmd.Parameters.AddWithValue("OrderID", Session["OrderID"].ToString());
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            gv_orderItems.DataSource = dr;
            gv_orderItems.DataBind();
            con.Close();

            SqlCommand cmd2 = new SqlCommand("select Customers.CustomerName ,Orders.OrderDate ,Orders.Status ,Orders.TotalOrderedPrice from Orders inner join Customers on Orders.CustomerID = Customers.CustomerID where OrderID = @OrderID", con);
            cmd2.Parameters.AddWithValue("OrderID", Session["OrderID"].ToString());
            con.Open();
            SqlDataReader dr2 = cmd2.ExecuteReader();
            gv_order.DataSource = dr2;
            gv_order.DataBind();
            con.Close();


        }

        protected void btn_logout_Click(object sender, EventArgs e)
        {
            Session.Remove("OrderID");
            Response.Redirect("~/login.aspx");
        }
    }
}