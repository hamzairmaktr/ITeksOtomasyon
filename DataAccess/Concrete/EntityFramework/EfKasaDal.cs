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
        private readonly Context _context;

        public EfKasaDal(Context context) : base(context)
        {
            this._context = context;
        }

        public List<KasaDetailsDto> GetAllDetailsDto()
        {

            var result = from k in _context.Kasalar
                         join kt in _context.KasalarTurler
                         on k.KasaTur equals kt.Id
                         join b in _context.Bankalar
                         on kt.BankaId equals b.Id
                         select new KasaDetailsDto()
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
