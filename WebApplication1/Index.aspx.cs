using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.IO;
using System.Data;
using System.Drawing;

namespace WebApplication1
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            

        }
                      


        protected void logIn_Click(object sender, EventArgs e)
        {


            String user = email.Text.Trim();

            String constring = "Data Source=DESKTOP-JJ67CI8\\SQLEXPRESS; Initial Catalog=forchash; Integrated Security=true";
            SqlConnection sqlcon = new SqlConnection(constring);

            String squery = "select * from admin where email ='" + email.Text + "' AND password = '" + Password.Text + "'";
            SqlCommand cmd = new SqlCommand(squery, sqlcon);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            sda.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                Session["user"] = user;
                Response.Redirect("WebForm1.aspx");
                
            }
            else
            {
                Label1.Text = "Invalid Credentials";
                email.Text = "";
                Password.Text = "";

            }


            sqlcon.Close();
            sda.Dispose();
            

        }
    }
}