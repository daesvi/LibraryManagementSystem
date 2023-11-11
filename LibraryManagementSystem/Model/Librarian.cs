using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Model
{
    public class Librarian : Person
    {
        // Configure Id as primary key and autoincremental
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }


        public Librarian() { }

        public Librarian(string identification, string name, int age, string gender, string address, string phoneNumber, string email)
            : base(identification, name, age, gender, address, phoneNumber, email)
        {
        }
    }
}
