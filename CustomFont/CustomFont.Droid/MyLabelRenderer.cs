using System;
using Xamarin.Forms.Platform.Android;
using CustomFont;
using CustomFont.Droid;
using Xamarin.Forms;
using Android.Widget;
using Android.Graphics;

[assembly: ExportRenderer(typeof(MyLabel), typeof(MyLabelRenderer))]
namespace CustomFont.Droid
{
    public class MyLabelRenderer : LabelRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);

            var label = (TextView)Control;
            Typeface font = Typeface.CreateFromAsset(Forms.Context.Assets, "SF Hollywood Hills.ttf");
            label.Typeface = font;
        }
    }
}