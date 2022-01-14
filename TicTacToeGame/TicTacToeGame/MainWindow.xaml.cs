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

namespace TicTacToeGame
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

        private void ChangeBackground_0(object sender, RoutedEventArgs e)
        {
            OO.Background = OO.Background == Brushes.Red ? new LinearGradientBrush(Colors.Blue, Colors.Blue, 0) : (Brush)Brushes.Red;
        }
        private void ChangeBackground_1(object sender, RoutedEventArgs e)
        {
            IO.Background = IO.Background == Brushes.Red ? new LinearGradientBrush(Colors.Blue, Colors.Blue, 0) : (Brush)Brushes.Red;
        }
        private void ChangeBackground_2(object sender, RoutedEventArgs e)
        {
            ZO.Background = ZO.Background == Brushes.Red ? new LinearGradientBrush(Colors.Blue, Colors.Blue, 0) : (Brush)Brushes.Red;
        }
        private void ChangeBackground_3(object sender, RoutedEventArgs e)
        {
            OI.Background = OI.Background == Brushes.Red ? new LinearGradientBrush(Colors.Blue, Colors.Blue, 0) : (Brush)Brushes.Red;
        }
        private void ChangeBackground_4(object sender, RoutedEventArgs e)
        {
            II.Background = II.Background == Brushes.Red ? new LinearGradientBrush(Colors.Blue, Colors.Blue, 0) : (Brush)Brushes.Red;
        }
        private void ChangeBackground_5(object sender, RoutedEventArgs e)
        {
            ZI.Background = ZI.Background == Brushes.Red ? new LinearGradientBrush(Colors.Blue, Colors.Blue, 0) : (Brush)Brushes.Red;
        }
        private void ChangeBackground_6(object sender, RoutedEventArgs e)
        {
            OZ.Background = OZ.Background == Brushes.Red ? new LinearGradientBrush(Colors.Blue, Colors.Blue, 0) : (Brush)Brushes.Red;
        }
        private void ChangeBackground_7(object sender, RoutedEventArgs e)
        {
            IZ.Background = IZ.Background == Brushes.Red ? new LinearGradientBrush(Colors.Blue, Colors.Blue, 0) : (Brush)Brushes.Red;
        }
        private void ChangeBackground_8(object sender, RoutedEventArgs e)
        {
            ZZ.Background = ZZ.Background == Brushes.Red ? new LinearGradientBrush(Colors.Blue, Colors.Blue, 0) : (Brush)Brushes.Red;
        }


    }
}
