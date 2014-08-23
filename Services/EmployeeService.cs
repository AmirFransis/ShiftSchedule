
using System.Collections.Generic;
using ShiftSchedule.Domain.Entities;
using ShiftSchedule.Domain.Interfaces;
using ShiftSchedule.Services.Interfaces;

namespace ShiftSchedule.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _repository;

        public EmployeeService(IEmployeeRepository repository)
        {
            _repository = repository;
        }

        public List<Employee> GetEmployees()
        {
			return _repository.GetEmployees();
        }
    }
}
