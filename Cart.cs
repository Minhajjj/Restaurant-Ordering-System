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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace test.Forms
{
    public partial class Cart : Form
    {

        BindingList<Dishes> lst;
        public Cart(BindingList<Dishes> selectedDishes)
        {

            lst = selectedDishes;
            InitializeComponent();
            CartGridView.DataSource = selectedDishes;


            CartGridView.Columns["dishNametxt"].DisplayIndex = 0;
            CartGridView.Columns["categorytxt"].DisplayIndex = 1;
            CartGridView.Columns["dishPricetxt"].DisplayIndex = 2;
            CartGridView.Columns["colAction"].DisplayIndex = 3;



        }

        private void Cart_Load(object sender, EventArgs e)
        {

        }

        private void CartGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView cvg = CartGridView as DataGridView;
            var selectedRow = CartGridView.Rows[e.RowIndex];
            var dish = selectedRow.DataBoundItem as Dishes; // Assuming DataGridView is bound to a data source
            if (cvg.Columns[e.ColumnIndex].Name == "colAction")
            {
                if (dish != null)
                {
                    CartGridView.Rows.RemoveAt(e.RowIndex);
                    var itemToRemove = lst.FirstOrDefault(x => x.id == dish.id);
                    lst.Remove(itemToRemove);
                }
            }
            // Add the dish to the cart (you can dsefine your AddToCart method)

        }

        private void btnClearCart_Click(object sender, EventArgs e)
        {

            CartGridView.Rows.Clear();
            lst.Clear();
            MessageBox.Show("Cart has been cleared!", "Clear Cart", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        private void Paymentbtn_Click(object sender, EventArgs e)
        {
            Bill billForm = new Bill(lst);

            // Show the Bill form
            billForm.Show();
        }


    }
}
