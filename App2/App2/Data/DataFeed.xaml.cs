using App2.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2.Data
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DataFeed : ContentPage
    {
        private static readonly string FeedUrl = @"http://darooo.azurewebsites.net/contact/data";
        private HttpClient httpClient = new HttpClient();
        private ObservableCollection<Person> people;

        public DataFeed()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            var content = await httpClient.GetStringAsync(FeedUrl);
            var output = JsonConvert.DeserializeObject<List<Person>>(content);

            people = new ObservableCollection<Person>(output);
            listView.ItemsSource = people;

            base.OnAppearing();
        }
    }
}