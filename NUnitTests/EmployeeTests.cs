using System;
using NUnit.Framework;
using ShiftSchedule.Domain.Entities;

namespace NUnitTests
{
    [TestFixture]
    class EmployeeTests
    {
        [TestCase("bob", true)]
        [TestCase("", false)]
        public void IsValidFirstName_EmptyFirstName_ReturnsFalse(string firstname,bool expected)
        {
            var employee = new Employee(firstname, "Dylan", "bob@dylan.com", DateTime.Now);
            bool result = employee.IsValidFirstName();
            Assert.AreEqual(expected, result);
        }



    }
}
