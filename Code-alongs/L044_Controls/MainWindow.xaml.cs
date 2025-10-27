using System.Security.Principal;
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

namespace L044_Controls;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();

        comboBox.Items.Clear();
        comboBox.Items.Add(new Language("English", "Engelska"));
        comboBox.Items.Add(new Language("Swedish", "Svenska"));
        comboBox.Items.Add(new Language("Spanish", "Spanska"));
        comboBox.DisplayMemberPath = "SwedishName";
    }

    private void textBox_TextChanged(object sender, TextChangedEventArgs e)
    {
        copyButton.IsEnabled = (textBox.Text.Length > 0);
    }

    private void textBox_KeyDown(object sender, KeyEventArgs e)
    {   
        if (e.Key == Key.Enter)
        {
            label.Content = textBox.Text;
        }
    }

    private void copyButton_Click(object sender, RoutedEventArgs e)
    {
        if (radioButtonAppend.IsChecked == true)
        {
            multilineTextBox.Text += Environment.NewLine + textBox.Text; 
        }
        else
        {
            multilineTextBox.Text = textBox.Text;
        }

        comboBox.Items.Add(textBox.Text);
    }

    private void CheckBox_Click(object sender, RoutedEventArgs e)
    {
        copyButton.Visibility = checkBox.IsChecked == true ? Visibility.Collapsed : Visibility.Visible;
    }

    private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        label.Content = (comboBox.SelectedItem as Language)?.EnglishName;
        textBox.Text = (comboBox.SelectedItem as Language)?.SwedishName;
    }

}

public class Language
{
    public Language(string englishName, string swedishName)
    {
        EnglishName = englishName;
        SwedishName = swedishName;
    }

    public string EnglishName { get; set; }
    public string SwedishName { get; set; }
}