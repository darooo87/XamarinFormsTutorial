using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2.Resources
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ResourceDictionary : ContentPage
    {
        public ResourceDictionary()
        {
            InitializeComponent();

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var test = Resources;
            Resources["backgroundColor"] = Color.Green;
        }
    }
}