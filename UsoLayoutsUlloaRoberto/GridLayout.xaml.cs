namespace UsoLayoutsUlloaRoberto;

public partial class GridLayout : ContentPage
{
	public GridLayout()
	{
		InitializeComponent();
	}
    private async void OnGoToStackLayoutClicked(object sender, EventArgs e)
    {
        // Navega a la p�gina StackLayout usando Shell Navigation
        await Shell.Current.GoToAsync(nameof(StackLayout));
    }
}