using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace XMR001
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            switch (Device.Idiom)

            {
                case TargetIdiom.Phone :
                    MainPage = new NavigationPage(new MainPage());
                    break;
                case TargetIdiom.Desktop:
                    MainPage = new Page_Desktop();
                    break;
                default:
                    break;
            }
            
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
