
using System;

namespace Domain.Entities
{
	public class Employee
	{
		public enum Religion
		{
			Judaism = 1,
			Christianity = 2,
			Islam = 3,
			None = 4
		};
		public enum Type
		{
			Hourly = 1,
			Salary = 2,
			None = 3
		};

		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Email { get; set; }
		public Type EType { get; set; }
		public Religion EReligion { get; set; }
		public DateTime DateCreated { get; set; }

	}
}
