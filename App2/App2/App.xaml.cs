using App2.Images;
using App2.Lists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace App2
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

            MainPage = new Data.SQLite();
		}

		protected override void OnStart ()
		{
		}

		protected override void OnSleep ()
		{
		}

		protected override void OnResume ()
		{

		}


        public string Name
        {
            get
            {
                if (Application.Current.Properties.ContainsKey("Name"))
                {
                    return Application.Current.Properties["Name"].ToString();
                }
                return "";
            }
            set
            {
                Application.Current.Properties["Name"] = value;
            }
        }

        public bool Notifications
        {
            get
            {
                if (Application.Current.Properties.ContainsKey("Notifications"))
                {
                    return bool.Parse(Application.Current.Properties["Notifications"].ToString());
                }
                return false;
            }
            set
            {
                Application.Current.Properties["Notifications"] = value;
            }
        }
    }
}
