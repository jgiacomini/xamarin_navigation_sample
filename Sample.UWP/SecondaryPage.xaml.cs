using System;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace Sample.UWP
{
    public sealed partial class SecondaryPage : Page
    {
        public SecondaryPage()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            Tuple<string, string> param = e.Parameter as Tuple<string, string>;
            if (param != null)
            {
                txtLabel.Text = param.Item1;
                txtDescription.Text = param.Item2;
            }

            base.OnNavigatedTo(e);
        }

        private void btnNavigation_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }
    }
}
