using System.Collections.ObjectModel;
using Android.App;
using Android.Support.V7.Widget;
using Android.Views;
using SwarmAthon.Android.Activities;
using SwarmAthon.UI.ViewModels;

namespace SwarmAthon.Android.Adapters
{
    public class TestCaseAdapter : RecyclerView.Adapter
    {
        private readonly ObservableCollection<TestCaseDataModel> _testCases;
        private readonly MainActivity _activity;

        public TestCaseAdapter(ObservableCollection<TestCaseDataModel> testCases, MainActivity activity)
        {
            _testCases = testCases;
            _activity = activity;
        }

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            var item = _testCases[position];
            var holderparsed = holder as TestCaseViewHolder;
            if (holderparsed != null)
            {
                holderparsed.TextView.Text = item.Description;
                holderparsed.LinearLayout.Click += (sender, args) =>
                {
                    _activity.LoadDetail(item);
                };
            }
        }

      

        public override int ItemCount { get { return _testCases.Count; } }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            var view = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.testcase_item_layout, parent, false);
            var vh = new TestCaseViewHolder(view);
            return vh;
        }

    }
}