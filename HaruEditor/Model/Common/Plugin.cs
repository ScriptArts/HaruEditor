using HaruEditor.Common;
using HaruEditorLib;
using MaterialDesignThemes.Wpf;
using Prism.Mvvm;
using Reactive.Bindings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace HaruEditor.Model.Common
{
    public class Plugin : BindableBase
    {
        /// <summary>
        /// dllファイルパス
        /// </summary>
        public string DllPath { get; }

        /// <summary>
        /// クラス名
        /// </summary>
        public string ClassName { get; }

        /// <summary>
        /// プラグインの中身
        /// </summary>
        public PluginBase Data { get; }

        /// <summary>
        /// プラグインリストのボタンクリックコマンド
        /// </summary>
        public ReactiveCommand Click { get; } = new ReactiveCommand();

        public Plugin(string path, string name)
        {
            DllPath = path;
            ClassName = name;
            Data = CreateInstance();
            Click.Subscribe(() =>
            {
                Data.Run();
                DrawerHost.CloseDrawerCommand.Execute(null, null);
            });
        }

        /// <summary>
        /// インスタンス生成
        /// </summary>
        /// <returns></returns>
        public PluginBase CreateInstance()
        {
            try
            {
                Assembly asm = Assembly.LoadFrom(DllPath);
                return asm.CreateInstance(ClassName) as PluginBase;
            }
            catch { return null; }
        }
    }
}
