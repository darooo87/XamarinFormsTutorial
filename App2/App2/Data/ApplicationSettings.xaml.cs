using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2.Data
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ApplicationSettings : ContentPage
	{
		public ApplicationSettings ()
		{
			InitializeComponent ();

            BindingContext = Application.Current;
        }
    }
}