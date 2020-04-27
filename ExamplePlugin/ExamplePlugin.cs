using HaruEditorLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamplePlugin
{
    public class ExamplePlugin : PluginBase
    {
        public override string PluginName => "Example Plugin";

        public override string PluginDescription => "サンプルプラグイン";

        public override bool Visible => true;

        public override bool AutoRun => false;

        public override void Run()
        {
            AddTab("Example", new ExampleControl());
        }
    }
}
