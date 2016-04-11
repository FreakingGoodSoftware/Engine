using Engine.Core.Services;
using Engine.Core.ViewModels.ViewModels;
using MvvmCross.Core.ViewModels;
using System.Collections.Generic;

namespace Engine.Core.ViewModels
{
    public class HubViewModel 
        : MvxViewModel
    {
        private string _hello = "Hello MvvmCross";
        public string Hello
        { 
            get { return _hello; }
            set { SetProperty (ref _hello, value); }
        }


        public List<string> MenuList { get; set; } = new List<string>
        {   "Web access",
            "Navigation",
            "Forms input",
            "List presentation",
            "Services and plugins",
            "Platform APIs"
        };

        public IWebAPIService WebAPIService { get; set; }


        public HubViewModel(
            IWebAPIService webAPIService)
        {
            WebAPIService = webAPIService;
        }

        public void UIStart()
        {
            
        }

        public IMvxCommand NavigateCommand
        {
            get
            {
                return new MvxCommand<string>((arg) =>
                {
                    switch (MenuList.IndexOf(arg))
                    {
                        case 5:
                            ShowViewModel<PlatformApisViewModel>();

                            break;
                        default:
                            break;
                    }
                });
            }
        }

    }
}
