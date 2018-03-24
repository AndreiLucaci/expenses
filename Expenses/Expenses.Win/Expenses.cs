using System.Windows.Forms;
using Expenses.Win.Controllers;

namespace Expenses.Win
{
	public partial class Expenses : Form
	{
		private readonly ExpenseCategoryListController _expenseCategoryListController;

		public Expenses()
		{
			InitializeComponent();
		}

		public Expenses(ExpenseCategoryListController expenseCategoryListController)
		{
			InitializeComponent();

			_expenseCategoryListController = expenseCategoryListController;

			Init();
		}

		private void Init()
		{
			var view = _expenseCategoryListController.GenerateView();
			view.Dock = DockStyle.Fill;

			expensePanel.Controls.Add(view);
		}
	}
}
