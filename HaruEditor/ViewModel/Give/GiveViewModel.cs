using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaruEditor.ViewModel.Give
{
    class GiveViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public List<int> UnsignedFloatList { get; }

        public GiveViewModel()
        {
            UnsignedFloatList = new List<int>(Enumerable.Range(0, 128));
        }
    }
}
