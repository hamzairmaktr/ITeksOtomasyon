using Core.Utilities.Results;
using Entities.Concrete;
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

        IDataResult<List<Gider>> GetAll7DayBefore();
        IDataResult<List<Gider>> GetAll30DayBefore();
        IDataResult<List<Gider>> GetAll365DayBefore();
        IDataResult<List<Gider>> GetAllMonth(DateTime date);
        IDataResult<List<Gider>> GetAllDay(DateTime date);
        IDataResult<List<Gider>> GetAll();


    }
}
