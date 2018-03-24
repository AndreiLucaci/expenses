using System.Windows.Forms;
using Expenses.Business;
using Expenses.Win.Controllers;
using Expenses.Win.ViewModels;

namespace Expenses.Win.Views.ExpenseCategoryList
{
	public partial class ExpenseCategoryList : UserController
	{
		public ExpenseCategoryList()
		{
			InitializeComponent();
		}

		public void SetModel(ExpenseCategoryListViewModel viewModel)
		{
			if (viewModel != null)
			{
				foreach (var viewModelExpenseCategory in viewModel.ExpenseCategories)
				{
					var tile = new _ExpenseCategoryTile(viewModelExpenseCategory);

					tile.TileClicked += (sender, ev) =>
					{
						LoadCategoryInformation(ev.Model);
					};

					expenseCategoriesFlowPanel.Controls.Add(tile);
				}
			}
		}

		public ExpenseCategoryListViewModel GetModel()
		{
			return new ExpenseCategoryListViewModel();
		}

		private void LoadCategoryInformation(ExpenseCategoryViewModel viewModel)
		{
			MessageBox.Show(viewModel.Name);
		}
	}
}
