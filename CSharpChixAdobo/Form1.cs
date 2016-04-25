using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double actualWeight;
            bool result = double.TryParse(txtWeight.Text, out actualWeight);    //Validates user entered Numerics Only
                       
            if (actualWeight >= 1.5)
                {
                    double sweetOnion = (actualWeight / 3);                             //# of Sweet Onions (Rounded)
                    double sweetOnionDecimal = sweetOnion - Math.Truncate(sweetOnion);  //Amount of Sweet Onion in cups/decimal format
                    double garlicCloves = Math.Round(((8 * actualWeight) / 3), 0);      //# of Garlic Cloves (Rounded)
                    double soySauce = (0.75 * actualWeight) / 3;                        //Cups of Soy Sauce
                    double soySauceDecimal = soySauce - Math.Truncate(soySauce);        //Amount of Soy Sauce below 1     
                    double vinegar = (0.5 * actualWeight) / 3;                          //Cups of Vinegar
                    double vinegarDecimal = vinegar - Math.Truncate(vinegar);           //Amount of Vinegar below 1
                    string sweetOnionFraction = "";                                     //Place holder for cups of Sweet Onion
                    string soySauceFraction = "";                                       //String place holder for cups of Soy Sauce
                    string vinegarFraction = "";                                        //String place holder for cups of Vinegar

                    //Determines portion amount of Sweet Onion
                    if (sweetOnionDecimal >= 0 && sweetOnionDecimal < 0.25) sweetOnionFraction = "";
                    else if (sweetOnionDecimal >= 0.25 && sweetOnionDecimal < 0.50) sweetOnionFraction = "1/4 ";
                    else if (sweetOnionDecimal >= 0.50 && sweetOnionDecimal < 0.75) sweetOnionFraction = "1/2 ";
                    else if (sweetOnionDecimal >= 0.75 && sweetOnionDecimal < 1) sweetOnionFraction = "3/4 ";

                    //Determines amount of cups for Soy Sauce
                    if (soySauceDecimal >= 0 && soySauceDecimal < .25) soySauceFraction = "Cup";
                    else if (soySauceDecimal >= .25 && soySauceDecimal < .5) soySauceFraction = "1/4 Cup";
                    else if (soySauceDecimal >= .5 && soySauceDecimal < .75) soySauceFraction = "1/2 Cup";
                    else if (soySauceDecimal >= .75 && soySauceDecimal < 1) soySauceFraction = "3/4 Cup";

                    //Determines amount of cups in Vinegar
                    if (vinegarDecimal >= 0 && vinegarDecimal < .25) vinegarFraction = "Cup";
                    else if (vinegarDecimal >= .25 && vinegarDecimal < .5) vinegarFraction = "1/4 Cup";
                    else if (vinegarDecimal >= .5 && vinegarDecimal < .75) vinegarFraction = "1/2 Cup";
                    else if (vinegarDecimal >= .75 && vinegarDecimal < 1) vinegarFraction = "3/4 Cup";

                    //Displays whole number with correct cup fraction size for Soy Sauce
                    if (soySauce >= 1) lblSoySauce.Text = Math.Truncate(soySauce).ToString() + " " + soySauceFraction + " Soy Sauce";
                    else lblSoySauce.Text = soySauceFraction + " Soy Sauce";

                    if (sweetOnion >= 1) lblSweetOnion.Text = Math.Truncate(sweetOnion).ToString() + " " + sweetOnionFraction + " Sweet Onion";
                    else lblSweetOnion.Text = sweetOnionFraction + "Sweet Onion";

                    //Displays whole number with correct cup fraction size for Vinegar
                    if (vinegar >= 1) lblVinegar.Text = Math.Truncate(vinegar).ToString() + " " + vinegarFraction + " Vinegar";
                    else lblVinegar.Text = vinegarFraction + " Vinegar";

                    lblGarlicCloves.Text = garlicCloves.ToString() + " Garlic Cloves";
                }

            //Error message if user entered less than 1.5 pounds or a non-numeric
            else 
            {
                MessageBox.Show("Must Be Over 1.5 Pounds\nMust Be A Number", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtWeight.Clear();
                txtWeight.Focus();
            }
        }            

        //Clears Chicken Weight field and ingredient amounts
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtWeight.Clear();
            txtWeight.Focus();
            lblSweetOnion.Text = "";
            lblGarlicCloves.Text = "";
            lblSoySauce.Text = "";
            lblVinegar.Text = "";
        }

        //Prompts Rice Form prior to exiting
        private void btnExit_Click(object sender, EventArgs e)
        {
            new frmRiceCheck().Show();
        }     

    }
}
