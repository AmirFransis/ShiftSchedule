
using System.Collections.Generic;
using Domain.Entities;

namespace Domain.Interfaces
{
    public interface IEmployeeRepository
    {
		IEnumerable<Employee> GetEmployees();
    }
}
