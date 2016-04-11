using MvvmCross.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Core.ViewModels.ViewModels
{
    public class PlatformApisViewModel : MvxViewModel
    {


        public List<string> MenuList { get; set; } = new List<string>
        {   "Bluetooth",
            "Maps",
            "Phone services",
            "Phone sensors",
            "Camera",
            "Audio"
        };

        public IMvxCommand NavigateCommand
        {
            get
            {
                return new MvxCommand<string>((arg) =>
                {
                    switch (MenuList.IndexOf(arg))
                    {
                        case 0:
                            ShowViewModel<BluetoothViewModel>();

                            break;
                        default:
                            break;
                    }
                });
            }
        }
    }
}
