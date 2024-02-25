using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication7
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            color.Items.Add(new ListItem("Green"));
            color.Items.Add(new ListItem("Red"));
            color.Items.Add(new ListItem("Yellow"));

            font.Items.Add(new ListItem("Arial"));
            font.Items.Add(new ListItem("Times New Roman"));

            boja_Font.Items.Add(new ListItem("Green"));
            boja_Font.Items.Add(new ListItem("Red"));
            boja_Font.Items.Add(new ListItem("Yellow"));

            tip_Ramka.Items.Add(new ListItem(BorderStyle.None.ToString(),((int)BorderStyle.None).ToString()));
            tip_Ramka.Items.Add(new ListItem(BorderStyle.Solid.ToString(), ((int)BorderStyle.Solid).ToString()));


        }

        protected void Save_Click(object sender, EventArgs e)
        {

        }
    }
}