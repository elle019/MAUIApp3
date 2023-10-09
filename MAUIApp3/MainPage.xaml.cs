

namespace MAUIApp3;

public partial class MainPage : ContentPage
{
	
	public MainPage()
	{
		InitializeComponent();
	}

	async void OnDial(object sender, EventArgs e)
	{
        try
        {
            PhoneDialer.Open(PhoneNum.Text);
        }
        catch (Exception)
        {
            await DisplayAlert("Invalid input", "Please enter a valid phone number", "OK");
            throw;
        }
    }



}

