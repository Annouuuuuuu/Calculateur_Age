namespace CalculateurAge_;
using CalculateurAge_.Views;
public partial class MainPage : ContentPage
{
	
	public MainPage()
	{
		InitializeComponent();
	}

	//Gestionnaire appele au clic du bouton calculer
	//sender = le controle clique ; e = donnees de l'evenement
	private async void OnCalculerClicked(object? sender, EventArgs e)
	{

		// Validation : on refuse un nom vide.
		if (string.IsNullOrWhiteSpace(entryNom.Text))
		{
			DisplayAlert("Erreur", "Le nom ne peut pas être vide.", "OK");
			return;
		}
		DateTime d = PickerDate.Date;
		int age = DateTime.Now.Year - d.Year;
		//si la date de naissance n'est pas encore passée cette année, on retire 1 an
		if (d > DateTime.Now.AddYears(-age)) age--;

		//on ecrit directement dans les controles : c'est
		//precisement ce que le MVVM va supprimer.

		await Shell.Current.GoToAsync($"{nameof(ResultatPage)}?nom={entryNom.Text}&age={age}");
	}
}
