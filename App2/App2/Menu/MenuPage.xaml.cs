using App2.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2.Menu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : MasterDetailPage
    {
        public MenuPage()
        {
            InitializeComponent();

            listView.ItemsSource = new List<Contact>{
                     new Models.Contact { Name = "Option1", Status = "test1" },
                     new Models.Contact { Name = "Option2", Status = "test5" },
                     new Models.Contact { Name = "Option3", Status = "test2" },
                     new Models.Contact { Name = "Option4", Status = "test6" },
                     new Models.Contact { Name = "Option5", Status = "test6" } 
            };

            Detail = new NavigationPage(new Data.SQLite());
        }
    }
}