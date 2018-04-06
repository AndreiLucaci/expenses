using System;
using System.Threading.Tasks;
using Expenses.Business;
using Expenses.Win.Converters;
using Expenses.Win.ViewModels;

namespace Expenses.Win.Views.Expense
{
	public partial class ExpenseAddForm : UserController
	{
		private readonly TwoWayConverter<Models.Expense, ExpenseViewModel> _converter;
		private ExpenseCategorySelectViewModel _expenseCategorySelectViewModel;

		public ExpenseAddForm(TwoWayConverter<Models.Expense, ExpenseViewModel> converter)
		{
			_converter = converter;
			InitializeComponent();
		}

		private void resetBtn_Click(object sender, EventArgs e)
		{
			Task.Run(() =>
			{
				titleTxt.Clear();
				descriptionTxt.Clear();
				datePicker.ResetText();
			});
		}

		public void SetModel(ExpenseCategorySelectViewModel expenseCategorySelectViewModel)
		{
			_expenseCategorySelectViewModel = expenseCategorySelectViewModel;

			headerLbl.Text = $@"This is the add form for {_expenseCategorySelectViewModel.ExpenseCategoryTitle}";
		}

		private void nameLbl_Click(object sender, EventArgs e) => titleTxt.Focus();

		private void descriptionLbl_Click(object sender, EventArgs e) => descriptionTxt.Focus();

		private void dateLbl_Click(object sender, EventArgs e) => datePicker.Focus();

		private void priceLbl_Click(object sender, EventArgs e) => priceNumeric.Focus();
	}
}
