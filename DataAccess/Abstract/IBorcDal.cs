using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IBorcDal:IEntityRepository<Borc>
    {
        List<BorcDetailsDto> GetProductDetailsAll(Expression<Func<Borc, bool>>? filter = null);
        List<BorcOzetDto> GetBorcOzetDtos(Expression<Func<Borc, bool>>? filter = null);
    }
}
