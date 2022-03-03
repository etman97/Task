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
    public partial class AddProducts : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_addProduct_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["marketcon"].ConnectionString);
            SqlCommand cmd = new SqlCommand("insert into Products(Name,Description,Quantity,Price,Position) values(@Name,@Description,@Quantity,@Price,@Position)", con);
            cmd.Parameters.AddWithValue("Name", txt_name.Text);
            cmd.Parameters.AddWithValue("Description", txt_descrption.Text);
            cmd.Parameters.AddWithValue("Quantity", txt_quantity.Text);
            cmd.Parameters.AddWithValue("Price", txt_price.Text);
            cmd.Parameters.AddWithValue("Position", txt_postion.Text);
            con.Open();
            if (cmd.ExecuteNonQuery()>0)
            {
                lbl_stetus.Text = "scusses";
            }
            con.Close();
        }
    }
}