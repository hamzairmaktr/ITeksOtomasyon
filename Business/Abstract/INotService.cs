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
    public interface INotService
    {
        IResult Add(Not not);
        IResult Delete(Not not);
        IResult Update(Not not);
        IDataResult<List<NotDetailsDto>> GetAll();
        IDataResult<Not> Get(int id);
    }
}
