namespace MauiLayouts.Pages;

public partial class StackLayoutDemo : ContentPage
{
	public StackLayoutDemo()
	{
		InitializeComponent();
	}

    private void verticalStackLayoutButton_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new VerticalStackLayoutDemo());
    }

    private void horizontalStackLayoutButton_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new HorizontalStackLayoutDemo());  
    }
}