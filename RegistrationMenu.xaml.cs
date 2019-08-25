using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
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
    /// This page adds a new user to the database.
    /// </summary>
    public sealed partial class RegistrationMenu : Page
    {
        public RegistrationMenu()
        {
            this.InitializeComponent();
        }

        private void Button_Return_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private async void Button_Register_ClickAsync(object sender, RoutedEventArgs e)
        {
            var dialog = new MessageDialog("");
            dialog.Content = "";
            
            //Add a way to verify that the username does not exists on the database below
            //if( ... ) 
            {

            }//else
            {
                //remove the comment of the line below after checking that the username is unique.
                //dialog.Content += "That username is already taken\n";
            }
            

            if (passwordBox_ConfirmYourPassword.Password == passwordBox_TypeYourPassword.Password)
            {               
                //You can add the logic above this comment for updating the database with a new user.

                //this.Frame.Nav
            }
            else
            {
              
                dialog.Content += "Please verify that both passwords are the same";
                
            }

            if(dialog.Content!="") await dialog.ShowAsync();
            else
            {
                this.Frame.Navigate(typeof(MainPage));               
            }
        }
    }
}
