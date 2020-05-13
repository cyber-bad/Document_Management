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
    public partial class WebForm1 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
                            
            if (Session["User"] == null)
            {

                Response.Redirect("index.aspx");

            }
            else
            {

                String constring = "Data Source=DESKTOP-JJ67CI8\\SQLEXPRESS; Initial Catalog=forchash; Integrated Security=true";
                SqlConnection sqlcon = new SqlConnection(constring);

                String squery = "select * from admin where email ='" + Session["user"] + "'";
                SqlCommand cmd = new SqlCommand(squery, sqlcon);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                sda.Fill(dt);

                Label2.Text = dt.Rows[0][0].ToString();

                sqlcon.Close();
                sda.Dispose();

                Image1.ImageUrl = "~/images/noAvail.jpg";
                Image1_1.ImageUrl = "~/images/noAvail.jpg";

                Image2.ImageUrl = "~/images/noAvail.jpg";
                Image2_2.ImageUrl = "~/images/noAvail.jpg";
                Image3.ImageUrl = "~/images/noAvail.jpg";
                Image3_3.ImageUrl = "~/images/noAvail.jpg";
                Image4.ImageUrl = "~/images/noAvail.jpg";
                Image4_4.ImageUrl = "~/images/noAvail.jpg";
                Image5.ImageUrl = "~/images/noAvail.jpg";
                Image5_5.ImageUrl = "~/images/noAvail.jpg";
                Image6.ImageUrl = "~/images/noAvail.jpg";
                Image6_6.ImageUrl = "~/images/noAvail.jpg";

            }

        }
                         

        bool flag = false;
        String info = "";
        protected void Button2_Click(object sender, EventArgs e)
        {
            String constring = "Data Source=DESKTOP-JJ67CI8\\SQLEXPRESS; Initial Catalog=forchash; Integrated Security=true";
            SqlConnection sqlcon = new SqlConnection(constring);

            String squery = "select * from doc where clientId ='"+ TextBox3.Text +"' or identityNum = '" + TextBox3.Text +"'";
            SqlCommand cmd = new SqlCommand(squery, sqlcon);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
                      
            DataTable dt = new DataTable();

            sda.Fill(dt);


            if (dt.Rows.Count > 0)
            {

                Image1.ImageUrl = dt.Rows[0][0].ToString();
                Image1_1.ImageUrl = dt.Rows[0][0].ToString();

                Image2.ImageUrl = dt.Rows[0][1].ToString();
                Image2_2.ImageUrl = dt.Rows[0][1].ToString();
                Image3.ImageUrl = dt.Rows[0][2].ToString();
                Image3_3.ImageUrl = dt.Rows[0][2].ToString();
                Image4.ImageUrl = dt.Rows[0][3].ToString();
                Image4_4.ImageUrl = dt.Rows[0][3].ToString();
                Image5.ImageUrl = dt.Rows[0][4].ToString();
                Image5_5.ImageUrl = dt.Rows[0][4].ToString();
                Image6.ImageUrl = dt.Rows[0][5].ToString();
                Image6_6.ImageUrl = dt.Rows[0][5].ToString();

                firstName.Text = dt.Rows[0][10].ToString();
                lastName.Text = dt.Rows[0][11].ToString();
                Email.Text = dt.Rows[0][12].ToString();
                IdentityNum.Text = dt.Rows[0][6].ToString();
                IncomeNum.Text = dt.Rows[0][7].ToString();
                addressNum.Text = dt.Rows[0][8].ToString();
                relationNum.Text = dt.Rows[0][9].ToString();
                

                sqlcon.Close();
                sda.Dispose();
                Label1.Text = "";
            }

            else
            {
                Label1.Text = "Enter Valid Credentials";

                firstName.Text = "";
                lastName.Text = "";
                Email.Text = "";
                IdentityNum.Text = "";
                addressNum.Text = "";
                relationNum.Text = "";

                Image1.ImageUrl = "~/images/noAvail.jpg";
                Image1_1.ImageUrl = "~/images/noAvail.jpg";

                Image2.ImageUrl = "~/images/noAvail.jpg";
                Image2_2.ImageUrl = "~/images/noAvail.jpg";
                Image3.ImageUrl = "~/images/noAvail.jpg";
                Image3_3.ImageUrl = "~/images/noAvail.jpg";
                Image4.ImageUrl = "~/images/noAvail.jpg";
                Image4_4.ImageUrl = "~/images/noAvail.jpg";
                Image5.ImageUrl = "~/images/noAvail.jpg";
                Image5_5.ImageUrl = "~/images/noAvail.jpg";
                Image6.ImageUrl = "~/images/noAvail.jpg";
                Image6_6.ImageUrl = "~/images/noAvail.jpg";

                firstName.Text = "";
                lastName.Text = "";
                Email.Text = "";
                IdentityNum.Text = "";
                IncomeNum.Text = "";
                addressNum.Text = "";
                relationNum.Text = "";

                TextBox3.Text = "";
                
               
            }
                

        }

        protected void Button5_Click(object sender, EventArgs e)
        {

            String constring = "Data Source=DESKTOP-JJ67CI8\\SQLEXPRESS; Initial Catalog=forchash; Integrated Security=true";
            SqlConnection sqlcon = new SqlConnection(constring);


            

            String squery = "Update doc set firstName ='" + firstName.Text + "' , lastName ='" + lastName.Text + "' , email ='" + Email.Text + "' , identityNum = '" + IdentityNum.Text + "' , incomeNum = '" + IncomeNum.Text + "' , addressNum = '" + addressNum.Text + "' , relationNum = '" + relationNum.Text + "' where clientId = '" + TextBox3.Text +"' or identityNum = '" + TextBox3.Text +"'";
            SqlCommand cmd = new SqlCommand(squery, sqlcon);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            sda.Fill(dt);

            sqlcon.Close();
            sda.Dispose();
            TextBox3.Text = "";
            Label1.Text = "Sussfully Update";

        }

       
        protected void Button6_Click(object sender, EventArgs e)
        {
            

            String constring = "Data Source=DESKTOP-JJ67CI8\\SQLEXPRESS; Initial Catalog=forchash; Integrated Security=true";
            SqlConnection sqlcon = new SqlConnection(constring);
            
            String squery = "DELETE from doc where clientId ='" + TextBox3.Text + "' or identityNum = '" + TextBox3.Text + "'";
            SqlCommand cmd = new SqlCommand(squery, sqlcon);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            sda.Fill(dt);

            sqlcon.Close();
            sda.Dispose();
            TextBox3.Text = "";
            Label1.Text = "Sussfully Removed";

            firstName.Text = "";
            lastName.Text = "";
            Email.Text = "";
            IdentityNum.Text = "";
            addressNum.Text = "";
            relationNum.Text = "";

            Image1.ImageUrl = "~/images/noAvail.jpg";
            Image1_1.ImageUrl = "~/images/noAvail.jpg";

            Image2.ImageUrl = "~/images/noAvail.jpg";
            Image2_2.ImageUrl = "~/images/noAvail.jpg";
            Image3.ImageUrl = "~/images/noAvail.jpg";
            Image3_3.ImageUrl = "~/images/noAvail.jpg";
            Image4.ImageUrl = "~/images/noAvail.jpg";
            Image4_4.ImageUrl = "~/images/noAvail.jpg";
            Image5.ImageUrl = "~/images/noAvail.jpg";
            Image5_5.ImageUrl = "~/images/noAvail.jpg";
            Image6.ImageUrl = "~/images/noAvail.jpg";
            Image6_6.ImageUrl = "~/images/noAvail.jpg";

            firstName.Text = "";
            lastName.Text = "";
            Email.Text = "";
            IdentityNum.Text = "";
            IncomeNum.Text = "";
            addressNum.Text = "";
            relationNum.Text = "";


        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            firstName.Text = "";
            lastName.Text = "";
            Email.Text = "";
            IdentityNum.Text = "";
            addressNum.Text = "";
            relationNum.Text = "";

            Image1.ImageUrl = "~/images/noAvail.jpg";
            Image1_1.ImageUrl = "~/images/noAvail.jpg";

            Image2.ImageUrl = "~/images/noAvail.jpg";
            Image2_2.ImageUrl = "~/images/noAvail.jpg";
            Image3.ImageUrl = "~/images/noAvail.jpg";
            Image3_3.ImageUrl = "~/images/noAvail.jpg";
            Image4.ImageUrl = "~/images/noAvail.jpg";
            Image4_4.ImageUrl = "~/images/noAvail.jpg";
            Image5.ImageUrl = "~/images/noAvail.jpg";
            Image5_5.ImageUrl = "~/images/noAvail.jpg";
            Image6.ImageUrl = "~/images/noAvail.jpg";
            Image6_6.ImageUrl = "~/images/noAvail.jpg";

            firstName.Text = "";
            lastName.Text = "";
            Email.Text = "";
            IdentityNum.Text = "";
            IncomeNum.Text = "";
            addressNum.Text = "";
            relationNum.Text = "";

            TextBox3.Text = "";
            Label1.Text = "";
                       


        }

        protected void picUpdate_Click(object sender, EventArgs e)
        {
            String constring = "Data Source=DESKTOP-JJ67CI8\\SQLEXPRESS; Initial Catalog=forchash; Integrated Security=true";
            SqlConnection sqlcon = new SqlConnection(constring);

            if (photoUpdate.FileName != "")
            {
                photoUpdate.SaveAs(Server.MapPath("~/images/") + Path.GetFileName(photoUpdate.FileName));
                String linkphoto = "images/" + Path.GetFileName(photoUpdate.FileName);

                String squery = "Update doc set photo = '" + linkphoto + "' where clientId = '" + TextBox3.Text + "' or identityNum = '" + TextBox3.Text + "'";
                SqlCommand cmd = new SqlCommand(squery, sqlcon);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                sda.Fill(dt);

                sqlcon.Close();
                sda.Dispose();

                Label1.Text = "Photo Document Update Sussfully";
            }
            else
            {
                Label1.Text = "Select Image";
            }
            
        }

        protected void signPicUpdate_Click(object sender, EventArgs e)
        {
            String constring = "Data Source=DESKTOP-JJ67CI8\\SQLEXPRESS; Initial Catalog=forchash; Integrated Security=true";
            SqlConnection sqlcon = new SqlConnection(constring);

            if (signUpdate.FileName != "")
            {
                signUpdate.SaveAs(Server.MapPath("~/images/") + Path.GetFileName(signUpdate.FileName));
                String linkSign = "images/" + Path.GetFileName(signUpdate.FileName);

                String squery = "Update doc set sign = '" + linkSign + "' where clientId = '" + TextBox3.Text + "' or identityNum = '" + TextBox3.Text + "'";
                SqlCommand cmd = new SqlCommand(squery, sqlcon);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                sda.Fill(dt);

                sqlcon.Close();
                sda.Dispose();

                Label1.Text = "Sign Document Update Sussfully";

            }
            else
            {
                Label1.Text = "Select Image";
            }
            
        }

        protected void idPicUpdate_Click(object sender, EventArgs e)
        {
            String constring = "Data Source=DESKTOP-JJ67CI8\\SQLEXPRESS; Initial Catalog=forchash; Integrated Security=true";
            SqlConnection sqlcon = new SqlConnection(constring);

            if (identityUpdate.FileName !="")
            {
                identityUpdate.SaveAs(Server.MapPath("~/images/") + Path.GetFileName(identityUpdate.FileName));
                String linkid = "images/" + Path.GetFileName(identityUpdate.FileName);

                String squery = "Update doc set identity = '" + linkid + "' where clientId = '" + TextBox3.Text + "' or identityNum = '" + TextBox3.Text + "'";
                SqlCommand cmd = new SqlCommand(squery, sqlcon);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                sda.Fill(dt);

                sqlcon.Close();
                sda.Dispose();

                Label1.Text = "Identity Document Update Sussfully";

            }
            else
            {
                Label1.Text = "Select Image";
            }


        }

        protected void incomePicUpdate_Click(object sender, EventArgs e)
        {
            String constring = "Data Source=DESKTOP-JJ67CI8\\SQLEXPRESS; Initial Catalog=forchash; Integrated Security=true";
            SqlConnection sqlcon = new SqlConnection(constring);

            if (incomeUpdate.FileName !="")
            {
                incomeUpdate.SaveAs(Server.MapPath("~/images/") + Path.GetFileName(incomeUpdate.FileName));
                String linkincome = "images/" + Path.GetFileName(incomeUpdate.FileName);

                String squery = "Update doc set income = '" + linkincome + "' where clientId = '" + TextBox3.Text + "' or identityNum = '" + TextBox3.Text + "'";
                SqlCommand cmd = new SqlCommand(squery, sqlcon);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                sda.Fill(dt);

                sqlcon.Close();
                sda.Dispose();

                Label1.Text = "Income Document Update Sussfully";

            }
            else
            {
                Label1.Text = "Select Image";
            }


        }

        protected void addressPicUpdate_Click(object sender, EventArgs e)
        {
            String constring = "Data Source=DESKTOP-JJ67CI8\\SQLEXPRESS; Initial Catalog=forchash; Integrated Security=true";
            SqlConnection sqlcon = new SqlConnection(constring);

            if (addressUpdate.FileName !="")
            {

                addressUpdate.SaveAs(Server.MapPath("~/images/") + Path.GetFileName(addressUpdate.FileName));
                String linkaddress = "images/" + Path.GetFileName(addressUpdate.FileName);

                String squery = "Update doc set address = '" + linkaddress + "' where clientId = '" + TextBox3.Text + "' or identityNum = '" + TextBox3.Text + "'";
                SqlCommand cmd = new SqlCommand(squery, sqlcon);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                sda.Fill(dt);

                sqlcon.Close();
                sda.Dispose();

                Label1.Text = "Address Document Update Sussfully";
            }
            else
            {
                Label1.Text = "Select Image";
            }


        }

        protected void relationPicUpdate_Click(object sender, EventArgs e)
        {
            String constring = "Data Source=DESKTOP-JJ67CI8\\SQLEXPRESS; Initial Catalog=forchash; Integrated Security=true";
            SqlConnection sqlcon = new SqlConnection(constring);

            if (relationUpdate.FileName !="")

            {
                relationUpdate.SaveAs(Server.MapPath("~/images/") + Path.GetFileName(relationUpdate.FileName));
                String linkrelation = "images/" + Path.GetFileName(relationUpdate.FileName);

                String squery = "Update doc set relation = '" + linkrelation + "' where clientId = '" + TextBox3.Text + "' or identityNum = '" + TextBox3.Text + "'";
                SqlCommand cmd = new SqlCommand(squery, sqlcon);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                sda.Fill(dt);

                sqlcon.Close();
                sda.Dispose();

                Label1.Text = " Relation Document Update Sussfully ";
            }
            else
            {
                Label1.Text = "Select Image";
            }

        }

        protected void signOut_Click(object sender, EventArgs e)
        {

        }
    }
}