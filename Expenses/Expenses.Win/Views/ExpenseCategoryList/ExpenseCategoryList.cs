using System;
using Expenses.Business;
using Expenses.Win.Converters;
using Expenses.Win.Events;
using Expenses.Win.ViewModels;

namespace Expenses.Win.Views.ExpenseCategoryList
{
	public partial class ExpenseCategoryList : UserController
	{
		private readonly IConverter<ExpenseCategoryViewModel, ExpenseCategorySelectViewModel> _converter;
		public event EventHandler<ExpenseCategorySelectEvent> ExpenseCategorySelected;

		public ExpenseCategoryList(IConverter<ExpenseCategoryViewModel, ExpenseCategorySelectViewModel> converter)
		{
			_converter = converter;
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
			ExpenseCategorySelected?.Invoke(this, new ExpenseCategorySelectEvent
			{
				ExpenseCategorySelectViewModel = _converter.Convert(viewModel)
			});
		}
	}
}
