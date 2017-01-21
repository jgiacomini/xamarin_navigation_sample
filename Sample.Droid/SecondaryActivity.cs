using Android.App;
using Android.OS;
using Android.Widget;

namespace Sample.Droid
{
    [Activity(Label = "PAGE SECONDAIRE", MainLauncher = false, Icon = "@drawable/icon")]
    public class SecondaryActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Secondary);

            var button = FindViewById<Button>(Resource.Id.MyButton);
            button.Click += OnClick;

            var dataTextView = FindViewById<TextView>(Resource.Id.Data);
            string data = Intent.GetStringExtra("Data");
            if (!string.IsNullOrEmpty(data))
            {
                dataTextView.Text = data;
            }
        }

        private void OnClick(object sender, System.EventArgs e)
        {
            StartActivity(typeof(MainActivity));
        }
    }
}

