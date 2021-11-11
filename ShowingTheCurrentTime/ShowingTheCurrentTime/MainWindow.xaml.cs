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

namespace ShowingTheCurrentTime
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            helloWorldLabel.Content = "Hello world!!!";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            helloWorldLabel.Content = "Witaj świecie!!!";
        }

        private void timeNow_MouseEnter(object sender, MouseEventArgs e)
        {
            DateTime czas = DateTime.Now;
            timeNow.Content = czas.ToString("T");
        }

        private void timeNow_MouseLeave(object sender, MouseEventArgs e)
        {
            timeNow.Content = "Move your cursor over here again";
        }
    }
}
