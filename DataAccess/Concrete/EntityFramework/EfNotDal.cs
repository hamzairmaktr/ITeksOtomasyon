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
    public class EfNotDal : EfEntityRepositoryBase<Not, Context>, INotDal
    {
        private readonly Context _context;

        public EfNotDal(Context context) : base(context)
        {
            this._context = context;
        }

        public List<NotDetailsDto> GetAllDetailsDto()
        {
            
                var result = from n in _context.Notlar
                             join p in _context.Personeller
                             on n.PersonelID equals p.Id
                             orderby n.Yapildimi
                             select new NotDetailsDto
                             {
                                 Id = n.Id,
                                 Baslik = n.Baslik,
                                 Date = n.Date,
                                 Detay = n.Detay,
                                 PersonelName = p.AdSoyad,
                                 Time = n.Time,
                                 Yapildimi = n.Yapildimi
                             };
                return result.ToList();
           
        }
    }
}
