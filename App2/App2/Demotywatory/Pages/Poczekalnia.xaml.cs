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

namespace App2.Demotywatory.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Poczekalnia : ContentPage
    {
        private static readonly string FeedUrl = @"http://demotywatory.pl/api/v0/items?status=main&offset=0&limit=20&sort=accepted_at&order=desc";
        private HttpClient httpClient = new HttpClient();
        private ObservableCollection<Models.Demotywator> demotywatory;
        public Poczekalnia()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            try
            {

                httpClient.DefaultRequestHeaders.Add("User-Agent", "androidFuturemind");

                var content = await httpClient.GetStringAsync(FeedUrl);

                var output = JsonConvert.DeserializeObject<Models.DemotywatoryList>(content);

                poczekalnialist.ItemsSource = output.items;

                //listView.ItemsSource = people;

                base.OnAppearing();
            }
            catch (Exception e)
            {

            }

        }
    }

}