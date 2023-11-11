using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Model
{
    public class User : Person
    {
        // Configuring Id as primary key and autoincremental
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        // Attributes
        List<Loan> loanHistory;

        // Getters and Setters
        public List<Loan> LoanHistory { get => loanHistory; set => loanHistory = value; }


        // Constructor
        public User() { }

        public User(string identification, string name, int age, string gender, string address, string phoneNumber, string email)
            : base(identification, name, age, gender, address, phoneNumber, email)
        {
            this.Identification = identification;
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
            this.Address = address;
            this.PhoneNumber = phoneNumber;
            this.Email = email;
        }
    }
}
