using L046_Labb3_Code_Along.Models;
using L046_Labb3_Code_Along.ViewModels;
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

namespace L046_Labb3_Code_Along;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private int count = 1;
    public MainWindow()
    {
        InitializeComponent();

        var pack = new QuestionPack("MyQuestionPack");
        DataContext = new QuestionPackViewModel(pack);
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
        QuestionPackViewModel viewModel = (DataContext as QuestionPackViewModel);
        viewModel.Name = "New name";
        viewModel.Questions.Add(new Question($"Fråga {count++}", "2", "3", "1", "4"));
    }
}