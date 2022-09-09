using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;

namespace Demo_Project
{
    public partial class Asp_Net_30 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;

        protected void btnUpload_Click(object sender, EventArgs e)
        {
            //FileUpload1.SaveAs(Server.MapPath("~/Upload/"+FileUpload1.FileName));
            //lblMessage.Text = "File Uploaded";
            //;

            if (FileUpload1.HasFile)
            {
                string fileExtension = System.IO.Path.GetExtension(FileUpload1.FileName);

                if (fileExtension.ToLower() != ".mp4" && fileExtension.ToUpper() != ".mp4")
                {
                    lblMessage.ForeColor = System.Drawing.Color.Red;
                    lblMessage.Text = "Only files with .mp4 extension are allowed";
                }
                else
                {
                    // Get the file size
                    int fileSize = FileUpload1.PostedFile.ContentLength;
                    // If file size is greater than 2 MB
                    if (fileSize > 2097152)
                    {
                        lblMessage.ForeColor = System.Drawing.Color.Red;
                        lblMessage.Text = "Your file size is " + fileSize + " it should not be gretaer than 2MB";
                    }
                    else
                    {
                        string str = FileUpload1.FileName;
                        FileUpload1.PostedFile.SaveAs(Server.MapPath("~/Upload/" + str));
                        string Image = "~/Upload/" + str.ToString();
                        string name = TextBox1.Text;

                        SqlConnection con = new SqlConnection(cs);
                        SqlCommand cmd = new SqlCommand("insert into fileupload values(@name,@Image)", con);
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("Image", Image);

                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();

                        lblMessage.Text = "File Uploaded Succesfully ";
                        lblMessage.ForeColor = System.Drawing.Color.Green;
                    }
                }       
            }
            else
            {
                lblMessage.Text = "Please Select a File";
                lblMessage.ForeColor = System.Drawing.Color.DarkRed;
            }
            

        }
    }
}