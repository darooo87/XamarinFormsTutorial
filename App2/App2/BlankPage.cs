using App2.Data;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace App2
{
    public class BlankPage : ContentPage
    {
        public BlankPage()
        {
            var listView = new ListView();

            listView.ItemsSource = Person.People;

            var cell = new DataTemplate(typeof(TextCell));
            cell.SetBinding(TextCell.TextProperty, new Binding("Name"));
            cell.SetBinding(TextCell.DetailProperty, new Binding("Title"));
            cell.SetValue(TextCell.TextColorProperty, Color.Black);
            listView.ItemTemplate = cell;

            listView.ItemSelected += (sender, e) =>
            {
                if (e.SelectedItem != null)
                {
                    var item = (Person)e.SelectedItem;
                    Navigation.PushAsync(new MainPage(item.Name));
                    listView.SelectedItem = null;
                }

            };

            Content = listView;

        }
    }
}
