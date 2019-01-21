using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using Xamarin.Forms.Platform.UWP;
using XMR001;
using XMR001.UWP;

[assembly: ExportRenderer(typeof(CustomView), typeof(CustomRenderer_UWP))]
namespace XMR001.UWP
{
    public class CustomRenderer_UWP : ViewRenderer<CustomView,EntryCellTextBox>
    {
        protected override void OnElementChanged(ElementChangedEventArgs<CustomView> e)
        {
            base.OnElementChanged(e);

            var box = new EntryCellTextBox();

            SetNativeControl(box);
        }
    }
}