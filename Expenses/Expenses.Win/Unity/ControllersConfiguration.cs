using Expenses.Business;
using Expenses.Win.Controllers;
using Unity;

namespace Expenses.Win.Unity
{
	public static class ControllersConfiguration
	{
		public static IUnityContainer ConfigureWithControllers(IUnityContainer container)
		{
			container.RegisterType<Controller, ExpenseCategoryListController>();
			container.RegisterType<Controller, ExpenseAddFormController>();

			return container;
		}
	}
}
