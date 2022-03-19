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

# WPF资源系统

- 许多系统开发中都会设计到资源的内容，了解资源系统，有利于合理使用资源进行开发。
- .NET5下的资源处理和Framework有一些小区别。

1. 资源类型
Resource.resx
对象资源

2. 资源加载
 加载路径
 静态加载与动态加载

3. 样式

