using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace Train_Booking.Classes
{
    public class Customer : User
    {
        public int id { get; set; }
        public Customer()
        {

        }
        public Customer(string username, string name, string password, string phone, string email, string city, int age, string country) : base(username, name, password, phone, email, city, age, country)
        {
        }
        public override string ToString()
        {
            return $"{name} | {password} | {phone} | {email} | {city} | {age} | {country}";
        }
    }
}
