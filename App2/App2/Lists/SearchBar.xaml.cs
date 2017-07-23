using App2.Models;
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
	public partial class SearchBar : ContentPage
	{
        ObservableCollection<Contact> list = Contact.Contacts;

		public SearchBar ()
		{
			InitializeComponent ();

            listView.ItemsSource = list;
		}

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            list = null;// list.Where(w => w.Name.ToLower().Contains(""));

            listView.ItemsSource = list;
        }
    }
}