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
    public interface IKasaService
    {
        IResult Add(Kasa kasa);
        IResult Update(Kasa kasa);
        IResult UpdateMoney(decimal tutar, int id);
        IResult Delete(Kasa kasa);
        IDataResult<List<KasaDetailsDto>> GetDetailsDto();
        IDataResult<Kasa> GetById(int id);
    }
}
