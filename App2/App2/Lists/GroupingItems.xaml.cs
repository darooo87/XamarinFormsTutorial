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
    public partial class GroupingItems : ContentPage
    {
        public GroupingItems()
        {
            InitializeComponent();

            listView.ItemsSource = new List<ContactGroup>{
                new ContactGroup("J", "J",Contact.Contacts.Where(w => w.Name.StartsWith("J")).ToList()),
                new ContactGroup("D", "D",Contact.Contacts.Where(w => w.Name.StartsWith("D")).ToList()),
        };

        }
    }
}