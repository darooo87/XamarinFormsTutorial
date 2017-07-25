using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2.Data
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ApplicationSettings : ContentPage
	{
		public ApplicationSettings ()
		{
			InitializeComponent ();

            if (Application.Current.Properties.ContainsKey("Name"))
            {
                title.Text = Application.Current.Properties["Name"].ToString();
            }


            if (Application.Current.Properties.ContainsKey("Notifications"))
            {
                notificationsEnabled.On = bool.Parse(Application.Current.Properties["Notifications"].ToString());
            }
        }

        private void onChange(object sender, EventArgs e)
        {
            Application.Current.Properties["Name"] = title.Text;
            Application.Current.Properties["Notifications"] = notificationsEnabled.On;
        }

    }
}