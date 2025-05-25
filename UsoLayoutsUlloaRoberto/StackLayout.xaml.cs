namespace UsoLayoutsUlloaRoberto;

public partial class StackLayout : ContentPage
{
	public StackLayout()
	{
		InitializeComponent();
	}
    // Metodo que manejara el evento Click del boton
    private async void OnGoToFlexPageClicked(object sender, EventArgs e)
    {
        // Navega a la pagina llamada "FlexLayout" usando Shell Navigation
        await Shell.Current.GoToAsync(nameof(FlexLayout));
    }

}