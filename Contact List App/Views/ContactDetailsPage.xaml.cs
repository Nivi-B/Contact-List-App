using Contact_List_App.Models;

namespace Contact_List_App.Views
{
    public partial class ContactDetailsPage : ContentPage
    {
        public ContactDetailsPage(ContactModel contact)
        {
            InitializeComponent();

            nameLabel.Text = contact.Name;
            emailLabel.Text = contact.Email;
            phoneLabel.Text = contact.PhoneNumber;
        }
    }
}
