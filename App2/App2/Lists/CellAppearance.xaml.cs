using Android.Provider;
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
	public partial class CellAppearance : ContentPage
	{
		public CellAppearance ()
		{
			InitializeComponent ();

            var names = new List<Models.Contact>
            {
                new Models.Contact{ Name = "Darek", ImageUrl = "http://lorempixel.com/100/100/people/1", Status = "test1"},
                new Models.Contact{ Name = "John", ImageUrl = "http://lorempixel.com/100/100/people/2", Status = "test2"}
            };

            listView.ItemsSource = names;
		}
	}
}