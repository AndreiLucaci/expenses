namespace Expenses.Win.Converters
{
	public abstract class OneWayConverter<TIn, TOut> : IConverter<TIn, TOut>
	{
		public abstract TOut Convert(TIn input);
	}
}
