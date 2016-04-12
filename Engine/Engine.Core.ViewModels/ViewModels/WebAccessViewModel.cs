using MvvmCross.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Core.ViewModels.ViewModels
{
    public class WebAccessViewModel : MvxViewModel
    {
        public List<string> MenuList { get; set; } = new List<string>
        {   "Lifecycle",
            "HTTP Verbs",
            "Paging"
        };
    }
}
