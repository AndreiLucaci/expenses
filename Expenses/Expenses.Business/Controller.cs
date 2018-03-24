namespace Expenses.Business
{
	public abstract class Controller
	{
		protected UserController View;

		public abstract UserController GenerateView(object model = null);
	}
}
