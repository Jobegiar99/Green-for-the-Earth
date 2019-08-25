using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
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
    public sealed partial class WorldProgress : Page
    {
        public WorldProgress()
        {
            this.InitializeComponent();
            if (progressBar_House.Value <= 50) progressBar_House.Foreground = new SolidColorBrush(Colors.Green);
            else if (progressBar_House.Value <= 150) progressBar_House.Foreground = new SolidColorBrush(Colors.YellowGreen);
            else if (progressBar_House.Value <= 250) progressBar_House.Foreground = new SolidColorBrush(Colors.GreenYellow);
            else if (progressBar_House.Value <= 350) progressBar_House.Foreground = new SolidColorBrush(Colors.OrangeRed);
            else if (progressBar_House.Value <= 450) progressBar_House.Foreground = new SolidColorBrush(Colors.PaleVioletRed);
            else progressBar_House.Foreground = new SolidColorBrush(Colors.DarkRed);

            if (progressBar_Transport.Value <= 50) progressBar_Transport.Foreground = new SolidColorBrush(Colors.Green);
            else if (progressBar_Transport.Value <= 150) progressBar_Transport.Foreground = new SolidColorBrush(Colors.YellowGreen);
            else if (progressBar_Transport.Value <= 250) progressBar_Transport.Foreground = new SolidColorBrush(Colors.GreenYellow);
            else if (progressBar_Transport.Value <= 350) progressBar_Transport.Foreground = new SolidColorBrush(Colors.OrangeRed);
            else if (progressBar_Transport.Value <= 450) progressBar_Transport.Foreground = new SolidColorBrush(Colors.PaleVioletRed);
            else progressBar_Transport.Foreground = new SolidColorBrush(Colors.DarkRed);

            if (progressBar_Meat.Value <= 50) progressBar_Meat.Foreground = new SolidColorBrush(Colors.Green);
            else if (progressBar_Meat.Value <= 150) progressBar_Meat.Foreground = new SolidColorBrush(Colors.YellowGreen);
            else if (progressBar_Meat.Value <= 250) progressBar_Meat.Foreground = new SolidColorBrush(Colors.GreenYellow);
            else if (progressBar_Meat.Value <= 350) progressBar_Meat.Foreground = new SolidColorBrush(Colors.OrangeRed);
            else if (progressBar_Meat.Value <= 450) progressBar_Meat.Foreground = new SolidColorBrush(Colors.PaleVioletRed);
            else progressBar_Meat.Foreground = new SolidColorBrush(Colors.DarkRed);
        }

        private void Button_return_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(UserMenu));
        }
    }
}
