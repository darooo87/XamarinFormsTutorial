using App2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2.Lists
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PullToRefresh : ContentPage
    {
        public PullToRefresh()
        {
            InitializeComponent();

            listView.ItemsSource = Contact.Contacts;
        }

        private void listView_Refreshing(object sender, EventArgs e)
        {
            Contact.Contacts.Clear();
            Contact.Contacts.Add(new Contact()
            {
                ImageUrl = "",
                Name = "test1",
                Status = "test1"
            });

            listView.ItemsSource = Contact.Contacts;

            listView.EndRefresh();
        }
    }
}