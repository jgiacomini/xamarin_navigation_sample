using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;
using System.Collections.Generic;

namespace Sample.Droid
{
    [Activity(Label = "PAGE PRINCIPALE", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);

            var button = FindViewById<Button>(Resource.Id.MyButton);
            button.Click += OnButtonClick;

            var buttonWithData = FindViewById<Button>(Resource.Id.MyButtonWithData);
            buttonWithData.Click += OnButtonWithDataClick;

            var buttonWithPersistantData = FindViewById<Button>(Resource.Id.MyButtonWithPersistantData);
            buttonWithPersistantData.Click += OnButtonWithPersistantDataClick;
        }

        private void OnButtonClick(object sender, System.EventArgs e)
        {
            StartActivity(typeof(SecondaryActivity));
        }

        private void OnButtonWithDataClick(object sender, System.EventArgs e)
        {
            var secondaryActivity = new Intent(this, typeof(SecondaryActivity));
            secondaryActivity.PutExtra("Data", "Some data from MainActivity");
            secondaryActivity.PutExtra("Age", 30);
            secondaryActivity.PutStringArrayListExtra("Names", new List<string> { "Jerôme", "Michaël", "Maxime" });
            StartActivity(secondaryActivity);
        }

        private void OnButtonWithPersistantDataClick(object sender, System.EventArgs e)
        {
            StartActivity(typeof(PersistantStateActivity));
        }
    }
}