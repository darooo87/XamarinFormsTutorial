using Lamp.Plugin;
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
    public partial class Messaging : ContentPage
    {
        public Messaging()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            CrossLamp.Current.TurnOn();

            MessagingCenter.Subscribe<MessagingSlider, double>(this, "sliderValueChanged", SliderValueChanged);

            Navigation.PushAsync(new MessagingSlider());
        }

        private void SliderValueChanged(MessagingSlider source, double newValue)
        {
            sliderValue.Text = newValue.ToString();
        }
    }
}