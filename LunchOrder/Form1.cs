using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LunchOrder
{
    //Jakob Brown
    public partial class Form1 : Form
    {
        decimal subTotal;
        decimal tax = 0.0775m;
        decimal orderTotal;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Jakob Brown
        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            if (radPizza.Checked)
            {
                decimal Pizza = Convert.ToDecimal(radPizza.Checked);
                subTotal = 5m;
                tax = subTotal * 0.075m;
                orderTotal = subTotal + tax;
            }
            else if (radHamburger.Checked)
            {
                decimal Hamburger = Convert.ToDecimal(radHamburger.Checked);
                subTotal = 10m;
                tax = subTotal * 0.075m;
                orderTotal = subTotal + tax;
            }
            else if (radSalad.Checked)
            {
                decimal Salad = Convert.ToDecimal(radSalad.Checked);
                subTotal = 3m;
                tax = subTotal * 0.075m;
                orderTotal = subTotal + tax;
            }

            txtSubtotal.Text = subTotal.ToString("C");
            txtSalesTax.Text = tax.ToString("C");
            txtOrderTotal.Text = orderTotal.ToString("C");
            
        }
    }
}
