using Green_for_the_Earth.Data;
using System.Linq;
using Windows.Foundation;
using Windows.Graphics.Display;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using System;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Green_for_the_Earth
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            var displayInformation = DisplayInformation.GetForCurrentView();
            var screenSize = new Size(displayInformation.ScreenWidthInRawPixels,
                                      displayInformation.ScreenHeightInRawPixels);
            this.InitializeComponent();
            
            
        }

        private  void Button_register_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(RegistrationMenu));
        }

        private async void Button_login_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new MessageDialog("");
            dialog.Content = "";

            using (var db = new GreenContext())
            {
                var user = db.Uses.FirstOrDefault(l => l.UserName == txtBox_Username.Text 
                && l.Password == txtBox_Password.Password);
                if(user != null)
                    this.Frame.Navigate(typeof(UserMenu));
                else
                    dialog.Content += "The username or password are incorrect\n";
            }

            if (dialog.Content != "")
                await dialog.ShowAsync();
        }

        private void Button_exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Exit();
        }
    }
}
