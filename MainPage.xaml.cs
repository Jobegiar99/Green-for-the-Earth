using Windows.Foundation;
using Windows.Graphics.Display;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

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

        private void Button_register_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(RegistrationMenu));
        }

        private void Button_login_Click(object sender, RoutedEventArgs e)
        {
            //Logic to check that the password and user matches
            //if(...)
            {
                this.Frame.Navigate(typeof(UserMenu));
            }
        }

        private void Button_exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Exit();
        }
    }
}
