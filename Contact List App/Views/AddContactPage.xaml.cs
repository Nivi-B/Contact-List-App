using Microsoft.Maui.Controls;
using Contact_List_App.Models;
using Contact_List_App.ViewModels;

namespace Contact_List_App.Views
{
    public partial class AddContactPage : ContentPage
    {
        public AddContactPage()
        {
            InitializeComponent();
        }

        private async void OnSaveContactClicked(object sender, EventArgs e)
        {
            var contact = new ContactModel
            {
                Name = NameEntry.Text,
                Email = EmailEntry.Text,
                PhoneNumber = PhoneEntry.Text,
                Description = DescriptionEntry.Text
            };

            // You should add the contact to a data store or collection here
            // For example, using a ViewModel that manages the list of contacts

            // Navigate back to the ContactsPage
            await Navigation.PopAsync();
        }
    }
}
