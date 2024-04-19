namespace P6Assets_FreddyG.Views;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}

    private void SwVerPassword_Toggled(object sender, ToggledEventArgs e) {
		if (SwVerPassword.IsToggled) {
			TxtPassword.IsPassword = false;
		} else {
            TxtPassword.IsPassword = true;
        }
    }

    private async void BtnSignUp_Clicked(object sender, EventArgs e) {
        await Navigation.PushAsync(new SingUpPage());
    }

    private async void BtnIngresar_Clicked(object sender, EventArgs e) {
        await Navigation.PushAsync(new OptionsPage());
    }

    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e) {

    }
}