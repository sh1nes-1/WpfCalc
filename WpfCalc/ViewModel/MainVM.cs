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
        public DelegateCommand<object> DigitPressEventCommand { get; private set; }

        public MainVM()
        {
            KeyDownEventCommand = new DelegateCommand<KeyEventArgs>(KeyDownEventHandler);
            DigitPressEventCommand = new DelegateCommand<object>(DigitPressEventHandler);
        }

        public void KeyDownEventHandler(KeyEventArgs args)
        {
            
        }        

        public void DigitPressEventHandler(object digit)
        {
            DisplayText += digit;
        }

        private string _displayText;
        public string DisplayText
        {
            get => _displayText;
            set => SetProperty(ref _displayText, value);
        }
    }
}
