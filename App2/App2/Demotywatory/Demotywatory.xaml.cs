using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2.Demotywatory
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Demotywatory : MasterDetailPage
    {
        List<Models.MenuItem> menuItems = new List<Models.MenuItem>()
        {
            new Models.MenuItem(){ Label = "Main"},
            new Models.MenuItem(){ Label = "Waiting"},
            new Models.MenuItem(){ Label = "Top"}
        };

        public Demotywatory()
        {
            InitializeComponent();

            menuList.ItemsSource = menuItems;

            Detail = new NavigationPage(new Pages.Poczekalnia()) { BarBackgroundColor = Color.Black };
        }
    }
}