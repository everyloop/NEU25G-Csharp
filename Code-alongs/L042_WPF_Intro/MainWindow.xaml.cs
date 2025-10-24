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

namespace L042_WPF_Intro
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

        private void MyButton_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
            {
                button.Content += "!";
            }
            //MessageBox.Show("Hello world!");
            //MyButton.HorizontalAlignment = HorizontalAlignment.Left;
        }
    }
}