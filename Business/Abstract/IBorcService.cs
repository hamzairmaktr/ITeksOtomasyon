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
    public interface IBorcService
    {
        IResult Add(Borc borc);
        IResult Delete(Borc borc);
        IResult Update(Borc borc);
        IDataResult<List<BorcDetailsDto>> GetBorcDetailAll();
        IDataResult<List<BorcOzetDto>> GetBorcOzetDTOs();
    }
}
