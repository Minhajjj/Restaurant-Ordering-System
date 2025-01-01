using Microsoft.VisualBasic;
using System.ComponentModel;
using System.Data;
using test.Models;

namespace test.Forms
{
    public partial class Menu : Form
    {
        int i = 0;
        Categories[] arrCategories = new Categories[6];
        Dishes[] arrDishes = new Dishes[50];
        BindingList<Dishes> selectedDishes = new BindingList<Dishes>();

        public Menu()
        {
            InitializeComponent();
            GridDishes.Columns["colAction"].DisplayIndex = 3;
            lblWelcome.Text = "Welcome  " + LoginUserDetail.Name;
            if (LoginUserDetail.IsMember == true)
            {
                btnMember.Visible = false;
            }
            arrCategories = new Categories[]{
          new Categories()
          {
              CategoryName = "Chinese"
          },
          new Categories()
          {
              CategoryName = "Italian"
          },
          new Categories()
          {
              CategoryName = "French"
          },
          new Categories()
          {
              CategoryName = "Desi"
          },
           new Categories()
          {
              CategoryName = "Beverages"
          }
          };
            if (LoginUserDetail.SelectedDished != null && LoginUserDetail.SelectedDished.Count > 0)
                GridDishes.DataSource = LoginUserDetail.SelectedDished;

        }



        private void cmbxCategory_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            var selectCategory = cmbxCategory.SelectedItem.ToString();
            var arr = Lookups.lstDishes.Where(x => x.Category == selectCategory).ToArray();
            GridDishes.DataSource = arr;
        }
        public List<Dishes> CartItems = new List<Dishes>();

        private void GridDishes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && GridDishes.Columns[e.ColumnIndex].Name == "colAction")
            {
                // Retrieve the data of the clicked row
                var selectedRow = GridDishes.Rows[e.RowIndex];
                var dish = selectedRow.DataBoundItem as Dishes; // Assuming DataGridView is bound to a data source

                // Add the dish to the cart (you can define your AddToCart method)
                if (dish != null)
                {
                    Dishes dishToAdd = new Dishes();
                    dishToAdd.id = Guid.NewGuid().ToString();
                    dishToAdd.DishName = dish.DishName;
                    dishToAdd.Category = dish.Category;
                    dishToAdd.DishPrice = dish.DishPrice;

                    selectedDishes.Add(dishToAdd);
                }


            }
        }

        private void BtnDisplayCart_Click(object sender, EventArgs e)
        {
            Cart CartDisplay = new Cart(selectedDishes);
            CartDisplay.ShowDialog();

        }

        private void btnMember_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have Succesfully Become a Member and can Now Avail a 30% Discount on entire Menu", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            bool result = new CustomerInformation().UpdateMembershipStatus();
            if (result == true)
            {
                btnMember.Enabled = false;
                ///btnMember.Visible = false;
            }
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
