using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Graphics.Display;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Green_for_the_Earth
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class UserMenu : Page
    {
        public UserMenu()
        {
            var displayInformation = DisplayInformation.GetForCurrentView();
            var screenSize = new Size(displayInformation.ScreenWidthInRawPixels,
                                      displayInformation.ScreenHeightInRawPixels);
            this.InitializeComponent();
            
        }

        private void Button_test_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(ClimateChangeTest));
        }

        private void Button_return_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private void Button_exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Exit();
        }

        private void Button_individualProgress_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(IndividualResults));
        }

        private void Button_WorldProgress_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(WorldProgress));
        }
    }
}
