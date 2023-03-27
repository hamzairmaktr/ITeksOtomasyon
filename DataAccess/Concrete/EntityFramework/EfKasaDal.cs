using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfKasaDal : EfEntityRepositoryBase<Kasa, Context>, IKasaDal
    {
        public List<KasaDetailsDto> GetAllDetailsDto()
        {
            using (var context = new Context())
            {
                var result = from k in context.Kasalar
                             join kt in context.KasalarTurler
                             on k.KasaTur equals kt.Id
                             join b in context.Bankalar
                             on kt.BankaId equals b.Id
                             select new KasaDetailsDto
                             {
                                 Id = k.Id,
                                 Name = kt.Name,
                                 BankaName = b.BankaAd,
                                 Bakiye = k.Bakiye,
                                 KasaTurId = kt.Id,
                             };
                return result.ToList();
            }
        }
    }
}
