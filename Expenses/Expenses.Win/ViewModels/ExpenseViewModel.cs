using System;

namespace Expenses.Win.ViewModels
{
	public class ExpenseViewModel
	{
		public string Title { get; set; }
		public string Description { get; set; }
		public DateTime Date { get; set; }
		public decimal Price { get; set; }
		public int ExpenseCategoryId { get; set; }
	}
}
