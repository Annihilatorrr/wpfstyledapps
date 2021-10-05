using MathStat.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows;
using MathStat.App.ViewModels;

namespace MathStat.App
{

    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public IServiceProvider Services { get; }

        public App()
        {
            Services = ConfigureServices();
        }

        public new static App Current => (App)Application.Current;

        private static IServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();

            // Services
            services.AddSingleton<IDistributionService, DistributionService>();

            // Viewmodels
            services.AddTransient<MainViewModel>();
            return services.BuildServiceProvider();
        }
    }
}
