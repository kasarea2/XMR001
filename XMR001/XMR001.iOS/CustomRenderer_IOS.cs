using System;
using System.Drawing;

using CoreGraphics;
using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using XMR001;
using XMR001.iOS;

[assembly: ExportRenderer(typeof(CustomView), typeof(CustomRenderer_IOS))]
namespace XMR001.iOS
{
    [Register("CustomRenderer_IOS")]
    public class CustomRenderer_IOS : ViewRenderer<CustomView,UIKit.UISlider>
    {
        protected override void OnElementChanged(ElementChangedEventArgs<CustomView> e)
        {
            base.OnElementChanged(e);

            var slider = new UISlider();

            SetNativeControl(slider);
        }
    }
}