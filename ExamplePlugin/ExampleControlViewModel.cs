using Reactive.Bindings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ExamplePlugin
{
    public class ExampleControlViewModel
    {
        public ReactiveCommand ExampleButtonCommand { get; } = new ReactiveCommand();

        public ExampleControlViewModel()
        {
            ExampleButtonCommand.Subscribe(() =>
            {
                MessageBox.Show("サンプルプラグイン", "Example Plugin", MessageBoxButton.OK, MessageBoxImage.Information);
            });
        }
    }
}
