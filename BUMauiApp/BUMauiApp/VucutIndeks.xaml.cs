namespace BUMauiApp;

public partial class VucutIndeks : ContentPage
{
	public VucutIndeks()
	{
		InitializeComponent();
	}

    public object Vki { get; private set; }

    private void ImgBtnPressed(object sender, EventArgs e)
	{
		var heightInMeter = heightSlider.Value * 100;
		var weightInKg = weightSlider.Value;
		var indeks = weightInKg / (heightInMeter * heightInMeter);

		Shell.Current.DisplayAlert("VKI", $"Vki is {Vki}", "Ok");
	}
}