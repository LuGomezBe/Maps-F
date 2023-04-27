using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Maps.Database;
using Maps.View.AccessApp;
using Maps.View.DynamicListView;
using Maps.View.MasterDetail;
using Maps.View.Tabbed;

namespace Maps
{
    public partial class App : Application
    {

        #region Database
        static DatabaseQuerys database;

        public static DatabaseQuerys Database
        {
            get
            {
                if (database == null)
                {
                    database = new DatabaseQuerys(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "DBname.db"));
                }
                return database;
            }
        }
        #endregion

        public App()
        {
            InitializeComponent();

            //MainPage = new NavigationPage(new LoginPage());
            MainPage = new NavigationPage(new LoginPage());

        }
        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
