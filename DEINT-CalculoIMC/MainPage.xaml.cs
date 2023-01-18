using DEINT_CalculoIMC.MVVM.ViewModels;

namespace DEINT_CalculoIMC;

public partial class MainPage : ContentPage
{


	public MainPage()
	{
		InitializeComponent();

		BindingContext = new PersonaViewModel();
	}
}

