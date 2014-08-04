
using System.Collections.Generic;
using ShiftSchedule.Domain.Entities;

namespace ShiftSchedule.Services.Interfaces
{
    public interface IEmployeeService
    {
		IEnumerable<Employee> GetEmployees();
    }
}
