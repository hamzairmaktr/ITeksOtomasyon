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
    public class EfCariDal : EfEntityRepositoryBase<Cari, Context>, ICariDal
    {
        private readonly Context _context;
        public EfCariDal(Context context) : base(context)
        {
            this._context = context;
        }

        public List<CariOzetDtos> GetCariOzetDtos()
        {

            var result = from c in _context.Cariler
                         select new CariOzetDtos
                         {
                             Id = c.Id,
                             CariTur = c.CariTur,
                             Name = c.Ismi,
                             YetkiliAdSoyad = c.YetkiliAdSoyad
                         };
            return result.ToList();

        }
    }
}
