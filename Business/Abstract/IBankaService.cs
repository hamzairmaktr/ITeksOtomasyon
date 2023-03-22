using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IBankaService
    {
        IResult Add(Banka banka);
        IResult Update(Banka banka);
        IResult Delete(Banka banka);
        IDataResult<List<Banka>> GetAll();
    }
}
