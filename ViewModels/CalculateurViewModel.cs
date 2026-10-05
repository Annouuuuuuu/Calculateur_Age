namespace CalculateurAge_.ViewModels;

public class CalculateurViewModel : BaseViewModel
{
	private string _nom = "";
	private DateTime _dateNaissance = DateTime.Now.AddYears(-20);
	private string _resultat = "";
	private bool _resultatVisible;

	public string Nom
	{
		get => _nom;
		set
		{
			if (SetField(ref _nom, value))
				RafraichirCommand.Rafraichir();
		}
	}

	public DateTime DateNaissance
	{
		get => _dateNaissance;
		set => SetField(ref _dateNaissance, value);

	}

	public string Resultat
	{
		get => _resultat;
		set => SetField(ref _resultat, value);
	}

	public bool ResultatVisible
	{
		get => _resultatVisible;
		set => SetField(ref _resultatVisible, value);
	}

	public RelayCommand CalculerCommand { get; }

	public CalculateurViewModel()
	{
		CalculerCommand = new RelayCommand(Calculer, () => !string.IsNullOrWhiteSpace(Nom));
	
	}

	private void Calculer()
	{
		int age = DateTime.Now.Year - DateNaissance.Year;
		if (DateNaissance > DateTime.Now.AddYears(-age)) age--;
		Resultat = $"{Nom} vous avez {age} ans.";
		ResultatVisible = true;
	}
}