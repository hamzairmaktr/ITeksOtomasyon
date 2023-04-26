using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using UIWinForm;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Business.Abstract;
using Business.Concrete;
using Core.DataAccess.EntityFramework.Context;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Abstract;

namespace AnaMenu
{
    internal static class Program
    {
        public static ServiceProvider ServiceProvider { get; private set; }
        
        static void Config() 
        {
            ServiceProvider = new ServiceCollection()
                .AddTransient<IBankaService , BankaManager>()
                .AddTransient<IBorcService, BorcManager>()
                .AddTransient<IContext, Context>()
                .BuildServiceProvider();
        }

        static void Shutdown()
        {
            ServiceProvider?.Dispose();
        }

        static void Use()
        {
            var repos = ServiceProvider.GetService<IBankaService>();
            var context = ServiceProvider.GetRequiredService<IContext>();

            
            //foreach (var r in repos.GetAll().Data)
            //    Console.WriteLine($"{r.BankaAd}");
        }

        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var services = new ServiceCollection();
            services.AddScoped<IContext, Context>();
            services.AddScoped<IBankaService, BankaManager>();
            services.AddScoped<IBankaDal, EfBankaDal>();


            services.AddScoped<Form1>();

            var serviceProvider = services.BuildServiceProvider();

            var form = serviceProvider.GetRequiredService<Form1>();
            Application.Run(form);
        }
    }
}
