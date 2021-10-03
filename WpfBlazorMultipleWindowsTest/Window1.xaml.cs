using System;
using System.Windows;
using Microsoft.Extensions.DependencyInjection;
using WpfBlazorMultipleWindowsTest.Blazor;

namespace WpfBlazorMultipleWindowsTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public IServiceProvider ServiceProvider { get; }

        public Window1()
        {
            var services = new ServiceCollection();
            services.AddBlazorWebView();
            services.AddSingleton<IWindowManager, WindowManager>();
            ServiceProvider = services.BuildServiceProvider();
            InitializeComponent();
        }
    }
}
