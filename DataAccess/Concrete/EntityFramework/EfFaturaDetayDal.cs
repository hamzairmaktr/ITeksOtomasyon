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
        private readonly Context _context;
        public EfFaturaDetayDal(Context context) : base(context)
        {
            this._context = context;
        }

        public List<FaturaDetayDetailsDto> GetAllDetailsDto(int id)
        {

            var result = from ft in _context.FaturaDetaylar
                         join fb in _context.FaturaBilgiler
                         on ft.FaturaId equals fb.Id
                         join u in _context.Urunler
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
                             UrunRenk = u.Renk,
                             UrunTur = u.KumasTur,
                             Fiyat = ft.Fiyat,
                             Kdv = ft.Kdv,
                             KdvFiyat = ft.KdvFiyat,
                             KdvOran = ft.KdvOran,
                             KdvTutar = ft.KdvTutar
                         };
            return result.ToList();

        }
    }
}
