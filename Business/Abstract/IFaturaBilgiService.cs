using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IFaturaBilgiService
    {
        IResult Add(FaturaBilgi faturaBilgi);
        IResult Update(FaturaBilgi faturaBilgi);
        IResult Delete(FaturaBilgi faturaBilgi);
        IDataResult<List<FaturaBilgiDetailsDto>> GetAllDetailsDto();
        IDataResult<FaturaBilgi> Get(int id);
    }
}
