using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static System.Net.Mime.MediaTypeNames;

namespace WebApplication8
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DropDownList1.Items.Add(new ListItem("Unbound"));
            DropDownList1.Items.Add(new ListItem("Green"));
            DropDownList1.Items.Add(new ListItem("Yellow"));
            DropDownList1.Items.Add(new ListItem("Orange"));

            DropDownList2.Items.Add(new ListItem("Unbound"));
            DropDownList2.Items.Add(new ListItem("Arial"));
            DropDownList2.Items.Add(new ListItem("Times New Roman"));

            DropDownList3.Items.Add(new ListItem("Unbound"));
            DropDownList3.Items.Add(new ListItem("Green"));
            DropDownList3.Items.Add(new ListItem("Yellow"));
            DropDownList3.Items.Add(new ListItem("Orange"));

            RadioButtonList1.Items.Add(new ListItem(BorderStyle.None.ToString(), ((int)(BorderStyle.None)).ToString()));
            RadioButtonList1.Items.Add(new ListItem(BorderStyle.Solid.ToString(), ((int)(BorderStyle.Solid)).ToString()));



        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = TextBox2.Text;
            Label1.Font.Name = DropDownList2.SelectedItem.Text;
            int size;

            var success = Int32.TryParse(TextBox2.Text, out size);
            if (success)
            {
                Label1.Font.Size = size;
            }
            if (CheckBox1.Checked)
            {
                Image1.Visible = true;
            }
            Panel1.BackColor = Color.FromName(DropDownList1.SelectedItem.Text);
        }
    }
}