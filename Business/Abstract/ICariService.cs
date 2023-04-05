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
    public interface ICariService
    {
        IResult Add(Cari cari);
        IResult Update(Cari cari);
        IResult Delete(Cari cari);
        IDataResult<List<Cari>> GetAll();
        IDataResult<List<CariOzetDtos>> GetCariOzetDtos();
        IDataResult<Cari> GetById(int id);
    }
}
