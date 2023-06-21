using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace TODOApp1
{
    public partial class AdminLogin : System.Web.UI.Page
    {
        string user, pass;

        protected void Page_Load(object sender, EventArgs e)
        {
            string path = Server.MapPath("admin.txt");
            var fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
            using (var streamReader = new StreamReader(fileStream))
            {
                string text = streamReader.ReadToEnd();
                user = text.Split(',')[0];
                pass = text.Split(',')[1];
                streamReader.Close();
            }
            fileStream.Close();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox2.Text.Equals(user) && TextBox3.Text.Equals(pass))
            {
                Response.Redirect("CreateUsers.aspx");
            }
            else {
                Output.Text = "Invalid user and password";
            }
        }
    }
}