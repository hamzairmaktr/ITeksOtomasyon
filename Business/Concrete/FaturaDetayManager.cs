using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class FaturaDetayManager : IFaturaDetayService
    {
        private readonly IFaturaDetayDal _faturaDetayDal;

        public FaturaDetayManager(IFaturaDetayDal faturaDetayDal)
        {
            _faturaDetayDal = faturaDetayDal;
        }

        public IResult Add(FaturaDetay faturaDetay)
        {
            _faturaDetayDal.Add(faturaDetay);
            return new SuccessResult("Fatura detayı başarı ile eklendi");
        }

        public IResult Delete(FaturaDetay faturaDetay)
        {
            _faturaDetayDal.Delete(faturaDetay);
            return new SuccessResult("Fatura detayı başarı ile silindi");
        }

        public IDataResult<List<FaturaDetayDetailsDto>> GetAllDetailsDto(int id)
        {
            return new SucessDataResult<List<FaturaDetayDetailsDto>>(_faturaDetayDal.GetAllDetailsDto(id));
        }

        

        public IResult Update(FaturaDetay faturaDetay)
        {
            
            _faturaDetayDal.Update(faturaDetay);
            return new SuccessResult("Fatura detayı başarı ile güncellendi");
        }
    }
}
