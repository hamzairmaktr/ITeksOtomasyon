using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfFaturaDetayDal : EfEntityRepositoryBase<FaturaDetay, Context>, IFaturaDetayDal
    {
        public List<FaturaDetayDetailsDto> GetAllDetailsDto(int id)
        {
            using (var context = new Context())
            {
                var result = from ft in context.FaturaDetaylar
                             join fb in context.FaturaBilgiler
                             on ft.FaturaId equals fb.Id
                             join u in context.Urunler
                             on ft.UrunId equals u.Id
                             where ft.FaturaId == id
                             select new FaturaDetayDetailsDto
                             {
                                 Id = ft.Id,
                                 Adet = ft.TopSayisi,
                                 UrunName = u.KumasAd,
                                 Kg = ft.Kg,
                                 FaturaId = fb.Id,
                                 UrunId = u.Id,
                                 Tutar = ft.Tutar,
                                 UrunRenk=u.Renk,
                                 UrunTur=u.KumasTur,
                                 Fiyat = ft.Fiyat,
                             };
                return result.ToList();
            }
        }
    }
}
