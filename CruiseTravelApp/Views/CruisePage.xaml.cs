namespace CruiseTravelApp.Views;

public partial class CruisePage : ContentPage
{
	public CruisePage()
	{
		InitializeComponent();
        BindingContext = new ViewModels.CruiseViewModel();

    }
}
