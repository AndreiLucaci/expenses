using Unity;

namespace Expenses.Win.Unity
{
	public static class FormsConfiguration
	{
		public static IUnityContainer ConfigureWithForms(this IUnityContainer container)
		{
			container.RegisterType<Expenses>();

			return container;
		}
	}
}
