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
        private readonly Context _context;

        public EfGiderDal(Context context) : base(context)
        {
            this._context = context;
        }

        public List<GiderDetailsDto> GetDetailsDto(Expression<Func<GiderDetailsDto, bool>>? filter = null)
        {

            var result = from g in _context.Giderler
                         join p in _context.Personeller
                         on g.PersonelId equals p.Id
                         select new GiderDetailsDto
                         {
                             Id = g.Id,
                             Date = g.Date,
                             Not = g.Not,
                             Personel = p.AdSoyad,
                             Tur = g.Tur,
                             Tutar = g.Tutar
                         };
            return filter == null ? result.ToList() : result.Where(filter).ToList();

        }
    }
}
