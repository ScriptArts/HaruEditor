using HaruEditor.ViewModel.Give;
using System.Windows.Controls;

namespace HaruEditor.View.Give
{
    /// <summary>
    /// GiveControl.xaml の相互作用ロジック
    /// </summary>
    public partial class GiveControl : UserControl
    {
        public GiveControl()
        {
            InitializeComponent();
            this.DataContext = new GiveViewModel();
        }

    }
}
