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
using Microsoft.EntityFrameworkCore;
using Entities.Concrete;
using Microsoft.Extensions.Configuration;
using System.Configuration;
using System.ServiceProcess;

namespace AnaMenu
{
    internal static class Program
    {
        public static ServiceProvider ServiceProvider { get; private set; }
        
        

        static void Shutdown()
        {
            ServiceProvider?.Dispose();
        }

        static void Use()
        {
            
            using (var scope = ServiceProvider.CreateScope())
            {

                var context = scope.ServiceProvider.GetRequiredService<Context>();
                var bankas = scope.ServiceProvider.GetRequiredService<IBankaService>();
                var bankd = scope.ServiceProvider.GetRequiredService<IBankaDal>();
                var borcs = scope.ServiceProvider.GetRequiredService<IBorcService>();
                var borcd = scope.ServiceProvider.GetRequiredService<IBorcDal>();
                var caris = scope.ServiceProvider.GetRequiredService<ICariService>();
                var carid = scope.ServiceProvider.GetRequiredService<ICariDal>();
                var fbs = scope.ServiceProvider.GetRequiredService<IFaturaBilgiService>();
                var fbd = scope.ServiceProvider.GetRequiredService<IFaturaBilgiDal>();
                var fds = scope.ServiceProvider.GetRequiredService<IFaturaDetayService>();
                var fdd = scope.ServiceProvider.GetRequiredService<IFaturaDetayDal>();
                var gs = scope.ServiceProvider.GetRequiredService<IGiderService>();
                var gd = scope.ServiceProvider.GetRequiredService<IGiderDal>();
                var ks = scope.ServiceProvider.GetRequiredService<IKasaService>();
                var kd = scope.ServiceProvider.GetRequiredService<IKasaDal>();
                var kts = scope.ServiceProvider.GetRequiredService<IKasaTurService>();
                var ktd = scope.ServiceProvider.GetRequiredService<IKasaTurDal>();
                var ns = scope.ServiceProvider.GetRequiredService<INotService>();
                var nd = scope.ServiceProvider.GetRequiredService<INotDal>();
                var ps = scope.ServiceProvider.GetRequiredService<IPersonelService>();
                var pd = scope.ServiceProvider.GetRequiredService<IPersonelDal>();
                var us = scope.ServiceProvider.GetRequiredService<IUrunService>();
                var ud = scope.ServiceProvider.GetRequiredService<IUrunDal>();


                var borc = scope.ServiceProvider.GetService<FrmBorclar>();
                var banka = scope.ServiceProvider.GetRequiredService<FrmBankalar>();
                var personel = scope.ServiceProvider.GetRequiredService<FrmPersoneller>();
                var cariler = scope.ServiceProvider.GetRequiredService<FrmCariler>();
            }
        }
       

        public static IServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();


            //services.AddScoped<Context>();
            services.AddDbContext<Context>(opt =>
            {
                opt.UseSqlServer(@"Server=.\SQLEXPRESS;Database=ITeksOtomasyon;Trusted_Connection=true;");
                opt.EnableSensitiveDataLogging();
            });
            services.AddScoped<IBankaService, BankaManager>();
            services.AddScoped<IBankaDal, EfBankaDal>();
            services.AddScoped<IBorcService, BorcManager>();
            services.AddScoped<IBorcDal, EfBorcDal>();
            services.AddScoped<ICariService, CariManager>();
            services.AddScoped<ICariDal, EfCariDal>();
            services.AddScoped<IFaturaBilgiService, FaturaBilgiManager>();
            services.AddScoped<IFaturaBilgiDal, EfFaturaBilgiDal>();
            services.AddScoped<IFaturaDetayService, FaturaDetayManager>();
            services.AddScoped<IFaturaDetayDal, EfFaturaDetayDal>();
            services.AddScoped<IGiderService, GiderManager>();
            services.AddScoped<IGiderDal, EfGiderDal>();
            services.AddScoped<IKasaService, KasaManager>();
            services.AddScoped<IKasaDal, EfKasaDal>();
            services.AddScoped<IKasaTurService, KasaTurManager>();
            services.AddScoped<IKasaTurDal, EfKasaTurDal>();
            services.AddScoped<INotService, NotManager>();
            services.AddScoped<INotDal, EfNotDal>();
            services.AddScoped<IPersonelService, PersonelManager>();
            services.AddScoped<IPersonelDal, EfPersonelDal>();
            services.AddScoped<IUrunService, UrunManager>();
            services.AddScoped<IUrunDal, EfUrunDal>();


            services.AddScoped<Form1>();
            services.AddScoped<FrmBankalar>();
            services.AddScoped<FrmBorclar>();
            services.AddScoped<FrmPersoneller>();
            services.AddScoped<FrmCariler>();
            services.AddScoped<FrmFaturalar>();
            services.AddScoped<FrmFaturaDetay>();
            services.AddScoped<FrmFaturaDetayEkle>();
            services.AddScoped<FrmUrunler>();
            services.AddScoped<FrmUrunAl>();

            ServiceProvider = services.BuildServiceProvider();
            return services.BuildServiceProvider();
        }

        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ConfigureServices();

            //Use();

            var form = ServiceProvider.GetRequiredService<Form1>();
            Application.Run(form);

           
            Shutdown();

        }
    }
}
