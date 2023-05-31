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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for fooldal.xaml
    /// </summary>
    public partial class fooldal : Window
    {
        public fooldal()
        {
            InitializeComponent();
            petofi_p.Visibility = Visibility.Hidden;
            erkel_p.Visibility = Visibility.Hidden;
            jegenye_p.Visibility = Visibility.Hidden;
            magyar_p.Visibility = Visibility.Hidden;
            dobo_p.Visibility = Visibility.Hidden;
        }

        private void erkel_Click(object sender, RoutedEventArgs e)
        {
            erkel_p.Visibility = Visibility.Visible;
            jegenye_p.Visibility = Visibility.Hidden;
            magyar_p.Visibility = Visibility.Hidden;
            dobo_p.Visibility = Visibility.Hidden;
            petofi_p.Visibility = Visibility.Hidden;
        }

        private void petofi_Click(object sender, RoutedEventArgs e)
        {
            erkel_p.Visibility = Visibility.Hidden;
            jegenye_p.Visibility = Visibility.Hidden;
            magyar_p.Visibility = Visibility.Hidden;
            dobo_p.Visibility = Visibility.Hidden;
            petofi_p.Visibility = Visibility.Visible;
        }

        private void jegenye_Click(object sender, RoutedEventArgs e)
        {
            erkel_p.Visibility = Visibility.Hidden;
            jegenye_p.Visibility = Visibility.Visible;
            magyar_p.Visibility = Visibility.Hidden;
            dobo_p.Visibility = Visibility.Hidden;
            petofi_p.Visibility = Visibility.Hidden;
        }

        private void magyar_Click(object sender, RoutedEventArgs e)
        {
            erkel_p.Visibility = Visibility.Hidden;
            jegenye_p.Visibility = Visibility.Hidden;
            magyar_p.Visibility = Visibility.Visible;
            dobo_p.Visibility = Visibility.Hidden;
            petofi_p.Visibility = Visibility.Hidden;
        }

        private void dobo_Click(object sender, RoutedEventArgs e)
        {
            erkel_p.Visibility = Visibility.Hidden;
            jegenye_p.Visibility = Visibility.Hidden;
            magyar_p.Visibility = Visibility.Hidden;
            dobo_p.Visibility = Visibility.Visible;
            petofi_p.Visibility = Visibility.Hidden;
        }
    }
}
