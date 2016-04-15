using MvvmCross.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Core.ViewModels.ViewModels
{
    public class NavigationViewModel : MvxViewModel
    {
        public List<string> MenuList { get; set; } = new List<string>
        {   "Stack navigation",
            "Master detail",
            "Paging",
            "Tab navigation",
            "Menu navigation",
            "Modals"
        };
    }
}
