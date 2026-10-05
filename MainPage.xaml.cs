namespace CalculateurAge_;
using CalculateurAge_.ViewModels;
public partial class MainPage : ContentPage
{
	
	public MainPage()
	{
		InitializeComponent();
		BindingContext = new CalculateurViewModel();
	}

}
