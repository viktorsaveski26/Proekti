using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication14
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Uspeshno.aspx");
        }
        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Label1.Text = DropDownList1.SelectedValue.ToString();
        }

        protected void dodadi_Click(object sender, EventArgs e)
        {
            ListItem item1 = new ListItem(predemt.Text);
            DropDownList1.Items.Add(item1);
            ListItem item2 = new ListItem(krediti.Text);
            DropDownList2.Items.Add(item2);
            predemt.Text = "";
            krediti.Text = "";
        } 

        protected void izbrisi_Click(object sender, EventArgs e)
        {
            int pomos = DropDownList1.SelectedIndex;
            DropDownList1.Items.RemoveAt(pomos);
            DropDownList2.Items.RemoveAt(pomos);
        }
    }
}