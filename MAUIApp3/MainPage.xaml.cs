using System.Text.RegularExpressions;
namespace MauiApp3;

public partial class MainPage : ContentPage
{
   
    string phonepattern = @"\d{11}$";  /* Must input at least 11 numbers to work
                                        * Can input 11 digits and more
                                        * Pag naglagay ako ng code na gusto ko exact 11 numbers lang, ang nangyayari lumalabas itong syntax sa mismong displayAlert                                       
                                        */
    public MainPage()
    {
        InitializeComponent();

    }

    async void OnDial(object sender, EventArgs e)
    { 
      
        try
        {
              
            if (Regex.IsMatch(PhoneNum.Text, phonepattern)) //inputted the PhoneNum and set pattern
            {
                PhoneDialer.Open(PhoneNum.Text); //entry name
            }

            else
            {
                await DisplayAlert("Invalid input", "Please enter a valid phone number", "OK");

            };
                      
        }

        catch (Exception ex)
        {
           
                await DisplayAlert(ex.Message, "Invalid input", "Please enter a valid phone number", "OK");  

            };

        }

    }

