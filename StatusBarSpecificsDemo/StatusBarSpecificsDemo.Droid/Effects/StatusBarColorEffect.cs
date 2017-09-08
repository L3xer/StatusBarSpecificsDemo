using System.ComponentModel;
using Android.OS;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using StatusBarSpecificsDemo.Droid.Effects;
using StatusBarSpecificsDemo.PlatformConfiguration.Android;


[assembly: ResolutionGroupName("MyCompany")]
[assembly: ExportEffect(typeof(StatusBarColorEffect), "StatusBarColorEffect")]
namespace StatusBarSpecificsDemo.Droid.Effects
{
    public class StatusBarColorEffect : PlatformEffect
    {
        protected override void OnAttached()
        {
            UpdateColor();
        }

        protected override void OnElementPropertyChanged(PropertyChangedEventArgs args)
        {
            base.OnElementPropertyChanged(args);

            if (args.PropertyName == StatusBarColor.ColorProperty.PropertyName) {
                UpdateColor();
            }
        }

        protected override void OnDetached()
        {
            //nothing to do
        }

        private void UpdateColor()
        {
            var color = StatusBarColor.GetColor(Element);

            if (Build.VERSION.SdkInt >= BuildVersionCodes.Lollipop) {
                Globals.Window.SetStatusBarColor(color.ToAndroid());
            }
        }
    }
}