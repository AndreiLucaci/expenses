using System.Collections.Generic;
using System.Drawing;
using Expenses.Models;

namespace Expenses.Win.ViewModels
{
	public class ExpenseCategoryViewModel
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public IEnumerable<Expense> Expenses { get; set; }

		public Color BackColor { get; set; } = Color.DarkGray;
	}
}
