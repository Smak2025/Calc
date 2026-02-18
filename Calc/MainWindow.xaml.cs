using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calc
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

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Сброс", "Действие:", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Digit_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button btn)
            {
                string tag;
                switch (btn.Tag)
                {
                    case "pm": tag = "Знак ±"; break;
                    case ".": tag = "Знак \",\""; break;
                    default: tag = $"Цифра {btn.Tag}"; break;
                }
                MessageBox.Show(tag, "Действие:", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
    }
}