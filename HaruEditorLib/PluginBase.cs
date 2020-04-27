using System;
using System.Windows.Controls;

namespace HaruEditorLib
{
    public abstract class PluginBase
    {
        /// <summary>
        /// プラグイン名
        /// </summary>
        public abstract string PluginName { get; }

        /// <summary>
        /// プラグインの説明
        /// </summary>
        public abstract string PluginDescription { get; }

        /// <summary>
        /// プラグインリストに表示
        /// </summary>
        public abstract bool Visible { get; }

        /// <summary>
        /// 自動実行
        /// </summary>
        public abstract bool AutoRun { get; }

        /// <summary>
        /// 実行
        /// </summary>
        public abstract void Run();

        /// <summary>
        /// タブを追加
        /// </summary>
        public Action<string, UserControl> AddTab { get; set; }
    }
}
