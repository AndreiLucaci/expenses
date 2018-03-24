using System;
using System.Windows.Forms;
using Expenses.Win.Events;
using Expenses.Win.ViewModels;

namespace Expenses.Win.Views.ExpenseCategoryList
{
	public sealed partial class _ExpenseCategoryTile : UserControl
	{
		private readonly ExpenseCategoryViewModel _viewModel;

		public event EventHandler<ExpenseCategoryViewModelEvent> TileClicked;

		public _ExpenseCategoryTile()
		{
			InitializeComponent();
		}

		public _ExpenseCategoryTile(ExpenseCategoryViewModel viewModel)
		{
			_viewModel = viewModel;
			InitializeComponent();

			titleLabel.Text = viewModel.Name;
			BackColor = viewModel.BackColor;
		}

		public void OnTileClicked(object sender, ExpenseCategoryViewModelEvent e)
		{
			var handler = TileClicked;

			handler?.Invoke(sender, e);
		}

		private void titleLabel_Click(object sender, System.EventArgs e)
		{
			OnTileClicked(this, new ExpenseCategoryViewModelEvent
			{
				Model = _viewModel
			});
		}
	}
}
