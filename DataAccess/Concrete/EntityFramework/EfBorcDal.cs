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
    public class EfBorcDal : EfEntityRepositoryBase<Borc, Context>, IBorcDal
    {
        public List<BorcDetailsDto> GetProductDetailsAll(Expression<Func<Borc, bool>>? filter = null)
        {
            using(var context = new Context())
            {
                var result = from b in context.Borclar
                             join c in context.Cariler
                             on b.CariId equals c.Id
                             select new BorcDetailsDto
                             {
                                 Id = b.Id,
                                 Cari = c.Ismi,
                                 Geciktimi=b.Geciktimi,
                                 KacOdendi=b.KacOdendi,
                                 KacOdenecek = b.KacOdenecek,
                                 TeslimTarih=b.TeslimTarih,
                                 Tutar = b.Tutar,
                                 VerilisTarih = b.VerilisTarih,
                                 Tur=b.Tur
                             };
                return result.ToList();
            }
        }
    }
}
