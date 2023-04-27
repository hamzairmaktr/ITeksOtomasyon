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
    public class EfKasaTurDal : EfEntityRepositoryBase<KasaTur, Context>, IKasaTurDal
    {
        private readonly Context _context;

        public EfKasaTurDal(Context context) : base(context)
        {
            this._context = context;
        }

        public List<KasaTurDetails> GetAllKasaTurDetails()
        {

            var result = from kt in _context.KasalarTurler
                         join b in _context.Bankalar
                         on kt.BankaId equals b.Id
                         select new KasaTurDetails
                         {
                             Id = kt.Id,
                             Name = kt.Name,
                             BankaId = kt.BankaId,
                             BankaName = b.BankaAd
                         };
            return result.ToList();

        }
    }
}
