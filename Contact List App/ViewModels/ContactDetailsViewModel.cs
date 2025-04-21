using Contact_List_App.Models;

namespace Contact_List_App.ViewModels
{
    public class ContactDetailsViewModel : BindableObject
    {
        public ContactModel Contact { get; set; }

        public ContactDetailsViewModel(ContactModel contact)
        {
            Contact = contact;
        }
    }
}
