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
using System.Windows.Shapes;

namespace WpfBoilerPlate.Views
{
    /// <summary>
    /// Interaction logic for HomeView.xaml
    /// </summary>
    public partial class HomeView : Window
    {
        public HomeView()
        {
            InitializeComponent();
          //  IconPlayer.LoadedBehavior = MediaState.Play;
           // this.Loaded+=Window_Loaded;

        }

        private void IconPlayer_GiveFeedback(object sender, GiveFeedbackEventArgs e)
        {

        }

        private void IconPlayer_MediaFailed(object sender, ExceptionRoutedEventArgs e)
        {
            var ex=e.ErrorException.ToString();

        }

        private void IconPlayer_MediaEnded(object sender, RoutedEventArgs e)
        {
            IconPlayer.Position = new TimeSpan(0,0,1);
            IconPlayer.Play();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            IconPlayer_MediaEnded(sender,e);
        }

       

       
    }
}
