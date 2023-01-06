using System;
namespace Domain.Models
{
	public abstract class BaseEntity
	{
		public int Id { get; set; }
		public string Name { get; set; }
	}
}