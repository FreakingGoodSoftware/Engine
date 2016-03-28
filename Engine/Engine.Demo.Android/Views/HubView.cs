using Android.App;
using Android.OS;
using Engine.Core.ViewModels;
using MvvmCross.Droid.Views;

namespace Engine.Demo.Android.Views
{
    [Activity(Label = "View for FirstViewModel")]
    public class HubView : MvxActivity<HubViewModel>
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.HubView);
        }
    }
}
