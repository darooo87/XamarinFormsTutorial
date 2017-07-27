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
    public partial class MessagingSlider : ContentPage
    {
        public MessagingSlider()
        {
            InitializeComponent();
        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            MessagingCenter.Send(this, "sliderValueChanged", e.NewValue);
        }
    }
}