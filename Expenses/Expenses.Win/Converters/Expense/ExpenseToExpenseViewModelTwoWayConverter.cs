using System;
using Expenses.Win.ViewModels;

namespace Expenses.Win.Converters.Expense
{
	public class ExpenseToExpenseViewModelTwoWayConverter : TwoWayConverter<Models.Expense, ExpenseViewModel>
	{
		public override ExpenseViewModel Convert(Models.Expense input)
		{
			return new ExpenseViewModel
			{
				Date = input?.Date ?? default(DateTime),
				Description = input?.Description,
				Price = input?.Price ?? default(decimal),
				Title = input?.Title,
				ExpenseCategoryId = input?.ExpenseCategoryId ?? default(int)
			};
		}

		public override Models.Expense Convert(ExpenseViewModel input)
		{
			return new Models.Expense
			{
				ExpenseCategoryId = input.ExpenseCategoryId,
				Title = input.Title,
				Date = input.Date,
				Description = input.Description,
				Price = input.Price
			};
		}
	}
}
