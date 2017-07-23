using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2.Images
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ImagesPage : ContentPage
	{
		public ImagesPage ()
		{
			InitializeComponent ();

            //banner.Source = ImageSource.FromResource("dupa.Images.background.jpg");

            //var test = banner.Source;
		}
	}
}