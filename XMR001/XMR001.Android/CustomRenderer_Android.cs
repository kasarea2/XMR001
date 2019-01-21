using Android.Util;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using XMR001;
using XMR001.Droid;

[assembly: ExportRenderer(typeof(CustomView),typeof(CustomRenderer_Android))]
namespace XMR001.Droid
{
    public class CustomRenderer_Android : ViewRenderer<CustomView,Android.Widget.DatePicker>
    {
        protected override void OnElementChanged(ElementChangedEventArgs<CustomView> e)
        {
            base.OnElementChanged(e);

            var datePicker = new Android.Widget.DatePicker(Forms.Context);

            SetNativeControl(datePicker);
        }
    }
}