using System;
using System.Collections.Generic;


namespace ShiftSchedule.Domain.Entities
{
    class Shift
    {
        public DateTime DateStarted { get; set; }
        public DateTime DateEnded { get; set; }
        public IEnumerable<Employee> Employees { get; set; }
    }
}
