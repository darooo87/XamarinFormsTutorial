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
	public partial class CellAppearanceCustom : ContentPage
	{
		public CellAppearanceCustom ()
		{
			InitializeComponent ();

            var names = new List<Models.Contact>
            {
                new Models.Contact{ Name = "Darek", ImageUrl = "http://lorempixel.com/100/100/people/1", Status = "test1"},
                new Models.Contact{ Name = "John", ImageUrl = "http://lorempixel.com/100/100/people/2", Status = "test2"}
            };

            listView.ItemsSource = names;
        }

        private void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            listView.SelectedItem = null;
        }
    }
}