using Microsoft.Maui.Controls;
using Contact_List_App.ViewModels;

namespace Contact_List_App.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnAddContactClicked(object sender, EventArgs e)
        {
            // Navigate to ContactsPage
            await Navigation.PushAsync(new AddContactPage());
        }
    }
}
