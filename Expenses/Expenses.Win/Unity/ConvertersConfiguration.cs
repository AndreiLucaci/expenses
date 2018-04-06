using Expenses.Models;
using Expenses.Win.Converters;
using Expenses.Win.Converters.Expense;
using Expenses.Win.Converters.ExpenseCategory;
using Expenses.Win.ViewModels;
using Unity;

namespace Expenses.Win.Unity
{
	public static class ConvertersConfiguration
	{
		public static IUnityContainer ConfigureWithConverters(this IUnityContainer container)
		{
			container
				.RegisterType<IConverter<ExpenseCategory, ExpenseCategoryViewModel>,
					ExpenseCategoryToExpenseCategoryViewModelConverter>();
			container
				.RegisterType<IConverter<ExpenseCategoryViewModel, ExpenseCategorySelectViewModel>,
					ExpenseCategoryViewModelToExpenseCategorySelectViewModelConverter>();

			container.ConifigureWithTwoWayConverters();

			return container;
		}

		private static IUnityContainer ConifigureWithTwoWayConverters(this IUnityContainer container)
		{
			container.RegisterType<TwoWayConverter<Expense, ExpenseViewModel>,
				ExpenseToExpenseViewModelTwoWayConverter>();

			return container;
		}
	}
}
