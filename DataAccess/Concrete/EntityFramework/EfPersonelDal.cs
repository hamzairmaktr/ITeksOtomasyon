using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfPersonelDal : EfEntityRepositoryBase<Personel, Context>, IPersonelDal
    {
        private readonly Context _context;
        public EfPersonelDal(Context context) : base(context)
        {
            this._context = context;
        }
    }
}
