using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfAppFramework
{
    public class CommandBase : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            //绑定了命令的按钮是否可用
            return DoCanExecute?.Invoke(parameter)==true;
        }

        public void Execute(object parameter) 
        {
            //控制逻辑
            DoAction?.Invoke(parameter);
        }
        public Action<object> DoAction { get; set; }
        public Func<object, bool> DoCanExecute { get; set; }
        public void RaiseCanChanged() 
        {
            CanExecuteChanged?.Invoke(this,new EventArgs());
        }
    }
}
