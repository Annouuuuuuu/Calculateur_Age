namespace CalculateurAge_;
using CalculateurAge_.Views;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(ResultatPage), typeof(ResultatPage));
	}
}
