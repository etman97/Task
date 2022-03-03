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
    public partial class register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnregister_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["marketcon"].ConnectionString);
            SqlCommand cmd = new SqlCommand("insert into Customers(CustomerName,FristName,LastName,PhoneNumber,Address,PostalCode,Email,Password) values(@CustomerName,@FristName,@LastName,@PhoneNumber,@Address,@PostalCode,@Email,@Password)", con);
            cmd.Parameters.AddWithValue("CustomerName", txt_cutomerName.Text);
            cmd.Parameters.AddWithValue("FristName", txt_fname.Text);
            cmd.Parameters.AddWithValue("LastName", txt_lname.Text);
            cmd.Parameters.AddWithValue("PhoneNumber", txt_phonenumber.Text);
            cmd.Parameters.AddWithValue("Address", txt_address.Text);
            cmd.Parameters.AddWithValue("PostalCode", txt_postalCode.Text);
            cmd.Parameters.AddWithValue("Email", txt_email.Text);
            cmd.Parameters.AddWithValue("Password", txt_password.Text);


            con.Open();
            if (cmd.ExecuteNonQuery() > 0)
            {
                lbl_stetus.Text = "scusses";
            }
            con.Close();
        }
    }
}