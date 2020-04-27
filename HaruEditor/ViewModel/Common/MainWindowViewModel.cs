using HaruEditor.Model.Common;
using Prism.Mvvm;
using Reactive.Bindings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace HaruEditor.ViewModel.Common
{
    public class MainWindowViewModel : BindableBase
    {
        public ReactiveCollection<Builtin> Builtins { get; } = new ReactiveCollection<Builtin>();

        public ReactiveCollection<Plugin> Plugins { get; set; } = new ReactiveCollection<Plugin>();
    }
}
