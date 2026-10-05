namespace CalculateurAge_.ViewModels;
using System.ComponentModel;
using System.Runtime.CompilerServices;

public class BaseViewModel : INotifyPropertyChanged
{
	public event PropertyChangedEventHandler? PropertyChanged;

	protected void OnPropertyChanged([CallerMemberName] string nom = null)
	{
		PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nom));
	}

	protected bool SetField<T>(ref T field, T value, [CallerMemberName] string nom = null)
	{
		if (EqualityComparer<T>.Default.Equals(field, value))
			return false;

		field = value;
		OnPropertyChanged(nom);
		return true;
	}

	// public BaseViewModel()
	// {
	// 	Content = new VerticalStackLayout
	// 	{
	// 		Children = {
	// 			new Label { HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center, Text = "Welcome to .NET MAUI!"
	// 			}
	// 		}
	// 	};
	// }
}