using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShiftSchedule.Domain.Entities;

namespace ShiftSchedule.Services
{
    class Schedule
    {
        private Team team;
        private Shift shift;
        List<Employee> employees { get; set; }

        public void addEmployee(Employee emp)
        {
            employees.Add(emp);
        }

    }

   
}
