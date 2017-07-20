using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace App2
{
    public partial class InstaPage : ContentPage
    {
        public InstaPage()
        {
            InitializeComponent();

            var grid = new Grid();
            grid.ColumnSpacing = 20;
            grid.RowSpacing = 20;
            grid.BackgroundColor = Color.Gray;

            grid.Children.Add(new Label
            {
                Text = "0,0",
                BackgroundColor = Color.White,
            }, 0, 0);
            grid.Children.Add(new Label
            {
                Text = "0,1",
                BackgroundColor = Color.White
            }, 0, 1);
            grid.Children.Add(new Label
            {
                Text = "1,0",
                BackgroundColor = Color.White
            }, 1, 0);
            var button = new Button
            {
                Text = "1,1",
                BackgroundColor = Color.White,

            };

            button.Clicked += Button_Clicked;

            grid.Children.Add(button, 1, 1);

            Content = grid;

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("test","test","test");
        }
    }
}
