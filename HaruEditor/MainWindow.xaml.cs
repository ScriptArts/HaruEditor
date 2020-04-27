using HaruEditor.Common;
using HaruEditor.ViewModel.Common;
using System;
using System.Linq;
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

            var vm = DataContext as MainWindowViewModel;
            SetBuiltIns(vm);
            SetPlugins(vm);
        }

        /// <summary>
        /// 組み込み機能
        /// </summary>
        /// <param name="vm"></param>
        private void SetBuiltIns(MainWindowViewModel vm)
        {
            var builtins = FeaturesManager.GetBuiltins()
                .Select(builtin =>
                {
                    builtin.Click.Subscribe(() =>
                    {
                        TabControl.Items.Add(new TabItem()
                        {
                            IsSelected = true,
                            Header = builtin.TabName,
                            Content = builtin.Control
                        });
                    });

                    return builtin;
                })
                .ToList();

            vm.Builtins.AddRangeOnScheduler(builtins);
        }

        /// <summary>
        /// プラグインを取得してリストにセット
        /// </summary>
        /// <param name="vm"></param>
        private void SetPlugins(MainWindowViewModel vm)
        {
            var plugins = FeaturesManager.FindPlugins()
                .Select(plugin =>
                {
                    plugin.Data.AddTab = new Action<string, UserControl>((name, content) =>
                    {
                        TabControl.Items.Add(new TabItem()
                        {
                            IsSelected = true,
                            Header = name,
                            Content = content
                        });
                    });

                    if (plugin.Data.AutoRun) plugin.Data.Run();
                    return plugin;
                })
                .Where(x => x.Data.Visible)
                .ToList();
            vm.Plugins.AddRangeOnScheduler(plugins);
        }
    }
}
