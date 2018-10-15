using System;
using TallerApis.xamarin.View;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace TallerApis.xamarin
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new PublicacionPage());
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
    }
}
