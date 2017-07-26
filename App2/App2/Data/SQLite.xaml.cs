using App2.Models;
using HelloWorld;
using SQLite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2.Data
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SQLite : ContentPage
    {
        private SQLiteAsyncConnection _connection;
        private ObservableCollection<Person> _people;

        public SQLite()
        {
            InitializeComponent();

            _connection = DependencyService.Get<ISQLiteDb>().GetConnection();
        }

        protected async override void OnAppearing()
        {
            await _connection.CreateTableAsync<Person>();

            var list = await _connection.Table<Person>().ToListAsync();

            _people = new ObservableCollection<Person>(list);

            listView.ItemsSource = _people;

            base.OnAppearing();
        }

        async void OnAdd(object sender, EventArgs e)
        {
            var newPerson = new Person()
            {
                FirstName = "Test",
                LastName = "Test",
                PersonId = 101,
                DateOfBirth = DateTime.Today
            };

            await _connection.InsertAsync(newPerson);

            _people.Add(newPerson);
        }
    }
}