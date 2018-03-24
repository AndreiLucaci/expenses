using System.Collections.Generic;
using System.Drawing;
using Expenses.Models;
using Expenses.Win.ViewModels;

namespace Expenses.Win.Converters.ExpenseCategory
{
	public class ExpenseCategoryToExpenseCategoryViewModelConverter 
		: IConverter<Models.ExpenseCategory, ExpenseCategoryViewModel>
	{
		private static readonly Dictionary<string, Color> Colors = new Dictionary<string, Color>
		{
			[ExpenseCategoryConstants.Other] = Color.DarkSlateBlue,
			[ExpenseCategoryConstants.Clothing] = Color.Aquamarine,
			[ExpenseCategoryConstants.Economy] = Color.DarkOrange,
			[ExpenseCategoryConstants.Food] = Color.IndianRed,
			[ExpenseCategoryConstants.Investment] = Color.ForestGreen,
			[ExpenseCategoryConstants.Maintenance] = Color.Crimson,
			[ExpenseCategoryConstants.Tithe] = Color.DarkViolet,
			[ExpenseCategoryConstants.Transport] = Color.DeepSkyBlue,
			[string.Empty] = Color.DarkGray
		};

		public ExpenseCategoryViewModel Convert(Models.ExpenseCategory input)
		{
			return new ExpenseCategoryViewModel
			{
				Name = input.Name,
				Id = input.Id,
				Expenses = input.Expenses,
				BackColor = Colors.TryGetValue(input.Name, out var color) ? color : Colors[string.Empty]
			};
		}
	}
}
