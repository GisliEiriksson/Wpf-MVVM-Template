using System.Windows;
using Wpf_MVVM_Template.ViewModels;

namespace Wpf_MVVM_Template.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var mainViewModel = new MainViewModel();
            DataContext = mainViewModel;
        }
    }
}
