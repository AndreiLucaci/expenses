using Expenses.Business;
using Expenses.Win.Views.Expense;
using Expenses.Win.Views.ExpenseCategoryList;
using Unity;

namespace Expenses.Win.Unity
{
	public static class UserControllsConfiguration
	{
		public static IUnityContainer ConfigureWithUserControllers(this IUnityContainer container)
		{
			container.RegisterType<UserController, ExpenseCategoryList>();
			container.RegisterType<UserController, ExpenseAddForm>();

			return container;
		}
	}
}
