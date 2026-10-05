namespace CalculateurAge_.ViewModels;
using System.Windows.Input;

public class RelayCommand : ICommand
{

	private readonly Action _executer;
	private readonly Func<bool>? _peutExecuter;

	public RelayCommand(Action _executer, Func<bool>? _peutExecuter = null)
	{
		this._executer = _executer;
		this._peutExecuter = _peutExecuter;
	}

	public bool CanExecute(object? parameter) => _peutExecuter?.Invoke() ?? true;

	//execute une action au clic
	public void Execute(object p) => _executer();
	public event EventHandler CanExecuteChanged;
	
	public void Rafraichir() => CanExecuteChanged?.Invoke(this, EventArgs.Empty);


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