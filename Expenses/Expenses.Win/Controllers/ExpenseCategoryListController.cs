using Expenses.Business;
using Expenses.Repository;
using Expenses.Win.ViewModelBuilders;
using Expenses.Win.ViewModels;
using Expenses.Win.Views.ExpenseCategoryList;

namespace Expenses.Win.Controllers
{
	public class ExpenseCategoryListController : Controller
	{
		private readonly IRepository _repository;
		private readonly ExpenseCategoryListViewModelBuilder _viewModelBuilder;

		public ExpenseCategoryListController(IRepository repository,
			ExpenseCategoryListViewModelBuilder viewModelBuilder)
		{
			_repository = repository;
			_viewModelBuilder = viewModelBuilder;
		}

		public override UserController GenerateView(object model = null)
		{
			View = new ExpenseCategoryList();

			if (model != null && model is ExpenseCategoryListViewModel viewModel)
			{
				((ExpenseCategoryList) View)?.SetModel(viewModel);
			}

			if (model == null)
			{
				var localViewModel = _viewModelBuilder
					.Create()
					.WithExpenseCategoryList(_repository.GetExpenseCategories())
					.Build();
				((ExpenseCategoryList)View)?.SetModel(localViewModel);
			}

			return View.SetController(this);
		}
	}
}
