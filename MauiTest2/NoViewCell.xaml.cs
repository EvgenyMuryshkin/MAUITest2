namespace MauiTest2;

public partial class NoViewCell : ContentPage
{
	public NoViewCell()
	{
		InitializeComponent();
		list.ItemsSource = new List<string>() { "1", "2", "3" };
    }
}

