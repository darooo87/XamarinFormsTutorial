using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2.Lists
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListTutorial : ContentPage
	{
        ObservableCollection<Models.Contact> contacts = new ObservableCollection<Models.Contact>
                {
                    new Models.Contact{ Name = "Darek", ImageUrl = "http://lorempixel.com/100/100/people/1", Status = "test1"},
                    new Models.Contact{ Name = "Dan", ImageUrl = "http://lorempixel.com/100/100/people/3", Status = "test5"},
                    new Models.Contact{ Name = "John", ImageUrl = "http://lorempixel.com/100/100/people/2", Status = "test2"},
                    new Models.Contact{ Name = "Jack", ImageUrl = "http://lorempixel.com/100/100/people/4", Status = "test6"},
                    new Models.Contact{ Name = "Jeremy", ImageUrl = "http://lorempixel.com/100/100/people/4", Status = "test6"}
                };

        public ListTutorial ()
		{
			InitializeComponent ();

            listView.ItemsSource = contacts;
		}

        private void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;

            contacts.Add(new Models.Contact() { Name = "test", Status = "test" });
            listView.SelectedItem = null;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var contact = ((Button)sender).CommandParameter as Models.Contact;
            contacts.Remove(contact);
        }

        private void listView_Refreshing(object sender, EventArgs e)
        {
            contacts.Add(new Models.Contact() { Name = "test12", Status = "test12", ImageUrl= "http://lorempixel.com/100/100/people/5" });

            listView.EndRefresh();
        }

        private void searchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            listView.ItemsSource = contacts.Where(w => w.Name.ToLower().Contains(e.NewTextValue));
        }
    }
}