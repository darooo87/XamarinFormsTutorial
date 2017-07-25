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
	public partial class Exercise : ContentPage
	{
        public int imageId = 1;
        private static readonly string ImageServiceUrl = "http://lorempixel.com/1920/1080/city/{0}";

		public Exercise ()
		{
			InitializeComponent ();
          
            SetImageSource(imageId);
        }

        private void Next_Clicked(object sender, EventArgs e)
        {
            imageId++;

            if (imageId > 10)
                imageId = 1;

            SetImageSource(imageId);
        }

        private void Prev_Clicked(object sender, EventArgs e)
        {
            imageId--;

            if (imageId < 1)
                imageId = 10;

            SetImageSource(imageId);
        }

        private void SetImageSource(int imageId)
        {
            image.Source = new UriImageSource()
            {
                Uri = new Uri(string.Format(ImageServiceUrl, imageId)),
                CachingEnabled = false
            };
        }
    }
}