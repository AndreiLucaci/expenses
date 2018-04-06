using System;
using Expenses.Win.ViewModels;

namespace Expenses.Win.Events
{
	public class ExpenseCategorySelectEvent : EventArgs
	{
		public ExpenseCategorySelectViewModel ExpenseCategorySelectViewModel { get; set; }
	}
}
