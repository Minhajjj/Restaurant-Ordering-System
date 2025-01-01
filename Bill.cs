using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using test.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace test.Forms
{
    public partial class Bill : Form
    {
        BindingList<Dishes> cartItems;
        public Bill(BindingList<Dishes> selectedDishes)

        {
            cartItems = selectedDishes;
            InitializeComponent();
            this.Load += BillingForm_Load;

        }

        private void Bill_Load(object sender, EventArgs e)
        {

        }
        private void DisplayCartItems()
        {
            Billpanel.Controls.Clear();

            int yPosition = 10;  // Start position for the first label

            // Iterate through the cartDishes list to create labels for each item
            foreach (var dish in cartItems)
            {
                // Create a label for the dish details (Name, Quantity, Price, Total)
                Label dishLabel = new Label();
                dishLabel.Text = $"{dish.DishName}                      - Price: PKR {dish.DishPrice} ";
                dishLabel.Location = new Point(10, yPosition);  // Position the label in the panel
                dishLabel.AutoSize = true;  // Make the label auto-size to the text

                // Add the label to the panel
                Billpanel.Controls.Add(dishLabel);

                // Increment the y-position for the next label
                yPosition += 25;  // Adjust this value if you want more space between the items
            }
        }
        private void DisplayTotalAmount()
        {
            double totalBill = 0;

            // Iterate through the cartDishes list to calculate the total bill
            foreach (var dish in cartItems)
            {
                totalBill += dish.DishPrice;  // Assuming 'Price' is a decimal property of Dishes
            }

            if (LoginUserDetail.IsMember)
            {
                double discountedBill = (totalBill * 30) / 100;
                double finalBill = totalBill - discountedBill;
                //   lbltotal.Text = "Total: PKR " + totalBill.ToString("0.00");
                lbltotal.Text = $"Total Bill: PKR {totalBill}\nTotal Bill After Discount : PKR " + finalBill.ToString("0.00");
            }
            else
                lbltotal.Text = "Total: PKR " + totalBill.ToString("0.00");
        }


        // Call this method in the form's Load event
        private void BillingForm_Load(object sender, EventArgs e)
        {
            if (cartItems == null || cartItems.Count == 0)
            {
                MessageBox.Show("No items in the cart to display.");
                return;
            }
            DisplayCartItems(); // Populate the panel with cart items
            DisplayTotalAmount();
        }

        private void Paybtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" You Paid " + lbltotal.Text, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
