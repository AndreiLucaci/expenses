﻿using System.Configuration;
using Expenses.Repository;
using Expenses.Repository.File;
using Unity;
using Unity.Injection;

namespace Expenses.Win.Unity
{
	public static class RepositoryConfiguration
	{
		public static IUnityContainer ConfigureWithFileRepositories(this IUnityContainer container)
		{
			container.RegisterType<IRepository, JsonRepository>(
				new InjectionConstructor(
					ConfigurationManager.AppSettings["jsonFile"]
				)
			);

			return container;
		}
	}
}
