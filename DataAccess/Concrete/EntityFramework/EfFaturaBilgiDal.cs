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
        private readonly Context _context;
        public EfFaturaBilgiDal(Context context) : base(context)
        {
            this._context = context;
        }

        public List<FaturaBilgiDetailsDto> GetAllDetailsDto()
        {

            var result = from fb in _context.FaturaBilgiler
                         join c in _context.Cariler
                         on fb.CariId equals c.Id
                         join p in _context.Personeller
                         on fb.PersonelId equals p.Id
                         select new FaturaBilgiDetailsDto
                         {
                             Id = fb.Id,
                             CariName = c.Ismi,
                             PersonelName = p.AdSoyad,
                             Tarih = fb.Date,
                             TeslimAlan = fb.TeslimAlan,
                             KacOdendi = fb.KacOdendi,
                             KacOdenecek = fb.KacOdenecek,
                             Tutar = fb.Tutar,
                             FaturaTuru = fb.FaturaTuru,
                             SeriNo= fb.SeriNo,
                             FaturaKesildimi = fb.FaturaKesildimi,
                             Odendimi = fb.Odendimi
                         };
            return result.ToList();

        }
    }
}
