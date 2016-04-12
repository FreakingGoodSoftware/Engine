using Engine.Core.ViewModels;
using Engine.Demo.UW.Common;
using MvvmCross.WindowsUWP.Views;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Engine.Demo.UW.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class HubView : BaseWindowsPage
    {
        public new HubViewModel ViewModel
        {
            get { return (HubViewModel)base.ViewModel; }
            set { base.ViewModel = value; }
        }

        public HubView()
        {
            this.InitializeComponent();
        }
    }
}
