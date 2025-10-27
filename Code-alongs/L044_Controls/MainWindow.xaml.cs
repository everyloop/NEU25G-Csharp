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

namespace L044_Controls
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            textBox.Text = "Hello world";
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {   
            if (e.Key == Key.Enter)
            {
                label.Content = textBox.Text;
            }
        }
    }
}