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
        public List<KasaTurDetails> GetAllKasaTurDetails()
        {
            using (var context = new Context())
            {
                var result = from kt in context.KasalarTurler
                             join b in context.Bankalar
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
}
