using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Model
{
    public class Librarian : Person
    {
        public Librarian(string identification, string name, int age, string gender, string address, string phoneNumber, string email)
            : base(identification, name, age, gender, address, phoneNumber, email)
        {
        }
    }
}
