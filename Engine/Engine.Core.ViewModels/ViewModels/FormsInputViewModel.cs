using MvvmCross.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Core.ViewModels.ViewModels
{
    public class FormsInputViewModel : MvxViewModel
    {
        public List<string> MenuList { get; set; } = new List<string>
        {   "Numeric input",
            "Text input",
            "Data range input",
            "Date and time input",
            "Multi-selectors",
            "Ink"
        };
    }
}
