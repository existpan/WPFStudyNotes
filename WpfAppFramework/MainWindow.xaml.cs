using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfAppFramework
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        ViewModel viewModel = null;
        public MainWindow()
        {
            InitializeComponent();
            viewModel = new ViewModel();
            this.DataContext = viewModel;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            viewModel.Value = "100";
        }
    }
}
