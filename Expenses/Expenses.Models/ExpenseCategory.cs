using System.Collections.Generic;

namespace Expenses.Models
{
	public class ExpenseCategory
	{
		public int Id { get; set; }

		public string Name { get; set; }
		public List<Expense> Expenses { get; set; }

		public override bool Equals(object obj)
			=> obj is ExpenseCategory category &&
			   Id == category.Id;

		protected bool Equals(ExpenseCategory other) => Id == other.Id;

		public override int GetHashCode() => Id;
	}
}
