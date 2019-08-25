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

            using(var db = new GreenContext())
            {
                var bars = db.Usuarios.Select(l => new { l.Electricidad, l.KmCarro, l.KmCamion, l.KmVuelos, l.KmTaxi, l.Carne }).ToList();
                for(int i = 0; i < bars.Count(); ++i)
                {
                    progressBar_House.Value += bars[i].Electricidad;
                    progressBar_Transport.Value += bars[i].KmCarro + bars[i].KmCamion + bars[i].KmVuelos + bars[i].KmTaxi;
                    progressBar_Meat.Value += bars[i].Carne;
                }

                progressBar_House.Value = progressBar_House.Value/(bars.Count()*1.0);
                progressBar_Transport.Value = progressBar_Transport.Value / (bars.Count() * 1.0);
                progressBar_Meat.Value = progressBar_Meat.Value / (bars.Count() * 1.0);

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
        }

        private void Button_return_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(UserMenu));
        }
    }
}
