using Core.DataAccess.EntityFramework;
using Core.Entities;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
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
        public List<BorcOzetDto> GetBorcOzetDtos(Expression<Func<Borc, bool>>? filter = null)
        {
            using (var context = new Context())
            {
                var result = from b in context.Borclar
                             join c in context.Cariler
                             on b.CariId equals c.Id
                             select new BorcOzetDto
                             {
                                 Id = b.Id,
                                 Cari = c.Ismi,
                                 CariId=c.Id,
                                 KacOdenecek = b.KacOdenecek,
                                 Tutar = b.Tutar,
                                 Tur = b.Tur
                             };
                return result.ToList();
            }
        }

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
