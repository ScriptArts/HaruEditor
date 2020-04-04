using HaruEditor.Model.Common.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaruEditor.ViewModel.Summon
{
    class SummonViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public List<int> Entities { get; } = new List<int>();

        public SummonViewModel()
        {
            Creeper creeper = new Creeper();
        }
    }
}
