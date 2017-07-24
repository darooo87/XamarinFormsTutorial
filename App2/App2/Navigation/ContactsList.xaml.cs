using App2.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2.Navigation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactsList : ContentPage
    {
        ObservableCollection<Contact> list = new ObservableCollection<Models.Contact>
                {
                    new Models.Contact{ Name = "Darek", ImageUrl = "http://lorempixel.com/100/100/people/1", Status = "test1"},
                    new Models.Contact{ Name = "Dan", ImageUrl = "http://lorempixel.com/100/100/people/3", Status = "test5"},
                    new Models.Contact{ Name = "John", ImageUrl = "http://lorempixel.com/100/100/people/2", Status = "test2"},
                    new Models.Contact{ Name = "Jack", ImageUrl = "http://lorempixel.com/100/100/people/4", Status = "test6"},
                    new Models.Contact{ Name = "Jeremy", ImageUrl = "http://lorempixel.com/100/100/people/4", Status = "test6"}
                };

        public ContactsList()
        {
            InitializeComponent();

            listView.ItemsSource = list;

        }

        private void searchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            listView.ItemsSource = list.Where(w => w.Name.ToLower().Contains(e.NewTextValue.ToLower()));
        }

        private void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;


            listView.SelectedItem = null;
        }

        private async void Edit_Clicked(object sender, EventArgs e)
        {
            var contact = ((MenuItem)sender).CommandParameter as Models.Contact;

            await Navigation.PushAsync(new ContactDetail(contact));
        }

        private async void Delete_Clicked(object sender, EventArgs e)
        {
            var contact = ((MenuItem)sender).CommandParameter as Models.Contact;

            var result = await DisplayAlert($"Deleting {contact.Name}", "Are you sure?", "Delete", "Cancel");

            if (result)
            {
                list.Remove(contact);
            }
        }
    }
}