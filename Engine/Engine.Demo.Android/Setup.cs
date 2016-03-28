using Android.Content;
using MvvmCross.Droid.Platform;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform.Platform;
using System.Reflection;
using System.Collections.Generic;
using Engine.Core.ViewModels;

namespace Engine.Demo.Android
{
    public class Setup : MvxAndroidSetup
    {
        public Setup(Context applicationContext) : base(applicationContext)
        {
        }

        protected override IMvxApplication CreateApp()
        {
            return new Core.App();
        }

        protected override IMvxTrace CreateDebugTrace()
        {
            return new DebugTrace();
        }

        protected override IEnumerable<Assembly> GetViewModelAssemblies()
        {
            var assembly = typeof(HubViewModel).GetTypeInfo().Assembly;
            return new[] { assembly };
        }
    }
}
