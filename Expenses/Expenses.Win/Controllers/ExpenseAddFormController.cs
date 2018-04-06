using Expenses.Business;
using Expenses.Win.ViewModels;
using Expenses.Win.Views.Expense;

namespace Expenses.Win.Controllers
{
	public class ExpenseAddFormController : Controller
	{
		private readonly ExpenseAddForm _view;

		public ExpenseAddFormController(ExpenseAddForm view)
		{
			_view = view;
		}

		public override UserController GenerateView(object model = null)
		{
			View = _view;

			if (model is ExpenseCategorySelectViewModel i)
			{
				_view.SetModel(i);
			}

			return View.SetController(this);
		}
	}
}
