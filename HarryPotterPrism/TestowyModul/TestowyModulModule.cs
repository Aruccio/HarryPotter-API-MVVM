using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using TestowyModul.Views;

namespace TestowyModul
{
    public class TestowyModulModule : IModule
    {
        private readonly IRegionManager _regionManager;

        public TestowyModulModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public void OnInitialized(IContainerProvider containerProvider)
        {
            // _regionManager.RegisterViewWithRegion("ContentRegion", typeof(TestowyWidok));
            IRegion region = _regionManager.Regions["ContentRegion"];

            var view1 = containerProvider.Resolve<TestowyWidok>();
            region.Add(view1);

            var view2 = containerProvider.Resolve<TestowyWidok>();
            view2.Content = new Border()
            {
                Name = "borderView2",
                BorderThickness = new Thickness(3),
                BorderBrush = new SolidColorBrush(Colors.DarkBlue),
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Center
            };
            //var borderView2 = containerProvider.Resolve<Border>("borderView2");

            //borderView2.Children.Add(
            //    new TextBox()
            //    {
            //        Text = "Hello world from View2"
            //    }
            //);

            view2.Content = new TextBox()
            {
                Text = "Hello world from View2",
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Center
            };

            region.Add(view2);
            region.Activate(view2);

            region.Activate(view1);
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
        }
    }
}