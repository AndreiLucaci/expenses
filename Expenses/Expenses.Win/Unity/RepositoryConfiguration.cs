using Expenses.Repository;
using Expenses.Repository.File;
using Unity;

namespace Expenses.Win.Unity
{
	public static class RepositoryConfiguration
	{
		public static IUnityContainer ConfigureWithFileRepositories(this IUnityContainer container)
		{
			container.RegisterType<IRepository, JsonRepository>();

			return container;
		}
	}
}
