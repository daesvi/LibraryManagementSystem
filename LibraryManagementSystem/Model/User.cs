using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Model
{
    public class User : Person
    {
        // Attributes
        List<Loan> loanHistory;

        // Getters and Setters
        public List<Loan> LoanHistory { get => loanHistory; set => loanHistory = value; }

        // Constructor
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
