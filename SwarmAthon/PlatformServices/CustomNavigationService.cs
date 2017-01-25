using Android.App;
using Android.Support.V4.App;
using SwarmAthon.Core.Interfaces.Services.PlatformSpecific;

namespace SwarmAthon.PlatformServices
{
    public class CustomNavigationService : ICustomNavigationService
    {
        private ActivityCompat _activity;

        public void SetCurrentActivity(ActivityCompat activity)
        {
            _activity = activity;
        }
    }
}