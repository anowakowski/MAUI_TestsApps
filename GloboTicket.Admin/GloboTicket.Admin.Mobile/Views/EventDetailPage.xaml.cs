using GloboTicket.Admin.Mobile.ViewModels;

namespace GloboTicket.Admin.Mobile.Views;

public partial class EventDetailPage : ContentPage
{
	public EventDetailPage()
	{
		InitializeComponent();

		BindingContext = new EventDetailViewModel();

		//set binding in xmal code
		//LabelEventName.SetBinding(Label.TextProperty, nameof(EventDetailViewModel.Name), BindingMode.OneWay);
    }
}