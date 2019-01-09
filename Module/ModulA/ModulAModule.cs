using ModulA.Views;
using Prism.Ioc;
using Prism.Modularity;

namespace ModulA
{
    public class ModulAModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
 
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<ViewA>();

        }
    }
}