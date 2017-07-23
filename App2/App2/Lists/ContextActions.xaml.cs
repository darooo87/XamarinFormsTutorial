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
	public partial class ContextActions : ContentPage
	{
		public ContextActions ()
		{
			InitializeComponent ();

            listView.ItemsSource = Contact.Contacts;
		}

        private void MenuItem_Clicked(object sender, EventArgs e)
        {

        }

        private void MenuItem_Clicked_1(object sender, EventArgs e)
        {

        }
    }
}