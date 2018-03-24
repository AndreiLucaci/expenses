using System.Collections.Generic;
using Expenses.Models;
using Expenses.Win.ViewModels;

namespace Expenses.Win.ViewModelBuilders
{
	public class ExpenseCategoryListViewModelBuilder : IViewModelBuilder<ExpenseCategoryListViewModel>
	{
		private ExpenseCategoryListViewModel _expenseCategoryListViewModel;

		public ExpenseCategoryListViewModelBuilder Create()
		{
			_expenseCategoryListViewModel = new ExpenseCategoryListViewModel();

			return this;
		}

		public ExpenseCategoryListViewModelBuilder WithExpenseCategoryList(IEnumerable<ExpenseCategory> expenseCategories)
		{
			_expenseCategoryListViewModel.ExpenseCategories = expenseCategories;

			return this;
		}

		public ExpenseCategoryListViewModel Build()
		{
			return _expenseCategoryListViewModel;
		}
	}
}
