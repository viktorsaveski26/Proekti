using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication13
{
    public partial class WebForm3 : System.Web.UI.Page
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
            DropDownList1.Items.Add(item1);
            ListItem item2 = new ListItem(krediti.Text);
            DropDownList2.Items.Add(item2);
            predmet.Text = "";
            krediti.Text = "";
       } 

        protected void izbrisi_Click(object sender, EventArgs e)
        {
            int  pomos = DropDownList1.SelectedIndex;  
         //   DropDownList1.Items.RemoveAt(DropDownList1.SelectedIndex);  
          //  DropDownList2.Items.RemoveAt(DropDownList1.SelectedIndex);
          DropDownList1.Items.RemoveAt(pomos);
            DropDownList2.Items.RemoveAt(pomos);
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

            Label1.Text = DropDownList1.SelectedValue.ToString();
        }
    }
}