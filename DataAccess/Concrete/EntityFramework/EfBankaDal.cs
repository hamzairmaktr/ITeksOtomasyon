using Core.DataAccess.EntityFramework;
using Core.Entities;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfBankaDal : EfEntityRepositoryBase<Banka, Context>, IBankaDal
    {
        private readonly Context _context;

        public EfBankaDal(Context context) : base(context)
        {
            this._context = context;
        }
    }
}
