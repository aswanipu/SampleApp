using SampleApp.Data;
using SampleApp.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace SampleApp
{
    public partial class App : Application
    {
        static PersonDatabase database;
        public App()
        {
            InitializeComponent();

            MainPage =new Home();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
         public static PersonDatabase Database
        {
            get
            {
                if(database== null)
                {
                    database = new PersonDatabase(
                        DependencyService.Get<IFileHelper>().GetLocalFilePath("PersonSqlite.db3"));
                    
                }
                return database;
            }
        }
    }
}
