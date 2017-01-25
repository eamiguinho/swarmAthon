using System;
using Android.App;
using Android.Runtime;
using SwarAthon.DataService.Local;
using SwarmAthon.Core.Interfaces;
using SwarmAthon.Core.Models;
using SwarmAthon.DataServices.Online;
using SwarmAthon.Services.Implementation;
using SwarmAthon.UI.ViewModels;

namespace SwarmAthon
{
    [Application]
    public class MyApplication : Application
    {
        public MyApplication(IntPtr handle, JniHandleOwnership transfer)
            : base(handle,transfer)
        {
            // do any initialisation you want here (for example initialising properties)
        }

        public override void OnCreate()
        {
            base.OnCreate();
            ModelsIoCRegister.Register();
            ServicesIoCRegister.Register();
            OnlineDataServicesIoCRegister.Register();
            LocalDataServicesIoCRegister.Register();
            IoC.Container.RegisterSingleton<TestVersionViewModel>();
        }
    }
}