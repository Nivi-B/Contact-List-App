using Contact_List_App.Views;

namespace Contact_List_App
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // Set MainPage as the starting page wrapped in a NavigationPage
            MainPage = new NavigationPage(new MainPage());
        }
    }
}
