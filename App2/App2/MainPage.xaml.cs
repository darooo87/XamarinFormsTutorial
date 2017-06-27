using System;
using System.Collections.Generic;
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

        void OnColorSliderChanged(Object sender, EventArgs e)
        {
            var red = sliderRed.Value;
            var green = sliderGreen.Value;
            var blue = sliderBlue.Value;

            box1.Color = Color.FromRgb(red, green, blue);
        }


        //public MainPage()
        //{
        //    var label1 = new Label()
        //    {
        //        Text = "Hello world label",
        //        Font = Font.SystemFontOfSize(NamedSize.Large),
        //    };

        //    var entry1 = new Entry()
        //    {
        //        Placeholder = "enter text here",
        //    };

        //    var button1 = new Button()
        //    {
        //        Text = "Click me!!",

        //    };

        //    button1.Clicked += (sender, e) => {
        //        label1.Text = $"user typed {entry1.Text}";
        //    };

        //    Content = new StackLayout()
        //    {
        //        Padding = 30,
        //        Spacing = 30,
        //        Children = { label1, entry1, button1}
        //    };
        //}

   
    }
}
