# WPFStudyNotes

## 事件驱动与数据驱动

1. 两种开发模式的理解与对比
 事件驱动：通过事件驱动业务。
 实现 INotifyPropertyChanged接口 
 ```csharp
         public event PropertyChangedEventHandler PropertyChanged;
        private string _value="数据驱动";

        public string Value
        {
            get { return _value; }
            set
            {
                _value = value;
                //该事件在更改组件上的属性时引发
                PropertyChanged?.Invoke(this,new PropertyChangedEventArgs("Value"));
                if (value=="100")
                {
                    ValueColor = Brushes.Red;
                }
            }
        }
```

2. 两种模式如何选择？ 各有什么优势？

## MVVM模式的基本操作

1. 什么时候MVVM模式

Model：数据模型、View（界面）、ViewModel（业务逻辑处理）

2.