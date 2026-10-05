namespace CalculateurAge_.Views;

//relie le paramettre "nom" de l'url a la propriete Nom de la page
[QueryProperty(nameof(Nom), "nom")]
[QueryProperty(nameof(Age), "age")]

public partial class ResultatPage : ContentPage
{
	
	public ResultatPage()
	{
		InitializeComponent();
	}

	//ces propriétés sont remplies automatiquement par la navigation, grace aux attributs QueryProperty, apres le constructeur
	public string Nom { get; set; }
	public int Age { get; set; }

	//construit un arbre visuel decrit par le XAML
	public ResultatPage() => InitializeComponent();

	//Appele a chaque affichage de la page
	protected override void OnAppearing()
	{
		base.OnAppearing();
		lblResultat.Text = $"{Nom} vous avez {Age} ans.";
	}

	//".." = revenir a la page precedente dans la pile de navigation
	private async void OnRetourClicked(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync("..");
	}
}