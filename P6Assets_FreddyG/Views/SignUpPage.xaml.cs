namespace P6Assets_FreddyG.Views;

public partial class SingUpPage : ContentPage
{
	public SingUpPage()
	{
		InitializeComponent();
	}

    private void BtnAdd_Clicked(object sender, EventArgs e) {

    }

    private async void BtnCancel_Clicked(object sender, EventArgs e) {
        await Navigation.PopAsync();
    }
}