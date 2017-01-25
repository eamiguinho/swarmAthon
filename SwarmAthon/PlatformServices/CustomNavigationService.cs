using Android.App;
using SwarmAthon.Core.Interfaces.Services.PlatformSpecific;

namespace SwarmAthon.PlatformServices
{
    public class CustomNavigationService : ICustomNavigationService
    {
        private Activity _activity;

        public void SetCurrentActivity(ActivityCompat activity)
        {
            _activity = activity;
        }
    }
}