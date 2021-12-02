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

namespace WordSearchengineInText
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
        private void TextBoxTwo_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            {
                if (textBoxOne.Text == "")
                {
                    labelTwo.Content = "";
                }
                else
                {

                    if (textBoxTwo.Text.Contains(textBoxOne.Text))
                    {
                        labelTwo.Content = $"Found:  {textBoxOne.Text}";
                    }

                    else
                    {
                        labelTwo.Content = "Not found";
                    }
                }
            }
        }

        private void TextBoxTwo_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
