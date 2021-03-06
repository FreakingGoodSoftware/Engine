using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Engine.Core.ViewModels.ViewModels;
using MvvmCross.Droid.Views;

namespace Engine.Demo.Android.Views
{
    [Activity(Label = "BluetoothView")]
    public class BluetoothView : MvxActivity<BluetoothViewModel>
    {
        public new BluetoothViewModel ViewModel
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

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
        }

        protected override void OnViewModelSet()
        {
            base.OnViewModelSet();
            SetContentView(Resource.Layout.BluetoothView);
        }
    }
}