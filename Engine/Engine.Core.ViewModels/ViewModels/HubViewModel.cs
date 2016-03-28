using MvvmCross.Core.ViewModels;

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
    }
}
