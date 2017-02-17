using Android.App;
using Android.Content.PM;
using Android.OS;
using Microsoft.Azure.Mobile;
using Microsoft.Practices.Unity;
using Prism.Unity;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

namespace PrismUnityApp.Droid
{
    [Activity(Label = "PrismUnityApp", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.tabs;
            ToolbarResource = Resource.Layout.toolbar;

            base.OnCreate(bundle);

            Forms.Init(this, bundle);
            MobileCenter.Configure("c655a85b-fe89-400c-b54f-fd8bd0f26f86");

            LoadApplication(new App(new AndroidInitializer()));
        }
    }

    public class AndroidInitializer : IPlatformInitializer
    {
        public void RegisterTypes(IUnityContainer container)
        {
        }
    }
}