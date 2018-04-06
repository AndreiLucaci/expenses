using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Expenses.Win.Controllers;
using Expenses.Win.ViewModels;
using Expenses.Win.Views.ExpenseCategoryList;

namespace Expenses.Win
{
	public partial class Expenses : Form
	{
		private readonly ExpenseCategoryListController _expenseCategoryListController;
		private readonly ExpenseAddFormController _expenseAddFormController;

		public Expenses()
		{
			InitializeComponent();
		}

		public Expenses(ExpenseCategoryListController expenseCategoryListController,
			ExpenseAddFormController expenseAddFormController)
		{
			InitializeComponent();

			_expenseCategoryListController = expenseCategoryListController;
			_expenseAddFormController = expenseAddFormController;

			Init();
		}

		private void Init()
		{
			var view = _expenseCategoryListController.GenerateView();
			view.Dock = DockStyle.Fill;

			((ExpenseCategoryList) view).ExpenseCategorySelected += (s, e) =>
			{
				Task.Run(() =>
				{
					expenseWorkAreaPanel.Invoke((Action) (() =>
					{
						InitAddForm(e.ExpenseCategorySelectViewModel);
					}));
				});
				InitAddForm(e.ExpenseCategorySelectViewModel);
			};

			expensePanel.Controls.Add(view);
		}

		private void InitAddForm(ExpenseCategorySelectViewModel expenseCategorySelectViewModel)
		{
			var view = _expenseAddFormController.GenerateView(expenseCategorySelectViewModel);
			view.Dock = DockStyle.Fill;

			expenseWorkAreaPanel.Controls.Clear();
			expenseWorkAreaPanel.Controls.Add(view);
			view.Focus();
		}
	}
}
