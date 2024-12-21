using Diasoria.Pages;
using System.Windows;

namespace Diasoria
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new CreationLoadProjectPage());
        }
    }
}
