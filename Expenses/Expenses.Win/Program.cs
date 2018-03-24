using System;
using System.Windows.Forms;
using Expenses.Win.Unity;
using Unity;

namespace Expenses.Win
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			var container = CreateContainer();

			container
				.ConfigureWithFileRepositories()
				.ConfigureWithConverters()
				.ConfigureWithViewModelBuilders()
				.ConfigureWithUserControllers()
				.ConfigureWithForms();


			var form = container.Resolve<Expenses>();

			Application.EnableVisualStyles();
			//Application.SetCompatibleTextRenderingDefault(false);
			Run(form);
		}

		private static void Run(Form form)
		{
			Application.Run(form);
		}

		public static IUnityContainer CreateContainer()
		{
			return new UnityContainer();;
		}
	}
}
