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
    public interface IKasaTurService
    {
        IResult Add(KasaTur kasaTur);
        IResult Update(KasaTur kasaTur);
        IResult Delete(KasaTur kasaTur);
        IDataResult<List<KasaTurDetails>> GetAllKasaTurDetails();
        IDataResult<List<KasaTur>> GetAll();
    }
}
