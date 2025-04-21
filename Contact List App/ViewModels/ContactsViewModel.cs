using System.Collections.ObjectModel;
using Contact_List_App.Models;

namespace Contact_List_App.ViewModels
{
    public class ContactsViewModel : BindableObject
    {
        public ObservableCollection<ContactModel> Contacts { get; set; }

        public ContactsViewModel()
        {
            // Example contacts - In reality, these would be loaded from a database or API
            Contacts = new ObservableCollection<ContactModel>
            {
                new ContactModel { Name = "John Doe", Email = "johndoe@example.com", PhoneNumber = "123-456-7890", Description = "Friend" },
                new ContactModel { Name = "Jane Smith", Email = "janesmith@example.com", PhoneNumber = "098-765-4321", Description = "Work" }
            };
        }
    }
}
