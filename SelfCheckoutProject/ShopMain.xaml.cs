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

namespace SelfCheckoutProject
{
    /// <summary>
    /// Logika interakcji dla klasy ShopMain.xaml
    /// </summary>
    public partial class ShopMain : Window
    {
        private string selectedLanguage;
        private bool selectedTakeaway;

        public ShopMain(string language, bool takeaway)
        {
            InitializeComponent();

            // Pełny ekran bez obramowania
            WindowState = WindowState.Maximized;
            WindowStyle = WindowStyle.None;

            selectedLanguage = language;
            selectedTakeaway = takeaway;

            // DO TESTÓW
            language_text.Content = selectedLanguage;

            if (selectedTakeaway is false)
                takeaway_text.Content = "NA MIEJSCU";
            if (selectedTakeaway is true)
                takeaway_text.Content = "WYNOS";
            // KONIEC TESTU

            // Wywołanie tłumacza do tekstu
            Translator(selectedLanguage);
        }

        public string Translator(string language)
        {
            if (language == "pl")
            {
                title_text.Text = "Strona główna";
            }
            else if (language == "en")
            {
                title_text.Text = "Home Page";
            }
            else
            {
                title_text.Text = "Startseite";
            }
            return title_text.Text;
        }
    }
}
