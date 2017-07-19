using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace App2
{
    public partial class GridPage : ContentPage
    {
        public GridPage()
        {
            InitializeComponent();

            var grid = new Grid();

            grid.Children.Add(new Label() { Text = "0,0" }, 0, 0);
            grid.Children.Add(new Label() { Text = "0,1" }, 0, 1);
            grid.Children.Add(new Label() { Text = "1,0" }, 1, 0);
            grid.Children.Add(new Label() { Text = "1,1" }, 1, 1);

            Content = grid;
        }

    }
}
