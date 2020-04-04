using HaruEditor.Common;
using HaruEditor.View.Give;
using System.Windows;
using System.Windows.Controls;

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
            AddTabItem("Give", new GiveControl());
        }

        private void Summon_Button_Click(object sender, RoutedEventArgs e)
        {
            AddTabItem("Summon", new GiveControl());
        }

        private void SetBlock_Button_Click(object sender, RoutedEventArgs e)
        {
            AddTabItem("SetBlock", new GiveControl());
        }

        private void RemoveTab_Button_Click(object sender, RoutedEventArgs e)
        {
            if (TabControl.SelectedIndex >= 0)
            {
                var result = MessageBox.Show("タブを削除してよろしいですか？",
                    HaruEditorConstant.APPLICATION_NAME, MessageBoxButton.YesNo, MessageBoxImage.Information);

                if (result == MessageBoxResult.Yes)
                {
                    TabControl.Items.Remove(TabControl.SelectedItem);
                }
            } 
            else
            {
                MessageBox.Show("削除するタブが選択されていません", 
                    HaruEditorConstant.APPLICATION_NAME, MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void AddTabItem(string header, Control control)
        {
            var tabItem = new TabItem()
            {
                Header = header,
                Content = control
            };
            tabItem.IsSelected = true;
            TabControl.Items.Add(tabItem);
        }
    }
}
