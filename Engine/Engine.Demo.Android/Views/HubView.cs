using Android.App;
using Android.OS;
using Engine.Core.ViewModels;
using MvvmCross.Droid.Views;

namespace Engine.Demo.Android.Views
{
    [Activity(Label = "View for FirstViewModel", MainLauncher = false)]
    public class HubView : MvxActivity<HubViewModel>
    {
        public new HubViewModel ViewModel
        {
            get
            {
                return base.ViewModel;
            }
            set
            {
                base.ViewModel = value;
            }
        }

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            
        }

        protected override void OnViewModelSet()
        {
            base.OnViewModelSet();
            SetContentView(Resource.Layout.HubView);
        }
    }
}
