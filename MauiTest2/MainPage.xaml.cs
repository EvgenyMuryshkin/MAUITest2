namespace MauiTest2;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
    }

	private void CrashOnResource_Clicked(object sender, EventArgs e)
	{
        App.Current.MainPage = new CrashOnResource();
    }
    private void NoCellView_Clicked(object sender, EventArgs e)
    {
        App.Current.MainPage = new NoViewCell();
    }
    private void ExtraCellView_Clicked(object sender, EventArgs e)
    {
        App.Current.MainPage = new ExtraViewCell();
    }
    private void RefreshView_Clicked(object sender, EventArgs e)
    {
        App.Current.MainPage = new RefreshViewFill();
    }
}

