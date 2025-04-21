using Contact_List_App.Models;

namespace Contact_List_App.Views
{
    public partial class ContactsPage : ContentPage
    {
        public ContactsPage()
        {
            InitializeComponent();
            contactsView.ItemsSource = MainPage.Contacts;
        }

        private async void OnContactSelected(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection.FirstOrDefault() is ContactModel selectedContact)
            {
                await Navigation.PushAsync(new ContactDetailsPage(selectedContact));
                contactsView.SelectedItem = null;
            }
        }

        private async void OnAddContactClicked(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }
    }
}
