using System;
using Android.App;
using Android.Content;
using Android.Support.V4.App;
using SwarmAthon.Android.Activities;
using SwarmAthon.Core.Interfaces.Services.PlatformSpecific;

namespace SwarmAthon.Android.PlatformServices
{
    public class CustomNavigationService : ICustomNavigationService
    {
        private ActivityCompat _activity;

        public void SetCurrentActivity(ActivityCompat activity)
        {
            _activity = activity;
        }

        public void NavigateToTestCase()
        {
            Intent intent = new Intent(Application.Context, typeof(TestCaseActivity));
            intent.SetFlags(ActivityFlags.NewTask);
            (Application.Context).StartActivity(intent);
        }

    }
}