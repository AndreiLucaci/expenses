using Expenses.Win.ViewModelBuilders;
using Expenses.Win.ViewModels;
using Unity;

namespace Expenses.Win.Unity
{
	public static class ViewModelBuildersConfiguration
	{
		public static IUnityContainer ConfigureWithViewModelBuilders(this IUnityContainer container)
		{
			container.RegisterType<IViewModelBuilder<ExpenseCategoryListViewModel>, ExpenseCategoryListViewModelBuilder>();

			return container;
		}
	}
}
