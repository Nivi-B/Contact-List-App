using Contact_List_App.Models;
using System.Collections.ObjectModel;

namespace Contact_List_App.Views
{
    public partial class MainPage : ContentPage
    {
        public static ObservableCollection<ContactModel> Contacts { get; set; } = new ObservableCollection<ContactModel>
        {
            new ContactModel { Name = "John Doe", Email = "john@example.com", PhoneNumber = "123-456-7890" },
            new ContactModel { Name = "Jane Smith", Email = "jane@example.com", PhoneNumber = "987-654-3210" }
        };

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnSaveContactClicked(object sender, EventArgs e)
        {
            var contact = new ContactModel
            {
                Name = nameEntry.Text,
                Email = emailEntry.Text,
                PhoneNumber = phoneEntry.Text
            };

            Contacts.Add(contact);
            await Navigation.PushAsync(new ContactsPage());
        }

        private async void OnViewContactsClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ContactsPage());
        }
    }
}
