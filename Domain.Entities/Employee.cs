
using System;
using System.ComponentModel;

namespace ShiftSchedule.Domain.Entities
{

    public class Employee
    {
        //public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime DateCreated { get; set; }

        public Employee()
        {
        }

        public Employee(string firstName, string lastName, string email, DateTime dateCreated)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            DateCreated = dateCreated;
        }


        public string GetFullName()
        {
            return (FirstName + " " + LastName);
        }
    }
}
