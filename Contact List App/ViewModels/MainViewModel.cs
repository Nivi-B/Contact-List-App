using System.Collections.ObjectModel;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ContactApp.Models;
using ContactApp.Views;
using System;
using Contact_List_App.Views;
using System.Xml.Linq;

namespace ContactApp.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty] private string name;
        [ObservableProperty] private string email;
        [ObservableProperty] private string phoneNumber;
        [ObservableProperty] private string description;

        public ObservableCollection<Contact> Contacts { get; }

        public MainViewModel(ObservableCollection<Contact> contacts)
        {
            Contacts = contacts;
        }

        [RelayCommand]
        private async Task Save()
        {
            Contacts.Add(new Contact
            {
                Name = Name,
                Email = Email,
                PhoneNumber = PhoneNumber,
                Description = Description
            });

            await Shell.Current.GoToAsync(nameof(ContactsPage));
        }
    }
}
