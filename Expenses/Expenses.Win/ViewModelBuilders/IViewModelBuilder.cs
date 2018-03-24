namespace Expenses.Win.ViewModelBuilders
{
	public interface IViewModelBuilder<out T>
	{
		T Build();
	}
}
