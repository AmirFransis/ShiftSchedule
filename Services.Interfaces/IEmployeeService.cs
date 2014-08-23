
using System.Collections.Generic;
using ShiftSchedule.Domain.Entities;

namespace ShiftSchedule.Services.Interfaces
{
    public interface IEmployeeService
    {
        List<Employee> GetEmployees();
    }
}
