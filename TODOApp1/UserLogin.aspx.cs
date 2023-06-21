using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using System.IO;

namespace TODOApp1
{
    public partial class UserLogin : System.Web.UI.Page
    {
        Hashtable users = new Hashtable();

        protected void Page_Load(object sender, EventArgs e)
        {
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
            string user = TextBox1.Text;
            string pass = (string)users[user];

            if (users.ContainsKey(user) && TextBox2.Text.Equals(pass))
            {
                Response.Redirect("Todo.aspx");
            }
            else {
                Output.Text = "Invalid username & password";
            }
            
        }
    }
}