using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cash_register
{
    public partial class cashRegister : Form
    {
        
        int price = 0;
        double taxPrice = 0;
        double taxAmount = 0.13; 
        int totalPrice; 
        

        public cashRegister()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void calculateB_Click(object sender, EventArgs e)
        {
            int bread = Convert.ToInt16(inputBread.Text);
            int milk = Convert.ToInt16(inputMilk.Text);
            int egg = Convert.ToInt16(inputEgg.Text);
            int tax = (int)(price * taxAmount + price); 
            double eggPrice = 3.50;
            double milkPrice = 6.50;
            double breadPrice = 3.50;
            price = (int)(bread * breadPrice + milk * milkPrice + egg * eggPrice);

            output.Text = $"your total before tax is ${price}";
            outputTax.Text = $"Your tax is ${price * taxAmount}"; 
            outputTotal.Text = $"Your total after tax is ${price * taxAmount + price}";


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
