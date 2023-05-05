using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using UIWinForm;
using Microsoft.Extensions.DependencyInjection;
using Business.Abstract;
using Business.Concrete;
using Core.DataAccess.EntityFramework.Context;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Abstract;
using Microsoft.EntityFrameworkCore;
using Entities.Concrete;
using System.ServiceProcess;
using System.Configuration;

namespace AnaMenu
{
    internal static class Program
    {
        public static ServiceProvider ServiceProvider { get; private set; }



        static void Shutdown()
        {
            ServiceProvider?.Dispose();
        }

        public static IServiceProvider ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<Context>();
            //services.AddScoped<>
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
            services.AddScoped<FrmSatis2>();
            services.AddScoped<FrmCariSec>();
            services.AddScoped<FrmBorcOde>();
            services.AddScoped<FrmBorcTahsil>();
            services.AddScoped<FrmBorcArti>();

            ServiceProvider = services.BuildServiceProvider();
            return services.BuildServiceProvider();
        }

        /*public static void ConfigHost()
        {
            var host = Host.CreateDefaultBuilder()
                .ConfigureServices((hostContext, services) =>
                {
                    //services.AddDbContext<Context>(options =>
                    //options.UseSqlServer(@"Server=.\SQLEXPRESS;Database=ITeksOtomasyon;Trusted_Connection=true;"));
                    services.AddDbContext<Context>(options =>
                        options.UseSqlServer(@"Server=.\SQLEXPRESS;Database=ITeksOtomasyon;Trusted_Connection=true;"));
                    services.AddScoped<Context>();
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
                })
                .Build();
        }*/
        [STAThread]
        static void Main()
        {

            //ConfigHost();

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);


            //Use();

            var form = ServiceProvider.GetRequiredService<Form1>();
            Application.Run(form);


            Shutdown();

        }
    }
}
