using System;
using Expenses.Win.ViewModels;

namespace Expenses.Win.Events
{
	public class ExpenseCategoryViewModelEvent : EventArgs
	{
		public ExpenseCategoryViewModel Model { get; set; }
	}
}
