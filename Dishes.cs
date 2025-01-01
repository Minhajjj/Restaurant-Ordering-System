using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test.Models
{
    public class Dishes
    {
        public string id;
        string connectionString = @"Server=DESKTOP-PB7H2QT\SQLEXPRESS;Database=ROS;Integrated Security=True;";
        public int DishPrice { get; set; }
        public string DishName { get; set; }
        public string Category { get; set; }

        public List<Dishes> LoadDishesFromDatabase()
        {
            List<Dishes> dishes = new List<Dishes>(); // Initialize a list to store dishes

            string query = "SELECT * FROM dbo.Dishes";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(query, con);
                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Create a new Dish object and populate it with data from the reader
                            Dishes dish = new Dishes
                            {
                                DishName = reader["DishName"].ToString(),
                                DishPrice = Convert.ToInt32(reader["DishPrice"]),
                                Category = reader["Category"].ToString()
                            };

                            // Add the dish to the list
                            dishes.Add(dish);
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Log or handle the exception
                    Console.WriteLine("An error occurred: " + ex.Message);
                }
            }
            Lookups.lstDishes = dishes;
            return dishes; // Return the list of dishes
        }


    }
}
