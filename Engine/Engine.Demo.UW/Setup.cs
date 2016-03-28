using MvvmCross.WindowsUWP.Platform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform.Platform;
using System.Reflection;
using Engine.Core.ViewModels;


namespace Engine.Demo.UW
{
    public class Setup : MvxWindowsSetup
    {
        public Setup(Frame rootFrame) : base(rootFrame)
        {

        }

        protected override IMvxApplication CreateApp()
        {
            return new Engine.Core.App();
        }

        protected override IEnumerable<Assembly> GetViewModelAssemblies()
        {
            var assembly = typeof(HubViewModel).GetTypeInfo().Assembly;
            return new[] { assembly };
        }
    }
}
