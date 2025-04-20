using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ContactApp.Models;

namespace ContactApp.ViewModels
{
    [QueryProperty(nameof(SelectedContact), "SelectedContact")]
    public partial class ContactDetailsViewModel : ObservableObject
    {
        [ObservableProperty] private Contact selectedContact;
        [ObservableProperty] private bool isEditable;

        [RelayCommand]
        private void Edit()
        {
            IsEditable = true;
        }

        [RelayCommand]
        private async Task Save()
        {
            IsEditable = false;
            await Shell.Current.GoToAsync("..");
        }

        [RelayCommand]
        private async Task GoBack()
        {
            await Shell.Current.GoToAsync("..");
        }
    }
}

