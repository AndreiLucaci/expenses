using System.Collections.Generic;
using System.Linq;
using Expenses.Models;
using Expenses.Win.Converters;
using Expenses.Win.ViewModels;

namespace Expenses.Win.ViewModelBuilders
{
	public class ExpenseCategoryListViewModelBuilder : IViewModelBuilder<ExpenseCategoryListViewModel>
	{
		private readonly IConverter<ExpenseCategory, ExpenseCategoryViewModel> _converter;
		private ExpenseCategoryListViewModel _expenseCategoryListViewModel;

		public ExpenseCategoryListViewModelBuilder(IConverter<ExpenseCategory, ExpenseCategoryViewModel> converter)
		{
			_converter = converter;
		}

		public ExpenseCategoryListViewModelBuilder Create()
		{
			_expenseCategoryListViewModel = new ExpenseCategoryListViewModel();

			return this;
		}

		public ExpenseCategoryListViewModelBuilder WithExpenseCategoryList(IEnumerable<ExpenseCategory> expenseCategories)
		{
			_expenseCategoryListViewModel.ExpenseCategories = expenseCategories.Select(_converter.Convert);

			return this;
		}

		public ExpenseCategoryListViewModel Build()
		{
			return _expenseCategoryListViewModel;
		}
	}
}
