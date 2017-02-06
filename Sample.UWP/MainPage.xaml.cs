using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Sample.UWP
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            this.NavigationCacheMode = Windows.UI.Xaml.Navigation.NavigationCacheMode.Enabled;
        }

        private void btnNavigation_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(SecondaryPage));
        }

        private void btnNavigationWithParam_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(SecondaryPage), new Tuple<string, string>("My Label", "My Description"));
        }
    }
}
