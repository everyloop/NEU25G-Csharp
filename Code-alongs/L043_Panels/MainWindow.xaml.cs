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


namespace L043_Panels
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int stackPanelButtonCount = 1;
        int wrapPanelButtonCount = 1;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void StackPanelButton_Click(object sender, RoutedEventArgs e)
        {
            Button newButton = new Button() {
                Content = ++stackPanelButtonCount,
                HorizontalAlignment = HorizontalAlignment.Left, 
                Width = 20,
                Margin = new Thickness(10, 10, 0, 0),              
            };

            newButton.Click += StackPanelButton_Click;

            stackPanel.Children.Add(newButton);
        }

        private void WrapPanelButton_Click(object sender, RoutedEventArgs e)
        {
            Button newButton = new Button()
            {
                Content = ++wrapPanelButtonCount,
                HorizontalAlignment = HorizontalAlignment.Left,
                Width = 20,
                Margin = new Thickness(10, 10, 0, 0),
            };

            newButton.Click += WrapPanelButton_Click;

            wrapPanel.Children.Add(newButton);
        }

        private void DockPanelButton_Click(object sender, RoutedEventArgs e)
        {
            Dock dockLocation = (Dock)Random.Shared.Next(4);
            Button newButton = new Button() { Content = dockLocation.ToString()[0] };
            newButton.Click += DockPanelButton_Click;

            dockPanel.Children.Add(newButton);
            DockPanel.SetDock(newButton, dockLocation);
        }
    }
}