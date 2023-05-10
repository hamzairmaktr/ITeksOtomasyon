using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Abstract;
using AnaMenu;

namespace UIWinForm
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
            services.AddSingleton<Context>();
            
            services.AddSingleton<IBankaService, BankaManager>();
            services.AddSingleton<IBankaDal, EfBankaDal>();
            services.AddSingleton<IBorcService, BorcManager>();
            services.AddSingleton<IBorcDal, EfBorcDal>();
            services.AddSingleton<ICariService, CariManager>();
            services.AddSingleton<ICariDal, EfCariDal>();
            services.AddSingleton<IFaturaBilgiService, FaturaBilgiManager>();
            services.AddSingleton<IFaturaBilgiDal, EfFaturaBilgiDal>();
            services.AddSingleton<IFaturaDetayService, FaturaDetayManager>();
            services.AddSingleton<IFaturaDetayDal, EfFaturaDetayDal>();
            services.AddSingleton<IGiderService, GiderManager>();
            services.AddSingleton<IGiderDal, EfGiderDal>();
            services.AddSingleton<IKasaService, KasaManager>();
            services.AddSingleton<IKasaDal, EfKasaDal>();
            services.AddSingleton<IKasaTurService, KasaTurManager>();
            services.AddSingleton<IKasaTurDal, EfKasaTurDal>();
            services.AddSingleton<INotService, NotManager>();
            services.AddSingleton<INotDal, EfNotDal>();
            services.AddSingleton<IPersonelService, PersonelManager>();
            services.AddSingleton<IPersonelDal, EfPersonelDal>();
            services.AddSingleton<IUrunService, UrunManager>();
            services.AddSingleton<IUrunDal, EfUrunDal>();


            services.AddSingleton<Form1>();
            services.AddSingleton<FrmBankalar>();
            services.AddSingleton<FrmBorclar>();
            services.AddSingleton<FrmPersoneller>();
            services.AddSingleton<FrmCariler>();
            services.AddSingleton<FrmFaturalar>();
            services.AddSingleton<FrmFaturaDetay>();
            services.AddSingleton<FrmFaturaDetayEkle>();
            services.AddSingleton<FrmUrunler>();
            services.AddSingleton<FrmUrunAl>();
            services.AddSingleton<FrmSatis2>();
            services.AddSingleton<FrmCariSec>();
            services.AddSingleton<FrmBorcOde>();
            services.AddSingleton<FrmBorcTahsil>();
            services.AddSingleton<FrmBorcArti>();
            services.AddSingleton<FrmKasa>();
            services.AddSingleton<FrmKasaTur>();
            services.AddSingleton<FrmGider>();
            services.AddSingleton<FrmNotlar>();

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
                    services.AddSingleton<Context>();
                    services.AddSingleton<IBankaService, BankaManager>();
                    services.AddSingleton<IBankaDal, EfBankaDal>();
                    services.AddSingleton<IBorcService, BorcManager>();
                    services.AddSingleton<IBorcDal, EfBorcDal>();
                    services.AddSingleton<ICariService, CariManager>();
                    services.AddSingleton<ICariDal, EfCariDal>();
                    services.AddSingleton<IFaturaBilgiService, FaturaBilgiManager>();
                    services.AddSingleton<IFaturaBilgiDal, EfFaturaBilgiDal>();
                    services.AddSingleton<IFaturaDetayService, FaturaDetayManager>();
                    services.AddSingleton<IFaturaDetayDal, EfFaturaDetayDal>();
                    services.AddSingleton<IGiderService, GiderManager>();
                    services.AddSingleton<IGiderDal, EfGiderDal>();
                    services.AddSingleton<IKasaService, KasaManager>();
                    services.AddSingleton<IKasaDal, EfKasaDal>();
                    services.AddSingleton<IKasaTurService, KasaTurManager>();
                    services.AddSingleton<IKasaTurDal, EfKasaTurDal>();
                    services.AddSingleton<INotService, NotManager>();
                    services.AddSingleton<INotDal, EfNotDal>();
                    services.AddSingleton<IPersonelService, PersonelManager>();
                    services.AddSingleton<IPersonelDal, EfPersonelDal>();
                    services.AddSingleton<IUrunService, UrunManager>();
                    services.AddSingleton<IUrunDal, EfUrunDal>();


                    services.AddSingleton<Form1>();
                    services.AddSingleton<FrmBankalar>();
                    services.AddSingleton<FrmBorclar>();
                    services.AddSingleton<FrmPersoneller>();
                    services.AddSingleton<FrmCariler>();
                    services.AddSingleton<FrmFaturalar>();
                    services.AddSingleton<FrmFaturaDetay>();
                    services.AddSingleton<FrmFaturaDetayEkle>();
                    services.AddSingleton<FrmUrunler>();
                    services.AddSingleton<FrmUrunAl>();
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
