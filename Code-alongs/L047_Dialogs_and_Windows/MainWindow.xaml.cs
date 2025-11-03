using Microsoft.Win32;
using System.IO;
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

namespace L047_Dialogs_and_Windows;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void ShowMessageButton_Click(object sender, RoutedEventArgs e)
    {
        MessageBox.Show("This is a message!", "Message to user:");
    }

    private void AddCharacterButton_Click(object sender, RoutedEventArgs e)
    {
        MessageBoxResult result = MessageBox.Show("Do you want to add a character to the button text?", "Update button text?", MessageBoxButton.YesNo);

        if (result == MessageBoxResult.Yes)
        {
            AddCharacterButton.Content += "?";
        }
    }

    private void DisableButton_Click(object sender, RoutedEventArgs e)
    {
        MessageBoxResult result = MessageBox.Show("Do you want to disable this button?", "Disable button?", MessageBoxButton.OKCancel, MessageBoxImage.Warning);

        if (result == MessageBoxResult.OK)
        {
            DisableButton.IsEnabled = false;
        }
    }

    private void OpenFileDialogButton_Click(object sender, RoutedEventArgs e)
    {
        OpenFileDialog dialog = new OpenFileDialog();

        dialog.ShowHiddenItems = true;
        //dialog.FileName = "Fredrik.txt";
        //dialog.InitialDirectory = @"C:\Windows";
        dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        
        if (dialog.ShowDialog() == true)
        {
            OpenFileDialogButton.Content = dialog.FileName;
        }
    }

    private void SaveFileDialogButton_Click(object sender, RoutedEventArgs e)
    {
        var dialog = new SaveFileDialog();

        dialog.ShowHiddenItems = true;
        dialog.FileName = "SaveFileCSharpDemo.txt";
        dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        dialog.OverwritePrompt = true;

        if (dialog.ShowDialog() == true)
        {
            File.WriteAllText(dialog.FileName, AddCharacterButton.Content.ToString());
        }
    }
}