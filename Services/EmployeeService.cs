
using System.Collections.Generic;
using Domain.Entities;
using Domain.Interfaces;
using Services.Interfaces;

namespace Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _repository;

        public EmployeeService(IEmployeeRepository repository)
        {
            _repository = repository;
        }

		public IEnumerable<Employee> GetEmployees()
        {
			return _repository.GetEmployees();
        }
    }
}
