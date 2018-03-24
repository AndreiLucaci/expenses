using System.Collections.Generic;

namespace Expenses.Win.ViewModels
{
	public class ExpenseCategoryListViewModel
	{
		public IEnumerable<ExpenseCategoryViewModel> ExpenseCategories { get; set; }
	}
}
