using System.Collections.Generic;
using Expenses.Models;

namespace Expenses.Win.ViewModels
{
	public class ExpenseCategoryListViewModel
	{
		public IEnumerable<ExpenseCategory> ExpenseCategories { get; set; }
	}
}
