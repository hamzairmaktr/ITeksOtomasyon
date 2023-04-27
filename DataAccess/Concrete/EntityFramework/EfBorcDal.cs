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
        private Context _context;


        public EfBorcDal(Context context) : base(context)
        {
            this._context = context;
        }

        //public EfBorcDal(Context context)
        //{
        //    
        //}

        public List<BorcOzetDto> GetBorcOzetDtos()
        {

            var result = from b in _context.Borclar
                         join c in _context.Cariler
                         on b.CariId equals c.Id
                         where b.Odendimi == false
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

        public List<BorcOzetDto> GetBorcOzetOdeDtos()
        {

            var result = from b in _context.Borclar
                         join c in _context.Cariler
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

        public List<BorcOzetDto> GetBorcOzetTahsilDtos()
        {

            var result = from b in _context.Borclar
                         join c in _context.Cariler
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

        public BorcOzetDto GetByCariId(int id)
        {

            var result = (from b in _context.Borclar
                          join c in _context.Cariler
                          on b.CariId equals c.Id
                          where b.Odendimi == false
                          && b.CariId == id
                          select new BorcOzetDto
                          {
                              Id = b.Id,
                              Cari = c.Ismi,
                              CariId = c.Id,
                              KacOdenecek = b.KacOdenecek,
                              Tutar = b.Tutar,
                              Tur = "Alacak",
                              KacOdendi = b.KacOdendi,
                              Odendimi = b.Odendimi
                          }).FirstOrDefault();
            return result;

        }

        public List<BorcDetailsDto> GetProductDetailsAll()
        {

            var result = from b in _context.Borclar
                         join c in _context.Cariler
                         on b.CariId equals c.Id
                         where b.Odendimi == false
                         select new BorcDetailsDto
                         {
                             Id = b.Id,
                             Cari = c.Ismi,
                             Geciktimi = b.Geciktimi,
                             KacOdendi = b.KacOdendi,
                             KacOdenecek = b.KacOdenecek,
                             TeslimTarih = b.TeslimTarih,
                             Tutar = b.Tutar,
                             VerilisTarih = b.VerilisTarih,
                             Tur = b.Tur,
                             Odendimi = b.Odendimi,
                         };
            return result.ToList();

        }
    }
}
