using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using Microsoft.Xaml.Behaviors;
using System.Windows.Media;
using System.Windows.Shapes;

namespace HaruEditor.Actions
{
    public class WindowMaximizeAction : TriggerAction<Button>
    {
        protected override void OnAttached()
        {
            var window = Window.GetWindow(AssociatedObject);
            window.StateChanged += (sender, ev) =>
            {
                if (window.WindowState == WindowState.Normal)
                {
                    // 通常時アイコン
                    (AssociatedObject.Content as Path).Data = Geometry.Parse("M0,0 H12 V12 H0 Z");
                }
                else
                {
                    // 最大化時アイコン
                    (AssociatedObject.Content as Path).Data = Geometry.Parse("M0,4 H8 V12 H0 Z M4,2 V0 H12 V8 H8");
                }
            };
        }

        protected override void Invoke(object parameter)
        {
            var window = Window.GetWindow(AssociatedObject);

            window.WindowState = (window.WindowState == WindowState.Normal) ? WindowState.Maximized : WindowState.Normal;
        }
    }
}
