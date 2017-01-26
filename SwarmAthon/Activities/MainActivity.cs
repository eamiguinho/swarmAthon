using System;
using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Support.V7.Widget;
using Com.Lilarcor.Cheeseknife;
using SwarmAthon.Android.Adapters;
using SwarmAthon.Core.Interfaces;
using SwarmAthon.UI.ViewModels;
using Toolbar = Android.Support.V7.Widget.Toolbar;

namespace SwarmAthon.Android.Activities
{
	[Activity(Label = "Swarm-A-thon", MainLauncher = true, Icon = "@mipmap/icon", Theme = "@style/MyTheme")]
	public class MainActivity : AppCompatActivity
	{
        [InjectOnClick(Resource.Id.completeButton)]
        void OnClickMyButton(object sender, EventArgs e)
        {
            _viewModel.TestCompleted();
        }

        [InjectView(Resource.Id.testlist)]
        RecyclerView _testList;


	    [InjectView(Resource.Id.main_toolbar)]
        private Toolbar _toolbar;

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

            SetSupportActionBar(_toolbar);

		    // Get our button from the layout resource,
		    // and attach an event to it
                
		}

        private void Vm_DataLoaded(object sender, System.EventArgs e)
        {
            _toolbar.Title = _viewModel.Title;
            _testList.HasFixedSize = true;
            _testList.SetLayoutManager(new LinearLayoutManager(this));
            var adapter = new TestCaseAdapter(_viewModel.TestCases, this);
            _testList.SetAdapter(adapter);
        }

	    public void LoadDetail(TestCaseDataModel item)
	    {
	        _viewModel.SetCurrentTestCaseAndNavigate(item);
	    }
	}
}



