using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace zadaca_4_aud_2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void save_Click(object sender, EventArgs e)
        {
            var name = currencyName.Text;
            var value = currencyValue.Text;
            double double_value;

            if(name.Length != 0 && value.Length != 0 && Double.TryParse(value, out double_value) )
            {
                error.Text = "";
                status.Text = "";
                ListItem newListItem =  new ListItem(name,value);
                currencyName.Text = "";
                currencyValue.Text = "";
                currencyList.Items.Add(newListItem);
                Total.Text = currencyList.Items.Count.ToString();
            }
            else
            {
                error.Text = "Nevaliden vlez";
            }
        }

        protected void delete_Click(object sender, EventArgs e)
        {
            if(currencyList.SelectedIndex != -1) // -1 e ako ne e nisto slektirano
            {
                currencyList.Items.Remove(currencyList.SelectedItem);
            }
            else
            {
                status.Text = "Nemate selektirano ni edna valuta";
            }
        }
    }
}