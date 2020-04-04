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

namespace HaruEditor
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Give_Button_Click(object sender, RoutedEventArgs e)
        {
        }

        private void Summon_Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SetBlock_Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AddTabItem(string header, Control control)
        {
            var tabItem = new TabItem()
            {
                Header = header,
                Content = control
            };
            tabControl.AddToSource(tabItem);
        }
    }
}
