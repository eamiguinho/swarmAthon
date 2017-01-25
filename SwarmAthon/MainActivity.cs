using System;
using Android.App;
using Android.Widget;
using Android.OS;
using Com.Lilarcor.Cheeseknife;
using SwarmAthon.Core.Interfaces;
using SwarmAthon.UI.ViewModels;

namespace SwarmAthon
{
	[Activity(Label = "Swarm-A-thon", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{
        [InjectView(Resource.Id.testTitle)]
        TextView textView;

        [InjectOnClick(Resource.Id.completeButton)]
        void OnClickMyButton(object sender, EventArgs e)
        {
            _viewModel.TestCompleted();
        }

        int count = 1;
	    private TestVersionViewModel _viewModel;

	    protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Main);
            Cheeseknife.Inject(this);

		    _viewModel = IoC.Container.GetInstance<TestVersionViewModel>();
            _viewModel.DataLoaded += Vm_DataLoaded;
            _viewModel.LoadData();
		    // Get our button from the layout resource,
		    // and attach an event to it
                
		}

        private void Vm_DataLoaded(object sender, System.EventArgs e)
        {
            textView.Text = _viewModel.Title;
        }
    }
}

