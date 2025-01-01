
using test.Models;

namespace test.Forms
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();


        }




        private void btnSave_Click(object sender, EventArgs e)
        {
            CustomerInformation _customer = new CustomerInformation();
            string Name = txtName.Text;
            string PhoneNumber = txtPhoneNumber.Text;
            string UserName = txtUserName.Text;
            string Password = txtPassword.Text;
            bool check = _customer.SignUp(Name, PhoneNumber, UserName, Password);
            if (check)
            {
                MessageBox.Show("User Registered Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Login frmLogin = new Login();
                frmLogin.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid Credentials", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }
    }
}
