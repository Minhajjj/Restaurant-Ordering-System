using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using test.Models;

namespace test.Models
{
    public class CustomerInformation
    {
        public string Name{ get; set; }
        public string UserName{ get; set; }
        public string Password { get; set; }
        public bool IsMember  { get; set; }
        string connectionString = @"Server=DESKTOP-PB7H2QT\SQLEXPRESS;Database=ROS;Integrated Security=True;";
        public bool IsValidPassword(string password)
        {
            int digitCount = 0;
            bool hasUppercase = false;
            bool hasSymbol = false;

            foreach (char i in password)
            {
                if (char.IsUpper(i))
                {
                    hasUppercase = true;
                }
                else if (char.IsDigit(i))
                {
                    digitCount++;
                }
                else if (char.IsPunctuation(i))
                {
                    hasSymbol = true;
                }
            }
            return hasUppercase && hasSymbol && (digitCount >= 2);
        }

       public bool SignUp(string Name, string PhoneNumber, string userName, string password)
        {
            if (IsValidPassword(password))
            {
                SqlConnection con = new SqlConnection(connectionString);
                string Query = $"insert into Users values ('{userName}','{Name}','{password}','{IsMember}')";
                SqlCommand cmd = new SqlCommand(Query, con);
                con.Open();
                int sdr = cmd.ExecuteNonQuery();
                if(sdr > 0)
                {
                    return true;         
                }
                return false;
            }
            else
            {
                return false;
            }
        }

        public CustomerInformation LogIn(string userName, string password)
        {
            List<CustomerInformation> lst = new List<CustomerInformation>();

            SqlConnection con=new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("select * from Users", con);


            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                CustomerInformation user = new CustomerInformation();
                user.UserName = sdr["UserName"].ToString();
                user.Password = sdr["Password"].ToString();
                user.Name = sdr["Name"].ToString();
                user.IsMember = (bool)sdr["IsMember"] ;
                lst.Add(user);
            }

            con.Close();
            if(lst.Any(x=>x.UserName.ToLower()==userName.ToLower() && x.Password==password))
            {
                return lst.FirstOrDefault(x => x.UserName.ToLower() == userName.ToLower() && x.Password == password);
            }
                
            else
                return null;




        }
       public bool UpdateMembershipStatus()
        {
            string query = "update dbo.Users set IsMember=1 where UserName='" + LoginUserDetail.UserName +"'";
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            int effectedRows = cmd.ExecuteNonQuery();
            if (effectedRows > 0)
            {
                LoginUserDetail.IsMember = true;
                return true;
            }
            return false;

            con.Close();

        }



    }


}
