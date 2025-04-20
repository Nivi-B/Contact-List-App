using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Collections.Generic;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ContactApp.Models;
using ContactApp.Views;
using Contact_List_App.Views;

namespace ContactApp.ViewModels
{
    public partial class ContactsViewModel : ObservableObject
    {
        public ObservableCollection<Contact> Contacts { get; }

        public ContactsViewModel(ObservableCollection<Contact> contacts)
        {
            Contacts = contacts;
        }

        [RelayCommand]
        private async Task SelectContact(Contact contact)
        {
            var navParams = new Dictionary<string, object>
            {
                { "SelectedContact", contact }
            };

            await Shell.Current.GoToAsync(nameof(ContactDetailsPage), navParams);
        }

        [RelayCommand]
        private async Task AddMore()
        {
            await Shell.Current.GoToAsync(nameof(MainPage));
        }
    }
}
