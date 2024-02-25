using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication20
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }



        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (ListBox1.SelectedIndex == 0)
            {


                CheckBox1.Text = "Forrest Gump";

                CheckBox2.Text = "Good will hunting";
                CheckBox3.Text = "A beautiful mind";

            }
            if (ListBox1.SelectedIndex == 1)
            {
                CheckBox1.Text = "Keeping up with the jonses";

                CheckBox2.Text = "Masterminds";
                CheckBox3.Text = "Ted2";

            }
            if (ListBox1.SelectedIndex == 2)
            {

                CheckBox1.Text = "Batman vs Superman";
                CheckBox2.Text = "Deadpool";
                CheckBox3.Text = "The accountant";


            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int cenadrama1 = 0;
            int cenadrama2 = 0;
            int cenadrama3 = 0;
            int rezultat1 = 0;
            int rezultat2 = 0;
            int rezultat3 = 0;
            int rezultat = 0;

            if (ListBox1.SelectedIndex == 0)
            {



                if (CheckBox1.Checked)
                {

                    cenadrama1 =150;
                }
                 if (CheckBox2.Checked)
                {
                    cenadrama2 = 130;
                }
                 if (CheckBox3.Checked)
                {
                    cenadrama3 = Convert.ToInt32(100);
                }
                if (TextBox1.Text != "" && CheckBox1.Checked)
                {
                    rezultat1 = Convert.ToInt32(cenadrama1 * Convert.ToInt32(TextBox1.Text));
                }
                 if (TextBox2.Text != "" && CheckBox2.Checked)
                {
                    rezultat2 = Convert.ToInt32(cenadrama2 * Convert.ToInt32(TextBox2.Text));
                }
                 if (TextBox3.Text != "" && CheckBox3.Checked)
                {
                    rezultat3 = Convert.ToInt32(cenadrama3 * Convert.ToInt32(TextBox3.Text));
                }
                rezultat = rezultat1 + rezultat2 + rezultat3;

                Label1.Text = "Cenata iznesuva " + rezultat + " denari";
                
            }
            if (ListBox1.SelectedIndex == 1)
            {


                if (CheckBox1.Checked)
                {

                    cenadrama1 = Convert.ToInt32(120);
                }
                if (CheckBox2.Checked)
                {
                    cenadrama2 = Convert.ToInt32(170);
                }
                if (CheckBox3.Checked)
                {
                    cenadrama3 = Convert.ToInt32(180);
                }
                if (TextBox1.Text != "" && CheckBox1.Checked)
                {
                    rezultat1 = Convert.ToInt32(cenadrama1 * Convert.ToInt32(TextBox1.Text));
                }
                if (TextBox2.Text != "" && CheckBox2.Checked)
                {
                    rezultat2 = Convert.ToInt32(cenadrama2 * Convert.ToInt32(TextBox2.Text));
                }
                if (TextBox3.Text != "" && CheckBox3.Checked)
                {
                    rezultat3 = Convert.ToInt32(cenadrama3 * Convert.ToInt32(TextBox3.Text));
                }
                rezultat = rezultat1 + rezultat2 + rezultat3;

                Label1.Text = "Cenata iznesuva " + rezultat + " denari";
            }

            if (ListBox1.SelectedIndex == 2)
            {
                if (CheckBox1.Checked)
                {

                    cenadrama1 = Convert.ToInt32(150);
                }
                if (CheckBox2.Checked)
                {
                    cenadrama2 = Convert.ToInt32(130);
                }
                if (CheckBox3.Checked)
                {
                    cenadrama3 = Convert.ToInt32(100);
                }
                if (TextBox1.Text != "")
                {
                    rezultat1 = Convert.ToInt32(cenadrama1 * Convert.ToInt32(TextBox1.Text));
                }
                if (TextBox2.Text != "")
                {
                    rezultat2 = Convert.ToInt32(cenadrama2 * Convert.ToInt32(TextBox2.Text));
                }
                if (TextBox3.Text != "")
                {
                    rezultat3 = Convert.ToInt32(cenadrama3 * Convert.ToInt32(TextBox3.Text));
                }
                rezultat = rezultat1 + rezultat2 + rezultat3;

                Label1.Text = "Cenata iznesuva " + rezultat + " denari";
              
            }
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            CheckBox1.Checked = false;
            CheckBox2.Checked = false;
            CheckBox3.Checked = false;
        }
    }
}
