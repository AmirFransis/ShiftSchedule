using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShiftSchedule.Domain.Entities;

namespace ShiftSchedule.Services
{
    public class Schedule
    {

        private Team team;
        private Shift shift;
        List<Employee> employees { get; set; }

        public Schedule(Shift shift, Team team, List<Employee> employees)
        {
            this.shift = shift;
            this.team = team;
            this.employees = employees;
        }

        public void addEmployee(Employee emp)
        {
            employees.Add(emp);
        }

    }

   
}
