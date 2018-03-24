﻿namespace Expenses.Win.Converters
{
	public interface IConverter<in TIn, out TOut>
	{
		TOut Convert(TIn input);
	}
}
