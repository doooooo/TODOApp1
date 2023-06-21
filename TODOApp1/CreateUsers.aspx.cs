using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Diagnostics;

namespace TODOApp1
{
    public partial class CreateUsers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Output.Text = "";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                string path = Server.MapPath("users.txt");
                //var fileStream = new FileStream(path, FileMode.Open, FileAccess.Write);
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine(TextBox1.Text + "," + TextBox2.Text);
                    sw.Close();
                }
                //fileStream.Close();
                Output.Text = "User created successfully";
            }
            catch (Exception ex) {
                Output.Text = "Error occurred";
                Debug.WriteLine(ex.ToString());
            }
        }
    }
}