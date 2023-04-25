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
    public interface IGiderService
    {
        IResult Add(Gider gider);
        IResult Update(Gider gider);
        IResult Delete(Gider gider);

        IDataResult<List<GiderDetailsDto>> GetAll7DayBefore();
        IDataResult<List<GiderDetailsDto>> GetAll30DayBefore();
        IDataResult<List<GiderDetailsDto>> GetAll365DayBefore();
        IDataResult<List<GiderDetailsDto>> GetAllMonth(DateTime date);
        IDataResult<List<GiderDetailsDto>> GetAllDay(DateTime date);
        IDataResult<List<GiderDetailsDto>> GetAll();


    }
}
