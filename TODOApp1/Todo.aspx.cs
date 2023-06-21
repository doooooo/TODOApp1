using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace TODOApp1
{
    public partial class Todo : System.Web.UI.Page
    {
        Stack<string> stack
        {
            get { return (Stack<string>)Session["stackList"]; }
            set { Session["stackList"] = value; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                try
                {
                    Output.Text = "";

                    if (stack == null)
                        stack = new Stack<string>();

                    string path = Server.MapPath("todo.txt");

                    string[] todolist = File.ReadAllLines(path);

                    foreach (var todo in todolist)
                    {
                        stack.Push(todo);
                    }

                    ListBox1.DataSource = stack;
                    ListBox1.DataBind();
                }
                catch (Exception) { }
            }
        }

        protected void Add_Click(object sender, EventArgs e)
        {
            stack.Push(TextBox1.Text);
            ListBox1.DataSource = stack;
            ListBox1.DataBind();
        }

        protected void Search_Click(object sender, EventArgs e)
        {
            if (stack.Contains(TextBox2.Text))
                Output.Text = "Item found";
            else
                Output.Text = "Item not found";
        }

        protected void Last_Click(object sender, EventArgs e)
        {
            string last = stack.Peek();
            Output.Text = "Last item is: " + last;
        }

        protected void Remove_Click(object sender, EventArgs e)
        {
            string item = stack.Pop();
            Output.Text = "Item removed successfuly";
            ListBox1.DataSource = stack;
            ListBox1.DataBind();
        }

        protected void Clr_Click(object sender, EventArgs e)
        {
            stack.Clear();
            ListBox1.DataSource = stack;
            ListBox1.DataBind();
        }

        protected void Save_Click(object sender, EventArgs e)
        {
            try
            {
                string path = Server.MapPath("todo.txt");
                //clear all file content
                File.WriteAllText(path, String.Empty);

                var fileStream = new FileStream(path, FileMode.Open, FileAccess.Write);
                //using (StreamWriter sw = File.AppendText(path))
                using (var sw = new StreamWriter(fileStream))
                {
                    foreach (string todo in stack)
                    {
                        sw.WriteLine(todo);
                    }

                    sw.Close();
                }
                fileStream.Close();
                Output.Text = "File saved successfully";
            }
            catch (Exception) {
                Output.Text = "Error occurred";
            }
        }
    }
}