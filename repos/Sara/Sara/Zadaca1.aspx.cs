using Antlr.Runtime.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sara
{
    public partial class Zadaca1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void save (object sender, EventArgs e)
        {
            var viktor = list.SelectedItem;
            ovoshje.Text = viktor.ToString();
            var cenice = list.SelectedItem.Value;
            cena.Text = cenice.ToString();
            // for( int i=0; i< list.lenght; i++
            Int16 ceno = 0;
            foreach (ListItem item in list.Items)
            {
                if (item.Selected)
                {
                    var broj = list.SelectedItem;
                    proizvodi.Text += broj.ToString() + " ";
                    Int16 sara = System.Int16.Parse(list.SelectedItem.Value);
                    ceno += sara;
                }
            }
            vkupno.Text = ceno.ToString();

        }
       
    }
}