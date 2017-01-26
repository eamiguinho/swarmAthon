using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using SwarmAthon.Core.Interfaces;
using SwarmAthon.UI.ViewModels;

namespace SwarmAthon.Android.Activities
{
    [Activity(Label = "TestCaseActivity", Theme = "@style/MyTheme")]
    public class TestCaseActivity : AppCompatActivity
    {
        private TestCaseViewModel _viewModel;



        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.test_case_detail_layout);

            _viewModel = IoC.Container.GetInstance<TestCaseViewModel>();
            _viewModel.DataLoaded += _viewModel_DataLoaded; 
            _viewModel.LoadData();
        }

        private void _viewModel_DataLoaded(object sender, EventArgs e)
        {
           
        }
    }
}