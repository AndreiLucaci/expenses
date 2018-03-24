using Expenses.Business;
using Expenses.Win.Controllers;
using Expenses.Win.Views;
using Unity;

namespace Expenses.Win.Unity
{
	public static class UserControllsConfiguration
	{
		public static IUnityContainer ConfigureWithUserControllers(this IUnityContainer container)
		{
			container.RegisterType<UserController, ExpenseCategoryList>();

			return container;
		}
	}
}
