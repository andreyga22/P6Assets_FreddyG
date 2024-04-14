using P6Assets_FreddyG.ViewModels;
using P6Assets_FreddyG.Models;
namespace P6Assets_FreddyG.Views;

public partial class SingUpPage : ContentPage
{
    UserViewModel? vm;
	public SingUpPage()
	{
		InitializeComponent();
        BindingContext = vm = new UserViewModel();
        LoadUserRoles();
	}

    private void BtnAdd_Clicked(object sender, EventArgs e) {

    }

    private async void BtnCancel_Clicked(object sender, EventArgs e) {
        await Navigation.PopAsync();
    }

    private async void LoadUserRoles() {
        CboxUserRole.ItemsSource = await vm.GetAllUserRolesAsync();

    }

}