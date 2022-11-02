using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace HarryPotter.MainApplication
{
    public static class MVVMBehaviors
    {


        public static int GetLoadedMethodName(DependencyObject obj)
        {
            return (int)obj.GetValue(LoadedMethodNameProperty);
        }

        public static void SetLoadedMethodName(DependencyObject obj, int value)
        {
            obj.SetValue(LoadedMethodNameProperty, value);
        }

        // Using a DependencyProperty as the backing store for LoadedMethodName.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty LoadedMethodNameProperty =
            DependencyProperty.RegisterAttached("LoadedMethodName", typeof(string), typeof(MVVMBehaviors),
                new PropertyMetadata(null, OnLoadMethodNameChanged));

        static void OnLoadMethodNameChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            FrameworkElement element = d as FrameworkElement;
            if(element != null)
            {
                element.Loaded += (s, e2) =>
                {
                    var viewModel = element.DataContext;
                    if (viewModel == null) return;
                    var methodInfo = viewModel.GetType().GetMethod(e.NewValue.ToString());
                    if(methodInfo != null)
                    {
                        methodInfo.Invoke(viewModel, null);
                    }
                };
            }
        }
    }
}
