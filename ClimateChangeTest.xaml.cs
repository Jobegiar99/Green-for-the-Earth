﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
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
   

    public sealed partial class ClimateChangeTest : Page
    {
        string[] ejemplo = { "HOLA", "UNO", "DOS", "TRES", "CUATRO", "CINCO", "SEIS" };
        int control = 0;
        public ClimateChangeTest()
        {

            this.InitializeComponent();
           
            
        }

        private void Button_finish_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_return_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(UserMenu));
        }

        private void Button_ComboBox_Click(object sender, RoutedEventArgs e)
        {
            if (control < ejemplo.Length - 1) control++;
            else button_finish.Opacity = .85;
        }
    }
}
