
using System;
using System.Collections.Generic;
using ShiftSchedule.Domain.Entities;
using ShiftSchedule.Domain.Interfaces;

namespace ShiftSchedule.Infrastructure.Data
{
	public class EmployeeRepository : IEmployeeRepository
    {
        public List<Employee> GetEmployees()
        {
            // in reality you would connet to Database from this point, but for demo purposes
            // we will just return in-memory data
            var users = new List<Employee>()
                {
                    new Employee { DateCreated = DateTime.Now, Email = "chetan.vihite@thedigitalgroup.net", FirstName = "chetan", LastName = "vihite"},
                    new Employee { DateCreated = DateTime.Now, Email = "sunil.sahoo@thedigitalgroup.net", FirstName = "sunil", LastName = "sahoo"},
                    new Employee { DateCreated = DateTime.Now, Email = "shashikant.patil@thedigitalgroup.net", FirstName = "shashikant", LastName = "patil"},
                    new Employee { DateCreated = DateTime.Now, Email = "sushseel.kumar@thedigitalgroup.net", FirstName = "susheel", LastName = "kumar"},
                    new Employee { DateCreated = DateTime.Now, Email = "jagdeep.singh@thedigitalgroup.net", FirstName = "jagdeep", LastName = "khalsa"},
                };

            return users;
        }
    }
}
