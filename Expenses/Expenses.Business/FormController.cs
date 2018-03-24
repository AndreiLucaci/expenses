namespace Expenses.Business
{
	public class FormController : System.Windows.Forms.Form
	{
		protected Controller Controller;

		public FormController SetController<T>(T controller)
			where T : Controller
		{
			Controller = controller;
			return this;
		}
	}
}
