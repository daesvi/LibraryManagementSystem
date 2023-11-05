using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Model
{
    public abstract class Person
    {
        // Attributes
        string identification;
        string name;
        int age;
        string gender;
        string address;
        string phoneNumber;
        string email;

        // Getters and Setters
        public string Identification { get => identification; set => identification = value; }
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Address { get => address; set => address = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Email { get => email; set => email = value; }

        // Constructor
        public Person(string identification, string name, int age, string gender, string address, string phoneNumber, string email)
        {
            this.identification = identification;
            this.name = name;
            this.age = age;
            this.gender = gender;
            this.address = address;
            this.phoneNumber = phoneNumber;
            this.email = email;
        }
    }
}
