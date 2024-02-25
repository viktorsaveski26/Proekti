using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication19
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("UspeshnoGlasanje.aspx");
        }

        protected void dodadi_Click(object sender, EventArgs e)
        {
            ListItem item1 = new ListItem(predmet.Text);
            ListItem item2 = new ListItem(krediti.Text);
            
            ListBox1.Items.Add(item1);
            ListBox2.Items.Add(item2);
            predmet.Text = "";
            krediti.Text = "";
            Label1.Text = "Nepoznat profesor";
        }

        protected void izbrisi_Click(object sender, EventArgs e)
        {
            int pomos;
            int pomos2;
            if (ListBox1.SelectedItem != null)
            {
                pomos = ListBox1.SelectedIndex;
                ListBox1.Items.RemoveAt(pomos);
                ListBox2.Items.RemoveAt(pomos);
            }
            else if (ListBox2.SelectedItem != null)
            {
                pomos2 = ListBox2.SelectedIndex;
                ListBox1.Items.RemoveAt(pomos2);
                ListBox2.Items.RemoveAt(pomos2);

            }
            
         

        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Label1.Text = ListBox1.SelectedValue.ToString();
     }
    }
}