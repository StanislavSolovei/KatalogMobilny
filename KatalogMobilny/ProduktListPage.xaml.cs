namespace KatalogMobilny;

public partial class ProduktListPage : ContentPage
{
	private List<Produkt> produkty = new List<Produkt>
	{
		new Produkt("Procesor AMD Ryzen 5", 899, "Procesory", 4),
		new Produkt("Karta Graficzna RTX 4060", 1649, "Karty graficzne", 0),
		new Produkt("Pamięć RAM 16GB", 349, "Pamięci RAM", 12),
		new Produkt("Dysk SSD 1 TB", 349, "Dyski SSD", 7)
	};
	public ProduktListPage()
	{
		InitializeComponent();
		ProductCollectionView.ItemsSource = produkty;
		ProductCountLabel.Text = $"Produktów: {produkty.Count}";
	}

	private async void ProductSelected(object sender, SelectionChangedEventArgs e)
	{
		if(e.CurrentSelection.FirstOrDefault() is Produkt selectedProduct)
		{
			await DisplayAlertAsync("Wybrano", $"Wybrano produkt: {selectedProduct.Nazwa}", "OK");
		}
	}
}