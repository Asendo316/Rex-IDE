using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Skype
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Browser.LoadCompleted+=web_LoadCompleted;
            Browser.Navigate(new Uri("https://skype.com/", UriKind.RelativeOrAbsolute), string.Empty,
            null, string.Format("User-Aent: {0}", "Opera/9.80(J2ME/MIDP; Opera Mini/9 (Compatible; MSIE: 9.0; iPhone; BlackBerry9700; AppleWebKit/24.746; U; en)Presto/2.5.25 Version/10.54"));
        }

        private void web_LoadCompleted(object sender, NavigationEventArgs e)
        {
            load.Visibility =  System.Windows.Visibility.Hidden;
            wait.Visibility = System.Windows.Visibility.Hidden;
            Browser.Visibility = System.Windows.Visibility.Visible;
        }
    }
}
