
using Android.Content.PM;
using Android.App;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using XMR001;
using XMR001.Droid;
using System.Diagnostics;
using Android.OS;

[assembly: ExportRenderer(typeof(ScoreBoardRenderer), typeof(ScoreBoard_Android))]
namespace XMR001.Droid
{
   [Activity(Label = "XMR001", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true
        , ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation
        , ScreenOrientation = ScreenOrientation.SensorLandscape)]

    public class ScoreBoard_Android : ViewRenderer<ScoreBoardRenderer, Android.Widget.DatePicker>
    {
        protected override void OnElementChanged(ElementChangedEventArgs<ScoreBoardRenderer> e)
        {
            base.OnElementChanged(e);

            var datePicker = new Android.Widget.DatePicker(Forms.Context);

        
            SetNativeControl(datePicker);
        }
    }
}