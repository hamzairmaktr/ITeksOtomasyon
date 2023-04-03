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
    public class EfFaturaBilgiDal : EfEntityRepositoryBase<FaturaBilgi, Context>, IFaturaBilgiDal
    {
        public List<FaturaBilgiDetailsDto> GetAllDetailsDto()
        {
            using (var context = new Context())
            {
                var result = from fb in context.FaturaBilgiler
                             join c in context.Cariler
                             on fb.CariId equals c.Id
                             join p in context.Personeller
                             on fb.PersonelId equals p.Id
                             select new FaturaBilgiDetailsDto
                             {
                                 Id = fb.Id,
                                 CariName = c.Ismi,
                                 PersonelName = p.AdSoyad,
                                 SiraNo = fb.SiraNo,
                                 Tarih = fb.Date,
                                 TeslimAlan = fb.TeslimAlan,
                                 Tutar= fb.Tutar,
                             };
                return result.ToList();
            }
        }
    }
}
