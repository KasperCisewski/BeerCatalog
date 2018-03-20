using System;
using KatalogPiw.Services;
using KatalogPiw.Views;
using Xamarin.Forms;

namespace KatalogPiw
{
	public partial class App : Application
	{

		public App ()
		{
			InitializeComponent();


            MainPage = new MainPage();
        }

        static BeerDatabase database;

        public static BeerDatabase Database
        {
            get
            {
                if(database==null)
                {
                    database = new BeerDatabase();
                }
                return database;
            }
        }

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
