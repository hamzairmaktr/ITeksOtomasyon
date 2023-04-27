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
    public class EfUrunDal : EfEntityRepositoryBase<Urun, Context>, IUrunDal
    {
        private readonly Context _context;
        public EfUrunDal(Context context) : base(context)
        {
            this._context = context;
        }
    }
}
