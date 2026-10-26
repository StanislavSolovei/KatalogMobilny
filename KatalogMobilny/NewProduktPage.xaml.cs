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
		EtykietaWyniku.Text = $"Kliknięto {licznik} razy";
    }

    private void NowyProdukt_Reset(object sender, EventArgs e)
    {
		licznik = 0;
		EtykietaWyniku.Text = $"Kliknięcie zresetowane do {licznik}";
    }
}