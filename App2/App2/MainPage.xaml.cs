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
            var list = new ListView();

            list.ItemsSource = Person.People;


            var cellTemplate = new DataTemplate(typeof(TextCell));

            cellTemplate.SetBinding(TextCell.TextProperty, new Binding("Name"));
            cellTemplate.SetBinding(TextCell.DetailProperty, new Binding("Title"));
            cellTemplate.SetValue(TextCell.TextColorProperty, Color.Black);

            list.ItemTemplate = cellTemplate;

            list.ItemSelected += (sender, e) =>
            {
                if(e.SelectedItem != null)
                {
                    Debug.WriteLine(e.SelectedItem);
                    list.SelectedItem = null;
                }
            };

            Content = list;
        }
    }
}
