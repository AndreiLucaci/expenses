using System;

namespace Expenses.Models
{
	public class Expense
	{
		public int Id { get; set; }

		public DateTime Date { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public decimal Price { get; set; }

		public int ExpenseCategoryId { get; set; }

		public override bool Equals(object obj)
			=> obj is Expense expense &&
			   Id == expense.Id;

		protected bool Equals(Expense other) => Id == other.Id;

		public override int GetHashCode() => Id;
	}
}
