using Contact_List_App.Models;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Microsoft.Maui.Controls;

namespace Contact_List_App.ViewModels
{
    public class MainViewModel : BindableObject
    {
        private ObservableCollection<ContactModel> _contacts;

        public ObservableCollection<ContactModel> Contacts
        {
            get => _contacts;
            set
            {
                _contacts = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            Contacts = new ObservableCollection<ContactModel>
            {
                new ContactModel { Name = "John Doe", Email = "johndoe@example.com", PhoneNumber = "123-456-7890", Description = "Friend" },
                new ContactModel { Name = "Jane Smith", Email = "janesmith@example.com", PhoneNumber = "098-765-4321", Description = "Work" }
            };
        }
    }
}
