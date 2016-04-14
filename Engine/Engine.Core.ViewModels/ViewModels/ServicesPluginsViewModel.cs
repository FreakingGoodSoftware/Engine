using MvvmCross.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Core.ViewModels.ViewModels
{
    public class ServicesPluginsViewModel : MvxViewModel
    {
        public List<string> MenuList { get; set; } = new List<string>
        {   "Json localization",
            "Standard dialogs",
            "Connectivity",
            "Pictures",
            "Location",
            "Platform APIs"
        };
    }
}
