using Expenses.Win.ViewModels;

namespace Expenses.Win.Converters.ExpenseCategory
{
	public class ExpenseCategoryViewModelToExpenseCategorySelectViewModelConverter 
		: IConverter<ExpenseCategoryViewModel, ExpenseCategorySelectViewModel>
	{
		public ExpenseCategorySelectViewModel Convert(ExpenseCategoryViewModel input)
		{
			return new ExpenseCategorySelectViewModel
			{
				ExpenseCategoryId = input.Id,
				ExpenseCategoryTitle = input.Name
			};
		}
	}
}
