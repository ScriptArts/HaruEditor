using HaruEditor.Model.Common.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaruEditor.ViewModel.Summon
{
    public class SummonViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public List<Entity> Entities { get; } = new List<Entity>();

        public SummonViewModel()
        {

        }
    }
}
