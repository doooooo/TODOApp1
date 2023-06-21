using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Diagnostics;
using System.Collections;

namespace TODOApp1
{
    public partial class CreateUsers : System.Web.UI.Page
    {
        Hashtable users = new Hashtable();
        protected void Page_Load(object sender, EventArgs e)
        {
            Output.Text = "";

            try
            {
                string path = Server.MapPath("users.txt");

                string[] userstxt = File.ReadAllLines(path);

                foreach (var user in userstxt)
                {
                    string username = user.Split(',')[0];
                    string password = user.Split(',')[1];
                    users.Add(username, password);

                }
            }
            catch (Exception)
            {
                Output.Text = "Error occured";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (users[TextBox1.Text] != null)
                    Output.Text = "User already exist";
                else
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
            }
            catch (Exception ex) {
                Output.Text = "Error occurred";
                Debug.WriteLine(ex.ToString());
            }
        }
    }
}