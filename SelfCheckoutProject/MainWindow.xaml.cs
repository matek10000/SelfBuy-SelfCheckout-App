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

namespace SelfCheckoutProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Pełny ekran bez obramowania
            WindowState = WindowState.Maximized;
            WindowStyle = WindowStyle.None;
        }

        private void Language_Click(object sender, RoutedEventArgs e)
        {
            Button clickedButton = sender as Button;

            string selectedLanguage = clickedButton.Tag.ToString();

            SecondWindow secondWindow = new SecondWindow(selectedLanguage);
            secondWindow.Show();
            this.Hide();

        }
    }
}
