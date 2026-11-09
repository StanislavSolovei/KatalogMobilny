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
        //licznik++;
        //int liczbaZnakow = NazwaEntry.Text.Length;
        //string kategoria = KategoriaPicker.SelectedItem.ToString();

        //EtykietaWyniku.Text = $"Kliknięto {licznik} razy. Nazwa ma {liczbaZnakow} znaków. Kategoria: {kategoria}";

        string? nazwa = NazwaEntry.Text;
        if (string.IsNullOrWhiteSpace(nazwa))
        {
            EtykietaWyniku.Text = "Niepoprawna nazwa";
            return;
        }

        if (!double.TryParse(CenaEntry.Text, out double cena))
		{
			EtykietaWyniku.Text = "Niepoprawna cena!";
			return;
		}
		if(!int.TryParse(IloscEntry.Text, out int ilosc))
		{
			EtykietaWyniku.Text = "Niepoprawna ilość!";
			return;
		}
		if(cena < 0 || ilosc < 0)
		{
			EtykietaWyniku.Text = "Cena i ilość nie mogą być ujemna!";
			return;
		}

		double wartosc = cena * ilosc;
		if(KategoriaPicker.SelectedItem == null)
		{
			EtykietaWyniku.Text = "Nie wybrano kategorii!";
			return;
		}
		EtykietaWyniku.Text = $"Produkt: {nazwa}, cena: {cena}, ilość: {ilosc}, kategoria: {KategoriaPicker.SelectedItem}, wartość: {wartosc} zł";
    }

    private void NazwaEntry_TextChanged(object sender, TextChangedEventArgs e)
    {
        string tekst = NazwaEntry.Text;
        int iloscZnakow = tekst.Length;
        EtykietaWyniku.Text = $"Nazwa ma {iloscZnakow} znaków";
    }

    private void NowyProdukt_Reset(object sender, EventArgs e)
    {
		//licznik = 0;
		NazwaEntry.Text = "";
        CenaEntry.Text = "";
        IloscEntry.Text = "";
		KategoriaPicker.SelectedItem = null;
		AvailableSwitch.IsToggled = false;
        EtykietaWyniku.Text = $"Zresetowane";
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

	private void CenaEntry_TextChanged(object sender, TextChangedEventArgs e)
	{
		Entry s = (Entry)sender;

		if(double.TryParse(s.Text, out double wartosc))
		{
			if(wartosc < 0)
			{
				s.BackgroundColor = Colors.Red;
				return;
			}
			else
			{
				s.BackgroundColor = Colors.Green;
			}
		}

		if(!double.TryParse(CenaEntry.Text, out double cena))
		{
            EtykietaWartosc.Text = $"Niepoprawna cena!";
            return;
        }

		if(!int.TryParse(IloscEntry.Text, out int ilosc))
		{
			EtykietaWartosc.Text = $"Niepoprawna ilość!";
			return;
		}
		EtykietaWartosc.Text = $"Wartość produktu: {cena * ilosc}";
	}
}