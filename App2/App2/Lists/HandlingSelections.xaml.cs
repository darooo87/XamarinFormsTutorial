using App2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2.Lists
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HandlingSelections : ContentPage
	{
		public HandlingSelections ()
		{
			InitializeComponent ();

            listView.ItemsSource = Contact.Contacts;
		}

        private void listView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var test = e.Item as Contact;

            DisplayAlert("Tapped", test.Name, "Cancel");
        }

        private void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
           var test =  e.SelectedItem as Contact;

            DisplayAlert("Selected", test.Name, "Cancel");
        }
    }
}