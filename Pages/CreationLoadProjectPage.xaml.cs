using System.Windows.Controls;

namespace Diasoria.Pages
{
    /// <summary>
    /// Логика взаимодействия для CreationLoadProjectPage.xaml
    /// </summary>
    public partial class CreationLoadProjectPage : Page
    {
        public CreationLoadProjectPage()
        {
            InitializeComponent();
        }

        private void ButtonNewProject_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            NavigationService.Navigate(new ProjectEditorPage());
        }
    }
}
