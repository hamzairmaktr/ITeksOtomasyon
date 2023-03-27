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
        IResult Delete(Kasa kasa);
        IDataResult<List<KasaDetailsDto>> GetDetailsDto(Kasa kasa);
    }
}
