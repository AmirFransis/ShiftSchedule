using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShiftSchedule.Domain.Entities;

namespace UnitTest
{
    [TestClass]
    public class EmploeeTests
    {
        [TestMethod]
        [TestCategory("SimpleGet")]
        public void GetFullName()
        {
            var emp = new Employee("Amir","Fransis","blad@gmail.com",DateTime.Now);
            string fullname = emp.GetFullName();
            Assert.AreEqual("Amir Fransis",fullname);
        }
    }
}
