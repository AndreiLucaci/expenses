using System.Collections.Generic;
using Expenses.Models;

namespace Expenses.Repository
{
	public interface IRepository
	{
		ExpenseCategory GetExpenseCategory(int id);
		IEnumerable<ExpenseCategory> GetExpenseCategories();
		Expense GetExpense(int id);

		int AddExpenseAsync(Expense expense, int categoryId);
		int DeleteExpenseAsync(Expense expense, int categoryId);
		int UpdateExpense(Expense expense);
	}
}
