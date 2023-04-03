using Core.DataAccess;
using Core.Entities;
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
    public interface IFaturaDetayDal:IEntityRepository<FaturaDetay>
    {
        List<FaturaDetayDetailsDto> GetAllDetailsDto(int id);
    }
}
