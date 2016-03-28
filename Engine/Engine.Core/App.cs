using MvvmCross.Core.ViewModels;
using MvvmCross.Platform.IoC;

namespace Engine.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterAppStart<ViewModels.HubViewModel>();
        }
    }
}
