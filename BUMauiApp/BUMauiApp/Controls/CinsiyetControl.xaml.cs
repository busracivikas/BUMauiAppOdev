namespace BUMauiApp.Control;

public partial class CinsiyetControl : ContentView
{
	public static readonly BindableProperty IconImageSourceProperty =
		BindableProperty.Create(nameof(IconImageSource), typeof(string), typeof(CinsiyetControl), string.Empty);

	public static readonly BindableProperty TextProperty =
		BindableProperty.Create(nameof(Text), typeof(string), typeof(CinsiyetControl), string.Empty);

    public static readonly BindableProperty ColorProperty =
        BindableProperty.Create(nameof(Color), typeof(string), typeof(CinsiyetControl), string.Empty, propertyChanged:OnColorChanged);

    public static readonly BindableProperty BgColorProperty =
        BindableProperty.Create(nameof(BgColor), typeof(string), typeof(CinsiyetControl), string.Empty, propertyChanged: OnBgColorChanged);

    private static void OnBgColorChanged(BindableObject bindable, object oldValue, object newValue)
    {
        throw new NotImplementedException();
    }

    public CinsiyetControl()
	{
		InitializeComponent();
	}

	public string IconImageSource
	{
		get => (string)GetValue(IconImageSourceProperty);
		set => SetValue(IconImageSourceProperty, value);
	}

	public string Text 
	{ 
	   get => (string) GetValue(TextProperty);
	   set => SetValue(TextProperty, value); 
    }

    public string Color
    {
        get => (string)GetValue(ColorProperty);
        set => SetValue(ColorProperty, value);
    }

    public string BgColor
    {
        get => (string)GetValue(BgColorProperty);
        set => SetValue(BgColorProperty, value);
    }

    private Color _tintColor = Colors.White;

    public Color TintColor { get=> _tintColor; 
		set { 
		if (_tintColor != value)
			{
				_tintColor = value;
				OnPropertyChanged(nameof(TintColor));
			}
		} 
	}

	private static void OnColorChanged(BindableObject bindable,
		object oldValue, object newValue)
	{
		if(bindable is CinsiyetControl cinsiyetControl)
		{
			if(oldValue != newValue && newValue is not null)
			{
				cinsiyetControl.TintColor = Microsoft.Maui.Graphics.Color.FromArgb(newValue.ToString());
			}
		}
	}
}
