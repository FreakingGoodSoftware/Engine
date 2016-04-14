using MvvmCross.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Core.ViewModels.ViewModels
{
    public class ListPresentationViewModel : MvxViewModel
    {
        public List<string> MenuList { get; set; } = new List<string>
        {   "List view static",
            "Items and reuse",
            "Grid layout",
            "Selection",
            "Pull to refresh",
            "Carousel and scrolling"
        };
    }
}
