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

namespace Neat_UI
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

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void Window_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (e.RightButton == MouseButtonState.Pressed)
            {
                Close();
            }
        }

        private void btn_submit_register_Click(object sender, RoutedEventArgs e)
        {
            if (txtbox_name.Text != "" && txtbox_email.Text != "" && txtbox_phnum.Text != "" && txtbox_pass.Password != "" && txtbox_cpass.Password != "")
            {
                MessageBoxResult result = MessageBox.Show("Click OK to redirect Login page", "Confirmation", MessageBoxButton.OKCancel, MessageBoxImage.Information);
                if (result == MessageBoxResult.OK)
                {
                    login loginhome = new login();
                    loginhome.Show();
                }
                else
                {
                    MessageBox.Show("Please enter all the details", "Registration Page", MessageBoxButton.OKCancel, MessageBoxImage.Error);
                }
            }
        }
    }
}
