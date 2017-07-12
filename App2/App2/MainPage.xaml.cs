using App2.Data;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private List<string> sentences = new List<string>()
        {
            "life is like riding a bicycle",
            "to keep balance you must keep moving",
            "sentence 3",
            "sentence 54",
            "sentence 65"
        };

        private int iterator = 0;

        private void Button_Clicked(object sender, EventArgs e)
        {
            sentence.Text = sentences[iterator];

            if(++iterator >= sentences.Count)
            {
                iterator = 0;
            }
        }

        private void slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            slider.Value = Math.Round(slider.Value, 0);
        }
    }
}
