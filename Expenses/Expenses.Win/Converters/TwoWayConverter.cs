namespace Expenses.Win.Converters
{
	public abstract class TwoWayConverter<TFirst, TSecond>
		: OneWayConverter<TFirst, TSecond>, IConverter<TSecond, TFirst>
	{
		public abstract override TSecond Convert(TFirst input);

		public abstract TFirst Convert(TSecond input);
	}
}
