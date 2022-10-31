namespace CruiseTravelApp.Views;

public partial class CruiseDetailsPage : ContentPage
{
	public CruiseDetailsPage()
	{
		InitializeComponent();
        BindingContext = new ViewModels.CruiseViewModel();
    }
}
