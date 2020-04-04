using HaruEditor.Model.Common.Entities;
using OrangeNBT.NBT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HaruEditor.View.Summon
{
    /// <summary>
    /// SummonControl.xaml の相互作用ロジック
    /// </summary>
    public partial class SummonControl : UserControl
    {
        private ViewModel.Summon.SummonViewModel viewModel = new ViewModel.Summon.SummonViewModel();

        public SummonControl()
        {
            InitializeComponent();
            this.DataContext = viewModel;

            Creeper creeper = new Creeper();
            creeper.Id = new TagString("id", "creeper");
            viewModel.Entities.Add(creeper);
            viewModel.Entities.Add(creeper);
            viewModel.Entities.Add(creeper);
            viewModel.Entities.Add(creeper);
            viewModel.Entities.Add(creeper);
            viewModel.Entities.Add(creeper);
            viewModel.Entities.Add(creeper);
            viewModel.Entities.Add(creeper);
        }
    }
}
