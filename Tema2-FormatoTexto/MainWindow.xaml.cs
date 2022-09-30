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

namespace Tema2_FormatoTexto
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void mainInputTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
                mainOutputTextBlock.Text = mainInputTextBox.Text;
        }

        private void boldCheckBox_Checked(object sender, RoutedEventArgs e)
        {
                mainOutputTextBlock.FontWeight = FontWeights.Bold;
        }

        private void boldCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
                mainOutputTextBlock.FontWeight = FontWeights.Normal;
        }

        private void ItalicCheckBox_Checked(object sender, RoutedEventArgs e)
        {
                mainOutputTextBlock.FontStyle = FontStyles.Italic;
        }

        private void ItalicCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
                mainOutputTextBlock.FontStyle = FontStyles.Normal;
        }

        // Colores

        private void colorAzulRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (mainOutputTextBlock != null)
                mainOutputTextBlock.Foreground = Brushes.Blue;
        }

        private void colorRojoRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (mainOutputTextBlock != null)
                mainOutputTextBlock.Foreground = new SolidColorBrush(Colors.Red);
        }

        private void colorVerdeRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (mainOutputTextBlock != null)
                mainOutputTextBlock.Foreground = new SolidColorBrush(Colors.Green);
        }
    }
}
