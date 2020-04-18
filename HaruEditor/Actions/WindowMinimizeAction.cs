using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using Microsoft.Xaml.Behaviors;

namespace HaruEditor.Actions
{
    public class WindowMinimizeAction : TriggerAction<Button>
    {
        protected override void Invoke(object parameter)
        {
            var window = Window.GetWindow(AssociatedObject);

            window.WindowState = WindowState.Minimized;
        }
    }
}
