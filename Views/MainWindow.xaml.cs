using System.Windows;
using System.Windows.Controls;

namespace NuevoBMas.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        public void NavigateTo(Page PreventaPage)
        {
            MainFrame.Navigate(PreventaPage);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           MainFrame.Navigate(Page PreventaPage)
        }
    }
}

