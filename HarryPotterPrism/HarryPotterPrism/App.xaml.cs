using HarryPotterPrism.Core.Regions;
using HarryPotterPrism.Views;
using Prism.Ioc;
using Prism.Regions;
using System.Windows;
using System.Windows.Controls;

namespace HarryPotterPrism
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
        }

        protected override void ConfigureRegionAdapterMappings(RegionAdapterMappings regionAdapterMappings)
        {
            base.ConfigureRegionAdapterMappings(regionAdapterMappings);
            regionAdapterMappings.RegisterMapping(typeof(StackPanel),
                Container.Resolve<StackPanelRegionAdapter>());
        }
    }
}