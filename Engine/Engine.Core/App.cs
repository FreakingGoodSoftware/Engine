using Engine.Core.Services;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform.IoC;
using System.Reflection;

namespace Engine.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes(typeof(WebAPIService).GetTypeInfo().Assembly)
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterAppStart<ViewModels.HubViewModel>();
        }
    }
}
