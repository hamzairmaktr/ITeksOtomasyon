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
    public interface IFaturaDetayService
    {
        IResult Add(FaturaDetay faturaDetay);
        IResult Update(FaturaDetay faturaDetay);
        IResult Delete(FaturaDetay faturaDetay);
        IDataResult<List<FaturaDetayDetailsDto>> GetAllDetailsDto(int id);
       
    }
}
