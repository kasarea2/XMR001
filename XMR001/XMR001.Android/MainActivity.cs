using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Xamarin.Forms;

namespace XMR001.Droid
{
    [Activity(Label = "XMR001", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true
        , ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation
        , ScreenOrientation = ScreenOrientation.SensorPortrait
        )]

    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            //ToolbarResource = Resource.Layout.Toolbar;
           
            base.OnCreate(savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);

            LoadApplication(new App());
        }


        
    }
}