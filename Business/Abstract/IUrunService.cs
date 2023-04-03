using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUrunService
    {
        IResult Add(Urun urun);
        IResult Update(Urun urun);
        IResult Delete(Urun urun);
        IDataResult<List<Urun>> GetAll();
        IDataResult<Urun> Get(int id);
    }
}
