using System;
namespace Domain.Models
{
	public class Student: BaseEntity, IStudent
	{
		public int Id { get; set; }
		public string Name { get; set; }
	}
}