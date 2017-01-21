using Android.App;
using Android.OS;
using Android.Widget;

namespace Sample.Droid
{
    [Activity(Label = "PERSISTANT STATE PAGE")]
    public class PersistantStateActivity : Activity
    {
        private int _activityDisplayCounter;

        private const string COUNTER_KEY = "Counter";

        private TextView _counterTextView;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.PersistantState);

            _counterTextView = FindViewById<TextView>(Resource.Id.CounterTextView);

            var button = FindViewById<Button>(Resource.Id.MyButton);
            button.Click += OnClick;

            HandleState(bundle);
        }

        private void OnClick(object sender, System.EventArgs e)
        {
            StartActivity(typeof(MainActivity));
        }

        protected override void OnSaveInstanceState(Bundle outState)
        {
            _activityDisplayCounter++;
            outState.PutInt(COUNTER_KEY, _activityDisplayCounter);

            base.OnSaveInstanceState(outState);
        }

        protected override void OnRestoreInstanceState(Bundle savedInstanceState)
        {
            base.OnRestoreInstanceState(savedInstanceState);

            HandleState(savedInstanceState);
        }

        private void HandleState(Bundle bundle)
        {
            if (bundle != null)
            {
                _activityDisplayCounter = bundle.GetInt(COUNTER_KEY, 0);
            }

            _counterTextView.Text = string.Format("Page affichée {0} fois.", _activityDisplayCounter);
        }
    }
}