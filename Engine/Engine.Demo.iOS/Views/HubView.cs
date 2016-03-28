using Engine.Core.ViewModels;
using MvvmCross.iOS.Views;
using System;

using UIKit;
using MvvmCross.Binding.BindingContext;

namespace Engine.Demo.iOS.Views
{
    public partial class HubView : MvxViewController<HubViewModel>
    {
        public HubView(IntPtr handle) : base(handle)
        {
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();

            // Release any cached data, images, etc that aren't in use.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var set = this.CreateBindingSet<HubView, HubViewModel>();
            set.Bind(Label).To(vm => vm.Hello);
            set.Bind(TextField).To(vm => vm.Hello);
            set.Apply();
        }
    }
}