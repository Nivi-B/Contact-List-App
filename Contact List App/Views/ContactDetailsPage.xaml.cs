using Microsoft.Maui.Controls;
using Contact_List_App.Models;
using Contact_List_App.ViewModels;

namespace Contact_List_App.Views
{
    public partial class ContactDetailsPage : ContentPage
    {
        public ContactDetailsPage(ContactModel contact)
        {
            InitializeComponent();

            // Set the binding context to the contact passed to this page
            BindingContext = new ContactDetailsViewModel(contact);
        }
    }
}
