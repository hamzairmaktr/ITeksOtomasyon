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
        public List<BorcOzetDto> GetBorcOzetDtos()
        {
            using (Context context = new Context())
            {
                var result = from b in context.Borclar
                             join c in context.Cariler
                             on b.CariId equals c.Id
                             where b.Odendimi == false
                             select new BorcOzetDto
                             {
                                 Id = b.Id,
                                 Cari = c.Ismi,
                                 CariId=c.Id,
                                 KacOdenecek = b.KacOdenecek,
                                 Tutar = b.Tutar,
                                 Tur = b.Tur,
                                 KacOdendi=b.KacOdendi,
                                 Odendimi = b.Odendimi
                             };
                return result.ToList();
            }
        }

        public List<BorcOzetDto> GetBorcOzetOdeDtos()
        {
            using (Context context = new Context())
            {
                var result = from b in context.Borclar
                             join c in context.Cariler
                             on b.CariId equals c.Id
                             where b.Odendimi == false
                             where b.Tur == "Verecek"
                             select new BorcOzetDto
                             {
                                 Id = b.Id,
                                 Cari = c.Ismi,
                                 CariId = c.Id,
                                 KacOdenecek = b.KacOdenecek,
                                 Tutar = b.Tutar,
                                 Tur = b.Tur,
                                 KacOdendi = b.KacOdendi,
                                 Odendimi = b.Odendimi
                             };
                return result.ToList();
            }
        }

        public List<BorcOzetDto> GetBorcOzetTahsilDtos()
        {
            using (Context context = new Context())
            {
                var result = from b in context.Borclar
                             join c in context.Cariler
                             on b.CariId equals c.Id
                             where b.Odendimi == false
                             where b.Tur == "Alacak"
                             select new BorcOzetDto
                             {
                                 Id = b.Id,
                                 Cari = c.Ismi,
                                 CariId = c.Id,
                                 KacOdenecek = b.KacOdenecek,
                                 Tutar = b.Tutar,
                                 Tur = b.Tur,
                                 KacOdendi = b.KacOdendi,
                                 Odendimi = b.Odendimi
                             };
                return result.ToList();
            }
        }

        public List<BorcDetailsDto> GetProductDetailsAll()
        {
            using(Context context = new Context())
            {
                var result = from b in context.Borclar
                             join c in context.Cariler
                             on b.CariId equals c.Id
                             where b.Odendimi == false
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
                                 Tur=b.Tur,
                                 Odendimi=b.Odendimi,
                             };
                return result.ToList();
            }
        }
    }
}
