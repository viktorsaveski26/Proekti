using Microsoft.Ajax.Utilities;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace vezzzzzz
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DodadiValuta_Click(object sender, EventArgs e)
        {
            //var name = ime_Valuta.Text;
            var value = vrednost_Valuta.Text;
            //da proverime i dali se raboti za double
            double double_value;


            if (ime_Valuta.Text.Length != 0 && value.Length != 0 && Double.TryParse(value, out double_value))
            {


                ListItem novitem = new ListItem(ime_Valuta.Text, value);
                Label3.Text = "";
                lista_Valuti.Items.Add(novitem);

                ime_Valuta.Text = "";
                vrednost_Valuta.Text = "";

                Label4.Text = lista_Valuti.Items.Count.ToString();

            }
            else
            {
                Label1.Text = "";
                Label2.Text = "";
                Label3.Text = "Vnesete vrednost :D";

            }

        }
        protected void IzbrisiValuta_Click(object sender, EventArgs e)
        {

            if (lista_Valuti.SelectedIndex != -1)//-1 e ako nisto ne e selektirano
            {
                lista_Valuti.Items.Remove(lista_Valuti.SelectedItem);
                Label4.Text = lista_Valuti.Items.Count.ToString();
            }
            else
            {
                error.Text = "Nema sto da se izbrise";
            }
        }
        protected void lista_Valuti_SelectedIndexChanged(object sender, EventArgs e)
        {
            
          //  int value = Convert.ToInt32(lista_Valuti.SelectedValue); // da konvertirame so pomos na Convert klasata
            promena.Text = Convert.ToString(Convert.ToInt32(Vrednost.Text) * Convert.ToInt32(lista_Valuti.SelectedValue)); // valda  Convert.ToInt32(lista_Valuti.SelectedValue) moze i direktno na mestoto od value
                                                                                     //za da rabotit ova morat od proeperties AutoPostBack od False da se stavit na True za da se prakaat podatocite na serverot.. valda zatoa?.


        }
      




    }
}