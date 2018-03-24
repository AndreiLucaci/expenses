using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Expenses.Models;
using Newtonsoft.Json;

namespace Expenses.Repository.File
{
	public class JsonRepository : IRepository
	{
		private readonly string _fileName;

		private List<ExpenseCategory> _expenseCategories;

		public JsonRepository(string fileName)
		{
			_fileName = fileName;
			LoadFromFile();
		}

		private void LoadFromFile()
		{
			if (!System.IO.File.Exists(_fileName))
			{
				using (new StreamWriter(_fileName)) { }
			}
			var json = System.IO.File.ReadAllText(_fileName);
			try
			{
				_expenseCategories = JsonConvert.DeserializeObject<List<ExpenseCategory>>(json);
			}
			catch (Exception)
			{
				CreateFile();
			}

			if (_expenseCategories == null || !_expenseCategories.Any())
			{
				CreateFile();
			}
		}

		private void CreateFile()
		{
			var nr = 0;
			var defaultCategories = new[]
			{
				ExpenseCategoryConstants.Tithe, ExpenseCategoryConstants.Clothing, ExpenseCategoryConstants.Economy,
				ExpenseCategoryConstants.Food, ExpenseCategoryConstants.Investment,
				ExpenseCategoryConstants.Maintenance, ExpenseCategoryConstants.Transport, ExpenseCategoryConstants.Other
			};

			_expenseCategories = new List<ExpenseCategory>(defaultCategories.Select(i => new ExpenseCategory
			{
				Id = nr++,
				Name = i
			}));

			Save();
		}

		public ExpenseCategory GetExpenseCategory(int id)
		{
			return _expenseCategories.FirstOrDefault(i => i.Id == id);
		}

		public IEnumerable<ExpenseCategory> GetExpenseCategories()
		{
			return _expenseCategories;
		}

		public Expense GetExpense(int id)
		{
			return _expenseCategories.SelectMany(i => i.Expenses).FirstOrDefault(i => i.Id == id);
		}

		public int AddExpenseAsync(Expense expense, int categoryId)
		{
			var expenseCategory = _expenseCategories.FirstOrDefault(i => i.Id == categoryId);
			if (expenseCategory != null)
			{
				expenseCategory.Expenses.Add(expense);
				return Save();
			}
			return default(int);
		}

		public int DeleteExpenseAsync(Expense expense, int categoryId)
		{
			var expenseCategory = _expenseCategories.FirstOrDefault(i => i.Id == categoryId);
			if (expenseCategory != null)
			{
				if (expenseCategory.Expenses.Remove(expense))
				{
					return Save();
				}
			}
			return default(int);
		}

		public int UpdateExpense(Expense expense)
		{
			var expenseCategory = _expenseCategories.FirstOrDefault(i => i.Expenses.Contains(expense));
			if (expenseCategory != null)
			{
				var index = expenseCategory.Expenses.IndexOf(expense);
				if (index != -1)
				{
					expenseCategory.Expenses[index] = expense;
					return Save();
				}
			}
			return default(int);
		}

		public int Save()
		{
			System.IO.File.WriteAllText(_fileName, JsonConvert.SerializeObject(_expenseCategories, Formatting.Indented));
			return 1;
		}
	}
}
