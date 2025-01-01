using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test.Models { 
 
    public static class LoginUserDetail
    {
        public static string Name { get; set; }
        public static string UserName { get; set; }
        public static string Password { get; set; }
        public static bool IsMember { get; set; }
        public static BindingList<Dishes> SelectedDished { get; set; }
    }
}
