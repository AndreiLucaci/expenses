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
		private readonly ExpenseCategoryList _expenseCategoryListView;

		public ExpenseCategoryListController(IRepository repository,
			ExpenseCategoryListViewModelBuilder viewModelBuilder,
			ExpenseCategoryList expenseCategoryListView)
		{
			_repository = repository;
			_viewModelBuilder = viewModelBuilder;
			_expenseCategoryListView = expenseCategoryListView;
		}

		public override UserController GenerateView(object model = null)
		{
			View = _expenseCategoryListView;

			if (model != null && model is ExpenseCategoryListViewModel viewModel)
			{
				_expenseCategoryListView.SetModel(viewModel);
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
