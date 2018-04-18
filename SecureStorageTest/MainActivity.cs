using Android.App;
using Android.OS;

using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

using Xamarin.Essentials;

namespace SecureStorageTest
{
    [Activity(Label = "SecureStorageTest", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override async void OnCreate(Bundle savedInstanceState)
        {
            AppCenter.Start("3a7d4627-e603-4aa6-8fba-699277e649a9", typeof(Analytics), typeof(Crashes));

            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Main);

            await SecureStorage.SetAsync("key", "my longer value");

            Title = "DONE!";
        }
    }
}

