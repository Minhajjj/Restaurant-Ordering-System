using test.Models;

namespace test.Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            new Dishes().LoadDishesFromDatabase();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string password = txtPassword.Text;

            try
            {
                CustomerInformation _customer = new CustomerInformation();
                _customer = _customer.LogIn(userName, password);
                if (_customer != null)
                {
                    LoginUserDetail.IsMember = _customer.IsMember;
                    LoginUserDetail.Name = _customer.Name;
                    LoginUserDetail.UserName = _customer.UserName;
                    LoginUserDetail.Password = _customer.Password

                        ;
                    Menu frmMenu = new Menu();
                    frmMenu.ShowDialog();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Invalid Credentials. Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
