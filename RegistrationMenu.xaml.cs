using Green_for_the_Earth.Data;
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

            using (var db = new GreenContext())
            {
                var user = db.Usuarios.FirstOrDefault(l => l.UserName == txtBox_Username.Text);

                if (passwordBox_ConfirmYourPassword.Password != passwordBox_TypeYourPassword.Password)
                {
                    dialog.Content += "Please verify that both passwords are the same";
                }
                else if(passwordBox_TypeYourPassword.Password == "" || passwordBox_TypeYourPassword.Password.Length < 3)
                {
                    dialog.Content += "The password is not accepted";

                }
                else if(txtBox_Username.Text == "" || txtBox_Username.Text.Length < 3)
                {
                    dialog.Content += "The username is not valid";

                }
                else if (user != null)
                {
                    dialog.Content += "That username is already taken\n";
                }
                else
                {
                    db.Usuarios.Add(new Model.Usuario{ Password = passwordBox_TypeYourPassword.Password,
                        UserName = txtBox_Username.Text });
                    db.SaveChanges();
                }
            }
            
            if(dialog.Content!="") await dialog.ShowAsync();
            else
            {
                this.Frame.Navigate(typeof(MainPage));               
            }
        }
    }
}
