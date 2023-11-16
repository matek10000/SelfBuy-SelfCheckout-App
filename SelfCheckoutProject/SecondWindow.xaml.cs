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
    /// Logika interakcji dla klasy SecondWindow.xaml
    /// </summary>
    public partial class SecondWindow : Window
    {
        public SecondWindow(string language)
        {
            InitializeComponent();

            // Pełny ekran bez obramowania
            WindowState = WindowState.Maximized;
            WindowStyle = WindowStyle.None;


            string selectedLanguage = language;
            this.Title = $"Second Window - {selectedLanguage.ToUpper()}";

            WhereToEat_text.Text = Translator(selectedLanguage);

        }

        public string Translator(string language)
        {
            if (language == "pl")
            {
                WhereToEat_text.Text = "Gdzie chcesz zjeść?";
            }
            else if (language== "en")
            {
                WhereToEat_text.Text = "Where do you want to eat?";
            }
            else
            {
                WhereToEat_text.Text = "Wo möchtest du essen?";
            }
            return WhereToEat_text.Text;
        }
    }
}