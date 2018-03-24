using System.Windows.Forms;

namespace Expenses.Business
{
	public class UserController : UserControl
	{
		protected Controller Controller;

		public UserController SetController<T>(T controller)
			where T : Controller
		{
			Controller = controller;
			return this;
		}
	}
}
