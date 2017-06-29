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
        public MainPage(string selected)
        {
            var layout = new StackLayout();
            var editor = new Editor();

            var button = new Button();
            button.Text = selected;
            layout.Children.Add(editor);
            layout.Children.Add(button);

            button.Clicked += (sender, e) =>
            {
                if (editor != null && !string.IsNullOrEmpty(editor.Text))
                {
                    Person.People.Add(new Person()
                    {
                        Name = editor.Text,
                        Title = "added"
                    });
                }
                Navigation.PopAsync();
            };


            Content = layout;
        }
    }
}
