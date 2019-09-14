using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment2
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }



        private void infoSave_Click(object sender, EventArgs e)
        {
            string name = customernameTextBox.Text;
            

            string no = contactynoTextBox.Text;
            
           
            string address = addressTextBox.Text;
            

            string order = ordercomboBox.Text;


            int quantity = Convert.ToInt32(quantityTextBox.Text);


            int price=0;
            if (order == "Black")
            {
                price = 120;
            }
            else if (order == "cold")
            {
                price = 100;
            }
            else if (order == "Hot")
            {
                price = 90;
            }
            else
            {
                price = 80;
            }

            int totalPrice = quantity * price;

            

            infoTextBox.Text = "Name :" + name + "\ncontac no :" + no + "\naddress :" + address +"\norder :" + order +"\nquantity :" + quantity + "\nTotalprice :" + totalPrice; 
            


            


            
        }

    }
}
