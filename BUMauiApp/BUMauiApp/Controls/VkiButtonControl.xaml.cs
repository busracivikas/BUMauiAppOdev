namespace BUMauiApp.Controls;

public partial class VkiButton : ContentView
{

    public static readonly BindableProperty IconImageSourceProperty =
        BindableProperty.Create(nameof(IconImageSource), typeof(string), typeof(VkiButton), string.Empty);

    public VkiButton()
	{
		InitializeComponent();
	}

    public string IconImageSource
    {
        get => (string)GetValue(IconImageSourceProperty);
        set => SetValue(IconImageSourceProperty, value);
    }

    public event EventHandler ImageButton_Pressed;

    private void ImgButton_Pressed(object sender, EventArgs e)
    {
        ImageButton_Pressed?.Invoke(this, EventArgs.Empty);
    }

    private void ImageButton_Pressed_1(object sender, EventArgs e)
    {

    }
}