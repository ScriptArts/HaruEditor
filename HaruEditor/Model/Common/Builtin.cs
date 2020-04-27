using MaterialDesignThemes.Wpf;
using Reactive.Bindings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace HaruEditor.Model.Common
{
    public class Builtin
    {
        /// <summary>
        /// 機能名
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// 機能説明
        /// </summary>
        public string Description { get; }

        /// <summary>
        /// タブ表示名
        /// </summary>
        public string TabName { get; }

        /// <summary>
        /// コントロール
        /// </summary>
        public UserControl Control { get; }

        /// <summary>
        /// 機能リストのボタンクリックコマンド
        /// </summary>
        public ReactiveCommand Click { get; } = new ReactiveCommand();

        public Builtin(string name, string description, string tabName, UserControl control)
        {
            Name = name;
            Description = description;
            TabName = tabName;
            Control = control;
            Click.Subscribe(() =>
            {
                DrawerHost.CloseDrawerCommand.Execute(null, null);
            });
        }
    }
}
