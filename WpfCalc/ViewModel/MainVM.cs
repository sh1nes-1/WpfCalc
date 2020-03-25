using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfCalc.ViewModel
{
    class MainVM : BindableBase
    {
        public DelegateCommand<KeyEventArgs> KeyDownEventCommand { get; private set; }

        public MainVM()
        {
            KeyDownEventCommand = new DelegateCommand<KeyEventArgs>(KeyDownEventHandler);
        }

        public void KeyDownEventHandler(KeyEventArgs args)
        {
            
        }        
    }
}
