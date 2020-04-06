using Prism.Mvvm;
using Reactive.Bindings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace HaruEditor.ViewModel.Common
{
    public class MainWindowViewModel : BindableBase
    {
        public ReactiveCommand CloseCommand { get; } = new ReactiveCommand();

        public ReactiveCommand MaximizeCommand { get; } = new ReactiveCommand();

        public ReactiveCommand MinimizeCommand { get; } = new ReactiveCommand();

        public MainWindowViewModel()
        {
            CloseCommand.Subscribe(() =>
            {
                Application.Current.MainWindow.Close();
            });

            MaximizeCommand.Subscribe(() =>
            {
                Application.Current.MainWindow.WindowState =
                    (Application.Current.MainWindow.WindowState == WindowState.Normal)
                        ? WindowState.Maximized
                        : WindowState.Normal;
            });

            MinimizeCommand.Subscribe(() =>
            {
                Application.Current.MainWindow.WindowState = WindowState.Minimized;
            });
        }
    }
}
