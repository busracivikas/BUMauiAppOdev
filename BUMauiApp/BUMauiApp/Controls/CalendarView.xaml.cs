using BUMauiApp.Model;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace BUMauiApp.Controls;

public partial class CalendarView : StackLayout
{
	#region BindableProperty
	public static readonly BindableProperty SelectedDateProperty = BindableProperty.Create(
		nameof(SelectedDate),
		typeof(DateTime),
		declaringType: typeof(CalendarView),
		defaultBindingMode: BindingMode.TwoWay,
		defaultValue: DateTime.Now
		);

	public DateTime SelectedDate
	{
		get => (DateTime)GetValue(SelectedDateProperty);
		set => SetValue(SelectedDateProperty, value);
	}
	#endregion
	public ObservableCollection<CalendarModel> Dates { get; set; } = new ObservableCollection<CalendarModel>();
	public CalendarView()
	{
		InitializeComponent();
		BindDates(DateTime.Now);
	}

	private void BindDates(DateTime selectedDate)
	{
		int daysCount = DateTime.DaysInMonth(selectedDate.Year, selectedDate.Month);
		for (int day = 1; day <= daysCount; day++)
		{
			Dates.Add(new CalendarModel
			{
				Date = new DateTime(selectedDate.Year, selectedDate.Month, day),
			});
		}
	}

	#region Commads
	public ICommand CurrentDateCommand => new Command<CalendarModel>((currentDate)=>
		{
         SelectedDate = currentDate.Date;
        });
    #endregion
}