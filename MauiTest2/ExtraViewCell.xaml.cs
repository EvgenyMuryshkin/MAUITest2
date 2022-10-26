namespace MauiTest2;

public partial class ExtraViewCell : ContentPage
{
	public ExtraViewCell()
	{
		InitializeComponent();
        collection.ItemsSource = new List<string>() { "1", "2", "3" };
    }
}

