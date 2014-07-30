
using System.Collections.Generic;
using Domain.Entities;

namespace Services.Interfaces
{
    public interface IEmployeeService
    {
		IEnumerable<Employee> GetEmployees();
    }
}
