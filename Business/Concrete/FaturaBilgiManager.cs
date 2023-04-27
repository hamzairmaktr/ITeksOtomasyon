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
    public class FaturaBilgiManager : IFaturaBilgiService
    {
        private readonly IFaturaBilgiDal _faturaBilgiDal;

        public FaturaBilgiManager(IFaturaBilgiDal faturaBilgiDal)
        {
            _faturaBilgiDal = faturaBilgiDal;
        }

        public IResult Add(FaturaBilgi faturaBilgi)
        {
            _faturaBilgiDal.Add(faturaBilgi);
            return new SuccessResult("Fatura bilgisi başarı ile eklendi");
        }

        public IResult Delete(FaturaBilgi faturaBilgi)
        {
            _faturaBilgiDal.Delete(faturaBilgi);
            return new SuccessResult("Fatura bilgisi başarı ile silindi");
        }

        public IDataResult<FaturaBilgi> Get(int id)
        {
            return new SucessDataResult<FaturaBilgi>(_faturaBilgiDal.Get(p => p.Id == id));
        }

        public IDataResult<List<FaturaBilgiDetailsDto>> GetAllDetailsDto()
        {
            return new SucessDataResult<List<FaturaBilgiDetailsDto>>(_faturaBilgiDal.GetAllDetailsDto());
        }

        public IResult Update(FaturaBilgi faturaBilgi)
        {
            if (faturaBilgi.KacOdenecek < 0 || faturaBilgi.Tutar < 0)
            {
                return new ErrorResult("Lütfen fazla para almayınız");
            }
            _faturaBilgiDal.Update(faturaBilgi);
            return new SuccessResult("Fatura bilgisi başarı ile güncellendi");
        }
    }
}
