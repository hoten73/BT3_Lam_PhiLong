using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Acr.UserDialogs;
using FFImageLoading.Forms.Droid;
using SmartHotel2.Services;
using SmartHotel2.Droid.Services;

namespace SmartHotel2.Droid
{
    [Activity(Label = "SmartHotel2", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;
            Xamarin.FormsMaps.Init(this, bundle);
            CachedImageRenderer.Init(enableFastRenderer: true);
            base.OnCreate(bundle);
            UserDialogs.Init(this);
            global::Xamarin.Forms.Forms.Init(this, bundle);
            ServiceLocator.Instance.Register<IEmailService, EmailServiceDroid>();
            // ServiceLocator.Instance.Register< IEmailService
            LoadApplication(new App());   
        }
    }
}

