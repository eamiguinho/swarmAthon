using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;
using Com.Lilarcor.Cheeseknife;

namespace SwarmAthon.Android.Adapters
{
    public class TestCaseViewHolder : RecyclerView.ViewHolder
    {
        [InjectView(Resource.Id.testcase_holder)]
        public LinearLayout LinearLayout;

        [InjectView(Resource.Id.testcase_description)]
        public TextView TextView;

        public TestCaseViewHolder(View view) : base(view)
        {
            Cheeseknife.Inject(this, view);
        }
    }
}