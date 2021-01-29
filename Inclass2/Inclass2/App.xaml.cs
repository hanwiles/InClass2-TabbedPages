using Inclass2.Services;
using Inclass2.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


//Hannah Wiles and Chris Hubler


namespace Inclass2
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new MyTabbedPage();
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
