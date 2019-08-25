using Green_for_the_Earth.Data;
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
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Green_for_the_Earth
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class IndividualResults : Page
    {
        public IndividualResults()
        {
            this.InitializeComponent();

            using(var db = new GreenContext())
            {
                var bars = db.Usuarios.Where(u => u.Id == MainPage.UserId)
                    .Select(l => new { l.Electricidad, l.KmCarro, l.KmCamion, l.KmVuelos, l.KmTaxi, l.Carne }).FirstOrDefault();
                progressBar_House.Value = bars.Electricidad;
                progressBar_Transport.Value = bars.KmCarro + bars.KmCamion + bars.KmVuelos + bars.KmTaxi;
                progressBar_Meat.Value = bars.Carne;
            }

            if (progressBar_House.Value <= 700) progressBar_House.Foreground = new SolidColorBrush(Colors.Green);
            else if (progressBar_House.Value <= 1000) progressBar_House.Foreground = new SolidColorBrush(Colors.YellowGreen);
            else if (progressBar_House.Value <= 1300) progressBar_House.Foreground = new SolidColorBrush(Colors.GreenYellow);
            else if (progressBar_House.Value <= 1600) progressBar_House.Foreground = new SolidColorBrush(Colors.OrangeRed);
            else if (progressBar_House.Value > 1600) progressBar_House.Foreground = new SolidColorBrush(Colors.PaleVioletRed);
            else progressBar_House.Foreground = new SolidColorBrush(Colors.DarkRed);

            if (progressBar_Transport.Value <= 20) progressBar_Transport.Foreground = new SolidColorBrush(Colors.Green);
            else if (progressBar_Transport.Value <= 45) progressBar_Transport.Foreground = new SolidColorBrush(Colors.YellowGreen);
            else if (progressBar_Transport.Value <= 70) progressBar_Transport.Foreground = new SolidColorBrush(Colors.GreenYellow);
            else if (progressBar_Transport.Value <= 90) progressBar_Transport.Foreground = new SolidColorBrush(Colors.OrangeRed);
            else if (progressBar_Transport.Value > 90) progressBar_Transport.Foreground = new SolidColorBrush(Colors.PaleVioletRed);
            else progressBar_Transport.Foreground = new SolidColorBrush(Colors.DarkRed);

            if (progressBar_Meat.Value <= 3) progressBar_Meat.Foreground = new SolidColorBrush(Colors.Green);
            else if (progressBar_Meat.Value <= 8) progressBar_Meat.Foreground = new SolidColorBrush(Colors.YellowGreen);
            else if (progressBar_Meat.Value <= 12) progressBar_Meat.Foreground = new SolidColorBrush(Colors.GreenYellow);
            else if (progressBar_Meat.Value <= 16) progressBar_Meat.Foreground = new SolidColorBrush(Colors.OrangeRed);
            else if (progressBar_Meat.Value > 16) progressBar_Meat.Foreground = new SolidColorBrush(Colors.PaleVioletRed);
            else progressBar_Meat.Foreground = new SolidColorBrush(Colors.DarkRed);

            splitView_tips.PaneBackground= new ImageBrush { ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/backPanelTips.jpg")), Stretch = Stretch.Fill };
        }

        private void Button_return_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(UserMenu));
        }

        private void Button_Tips_Click(object sender, RoutedEventArgs e)
        {
            splitView_tips.IsPaneOpen = true;
        }
    }
}
