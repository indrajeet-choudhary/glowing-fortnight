using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Appointment
{
    public partial class Register : System.Web.UI.Page
    {
        string name;
        string email;
        string password;
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
            }
            catch (Exception error)
            {
                Response.Write("Hello" + error.Message);
            }

        }
        protected void btnSubmit_Click(Object sender, EventArgs e)
        {
            name = txtname.Text;
            email = txtemail.Text;
            password = txtpass2.Text;
            try
            {
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnect"].ConnectionString);
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "CREATE TABLE [dbo].[register](" +
                    "[Userid] INT IDENTITY(1001, 1) NOT NULL," +
                    "[Name] VARCHAR(50) NOT NULL," +
                    "[Mail] VARCHAR(50) NOT NULL," +
                    "[Password] VARCHAR(16) NOT NULL," +
                    "PRIMARY KEY CLUSTERED([Userid] ASC));";
                cmd.CommandText = "insert into register values ('" + name + "','" + email + "','" + password + "')";
                cmd.ExecuteNonQuery();
                Message.Text = "Insert Success";
            }
            catch (Exception error)
            {
                Message.Text = "Insert declined:" + error;
            }
        }
        protected void btnCancel_Click(Object sender, EventArgs e)
        {

        }
    }
}