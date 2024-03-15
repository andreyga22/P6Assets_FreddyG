using P6Assets_FreddyG.Views;

namespace P6Assets_FreddyG {
    public partial class App : Application {
        public App() {
            InitializeComponent();

            MainPage = new NavigationPage(new LoginPage());
        }
    }
}
