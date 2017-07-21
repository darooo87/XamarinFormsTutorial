using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AbsoluteLayoutPage : ContentPage
    {
        public AbsoluteLayoutPage()
        {
            InitializeComponent();

            var layout = new AbsoluteLayout();
            Content = layout;

            var box = new BoxView { Color = Color.DarkGray };

            layout.Children.Add(box, new Rectangle(0, 0, 1, 1), AbsoluteLayoutFlags.All);

            var box2 = new BoxView { Color = Color.Silver };

            layout.Children.Add(box2, new Rectangle(0,0,0.5,0.5),  AbsoluteLayoutFlags.SizeProportional);

        }
    }
}