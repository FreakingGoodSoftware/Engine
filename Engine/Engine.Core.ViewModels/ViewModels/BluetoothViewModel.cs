using MvvmCross.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Core.ViewModels.ViewModels
{
    public class BluetoothViewModel : MvxViewModel
    {
        private string _hello = "Hello Bluetooth";
        public string Hello
        {
            get { return _hello; }
            set { SetProperty(ref _hello, value); }
        }
    }
}
