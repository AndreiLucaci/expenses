using Expenses.Business;
using Expenses.Win.ViewModels;

namespace Expenses.Win.Views
{
	public partial class ExpenseCategoryList : UserController
	{
		public ExpenseCategoryList()
		{
			InitializeComponent();
		}

		public void SetModel(ExpenseCategoryListViewModel viewModel)
		{
		}

		public ExpenseCategoryListViewModel GetModel()
		{
			return new ExpenseCategoryListViewModel();
		}
	}
}
