using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train_Booking.Classes
{
    public class Admin : User
    {
        public int id;
        public string? position;
        public Admin() { }
        public Admin(string username, int id, string position, string name, string password, string phone, string email) : base(username, name, password, phone, email, "0", 0, "0")
        {
            this.position = position;
            this.id = id;
        }

        public override string ToString()
        {
            return $"{name} | {password} | {phone} | {email} | {position}";
        }
    }
}
