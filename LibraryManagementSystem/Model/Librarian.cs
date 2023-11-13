using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Model
{
    public class Librarian : Person
    {
        // Attributes
        long identification;
        string password;

        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Identification { get => identification; set => identification = value; }
        public string Password { get => password; set => password = value; }

        public Librarian() { }

        public Librarian(long identification, string password,string name, int age, string gender, string address, string phoneNumber, string email)
            : base(name, age, gender, address, phoneNumber, email)
        {
            Identification = identification;
            Password = password;
        }

        
    }
}
