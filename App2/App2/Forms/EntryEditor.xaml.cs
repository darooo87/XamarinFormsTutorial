using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2.Forms
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EntryEditor : ContentPage
    {
        private string firstName = "Darek";

        public EntryEditor()
        {
            InitializeComponent();

            BindingContext = firstName;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }
    }
}