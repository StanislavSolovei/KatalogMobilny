namespace KatalogMobilny;

public partial class NewProduktPage : ContentPage
{
	private int licznik = 0;
	public NewProduktPage()
	{
		InitializeComponent();
	}

    private void NowyProdukt_Clicked(object sender, EventArgs e)
    {
		licznik++;
		int liczbaZnakow = NazwaEntry.Text.Length;
		string kategoria = KategoriaPicker.SelectedItem.ToString();

		EtykietaWyniku.Text = $"Kliknięto {licznik} razy. Nazwa ma {liczbaZnakow} znaków. Kategoria: {kategoria}";
    }

    private void NowyProdukt_Reset(object sender, EventArgs e)
    {
		licznik = 0;
		EtykietaWyniku.Text = $"Kliknięcie zresetowane do {licznik}";
    }

    private void Zmiana(object sender, ToggledEventArgs e)
    {
		if (e.Value)
		{
			CzyDostepny.Text = "Produkt dostępny";
		} else
		{
			CzyDostepny.Text = "Produkt niedostępny";
		}
    }
}