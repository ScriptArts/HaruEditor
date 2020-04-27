using HaruEditor.Model.Common;
using HaruEditor.View.Give;
using HaruEditor.View.Summon;
using HaruEditorLib;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HaruEditor.Common
{
    public static class FeaturesManager
    {
        /// <summary>
        /// 組み込み機能をリストで返します
        /// </summary>
        /// <returns></returns>
        public static List<Builtin> GetBuiltins()
        {
            return new List<Builtin>()
            {
                new Builtin("Give", "Giveコマンドの生成タブを追加します", "Give", new GiveControl()),
                new Builtin("Summon", "Summonコマンドの生成タブを追加します", "Summon", new SummonControl()),
                new Builtin("SetBlock", "SetBlockコマンドの生成タブを追加します", "SetBlock", new GiveControl())
            };
        }

        /// <summary>
        /// プラグインフォルダから有効なプラグインをロード
        /// </summary>
        /// <param name="tabControl">タブを追加するコントロール</param>
        /// <returns>プラグインリスト</returns>
        public static List<Plugin> FindPlugins()
        {
            // プラグインディレクトリパス
            string dir = $@"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}\plugins";

            // プラグインディレクトリが無ければ作成
            if (!Directory.Exists(dir)) Directory.CreateDirectory(dir);

            string[] dlls = Directory.GetFiles(dir, "*.dll");

            var plugins = new List<Plugin>();

            foreach (var dll in dlls)
            {
                try
                {
                    var asm = Assembly.LoadFrom(dll);
                    Console.WriteLine(asm.GetName());

                    foreach (var t in asm.GetTypes())
                    {
                        // 抽象型ではないパブリックなクラスでPluginBaseを継承しているクラス
                        if (t.IsClass && t.IsPublic && !t.IsAbstract && (t.BaseType == typeof(PluginBase)))
                        {
                            plugins.Add(new Plugin(dll, t.FullName));
                        }
                    }
                }
                catch { }
            }

            return plugins.ToList();
        }
    }
}
