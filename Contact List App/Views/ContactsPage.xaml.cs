using Microsoft.Maui.Controls;
using Contact_List_App.Models;
using Contact_List_App.ViewModels;

namespace Contact_List_App.Views
{
    public partial class ContactsPage : ContentPage
    {
        public ContactsPage()
        {
            InitializeComponent();
            BindingContext = new ContactsViewModel();  // Bind the ContactsViewModel to the page
        }

        //private async void OnContactSelected(object sender, SelectionChangedEventArgs e)
        //{
        //    var selectedContact = e.CurrentSelection.FirstOrDefault() as ContactModel;

        //    if (selectedContact != null)
        //    {
        //        // Navigate to ContactDetailsPage with the selected contact
        //        await Navigation.PushAsync(new ContactDetailsPage(selectedContact));
        //    }

        //    // Clear selection
        //    ((CollectionView)sender).SelectedItem = null;
        //}
        private async void OnContactSelected(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection != null && e.CurrentSelection.Count > 0)
            {
                var selectedContact = e.CurrentSelection.FirstOrDefault() as ContactModel;

                if (selectedContact != null)
                {
                    await Navigation.PushAsync(new ContactDetailsPage(selectedContact));
                }

                // Clear selection
                ((CollectionView)sender).SelectedItem = null;
            }
        }

    }
}
