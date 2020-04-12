using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Interactivity;

namespace HaruEditor.Actions
{
    public class WindowMaximizeAction : TriggerAction<DependencyObject>
    {
        protected override void Invoke(object parameter)
        {
            var btn = (parameter as RoutedEventArgs).Source as Button;
            var window = Window.GetWindow(btn);

            window.WindowState = window.WindowState == WindowState.Normal ? WindowState.Maximized : WindowState.Normal;
        }
    }
}
