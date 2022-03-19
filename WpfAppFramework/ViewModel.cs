using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Media;

namespace WpfAppFramework
{
    class ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public List<string> valueList { get; set; }= new List<string> { "温度", "湿度", "Co2", "噪声" };


        private string _value = "数据驱动";

        public string Value
        {
            get { return _value; }
            set
            {
                _value = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Value"));
                if (value == "100")
                {
                    ValueColor = Brushes.Red;
                }
                //在设置value的值的时候的调用该方法。
                (this.valueCommand as CommandBase).RaiseCanChanged();
            }
        }
        private Brush _valueColor = Brushes.Gold;

        public Brush ValueColor
        {
            get { return _valueColor; }
            set
            {
                _valueColor = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ValueColor"));
            }
        }
        private ICommand valueCommand;

        public ICommand ValueCommand
        {
            get
            {
                if (valueCommand == null)
                {
                    valueCommand = new CommandBase()
                    {
                        DoAction = new Action<object>(ValueCommandAction),
                        DoCanExecute = new Func<object, bool>(Canexcute)
                    };
                }
                return valueCommand;
            }
            set { valueCommand = value; }
        }
        private void ValueCommandAction(Object obj)
        {
            Value = "100";
        }
        private bool Canexcute(object obj)
        {
            return !string.IsNullOrEmpty(Value);
        }
    }
}
