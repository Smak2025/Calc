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
        private double _c = 0.0;
        private int _d = 0;
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
                    case "pm": _c = -_c; break;
                    case ".": _d = 1 ; break;
                    default:
                        {
                            var digit = Double.Parse(btn.Tag.ToString());
                            if (_d == 0)
                            {
                                _c = (Math.Sign(_c) == 0 ? 1 : Math.Sign(_c)) * (Math.Abs(_c) * 10 + digit);
                            } else
                            {
                                _d *= 10;
                                _c = (Math.Sign(_c) ==0 ? 1 : Math.Sign(_c)) * (Math.Abs(_c) + digit/_d);
                            }
                                break;
                        }
                }
                Display.Text = _c.ToString();
                //MessageBox.Show(tag, "Действие:", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
    }
}