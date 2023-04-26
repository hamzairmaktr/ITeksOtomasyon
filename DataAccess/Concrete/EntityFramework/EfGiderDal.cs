using Core.DataAccess.EntityFramework;
using Core.Entities;
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
    public class EfGiderDal : EfEntityRepositoryBase<Gider, Context>, IGiderDal
    {
        public List<GiderDetailsDto> GetDetailsDto(Expression<Func<GiderDetailsDto, bool>>? filter = null)
        {
            using (var context = new Context())
            {
                var result = from g in context.Giderler
                             join p in context.Personeller
                             on g.PersonelId equals p.Id
                             select new GiderDetailsDto
                             {
                                 Id = g.Id,
                                 Date = g.Date,
                                 Not = g.Not,
                                 Personel=p.AdSoyad,
                                 Tur = g.Tur,
                                 Tutar = g.Tutar
                             };
                return filter == null ? result.ToList() : result.Where(filter).ToList();
            }
        }
    }
}
