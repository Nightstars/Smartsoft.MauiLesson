using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smartsoft.MauiLesson.Models
{
    class MainModel:INotifyPropertyChanged
    {
        //public int Value { get; set; } = 100;

        public event PropertyChangedEventHandler PropertyChanged;

        private int _value = 100;

        public int Value
        {
            get { return _value; }
            set {
                _value = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Value)));
            }
        }
    }
}
