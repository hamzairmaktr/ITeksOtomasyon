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
    public class GiderManager : IGiderService
    {
        IGiderDal _giderDal;

        public GiderManager(IGiderDal giderDal)
        {
            _giderDal = giderDal;
        }

        public IResult Add(Gider gider)
        {
            if (String.IsNullOrEmpty(gider.Not))
            {
                return new ErrorResult("Not kısmını boş girmeyiniz");
            }
            if (gider.Tutar <= 0)
            {
                return new ErrorResult("Tutar kısmını boş girmeyiniz");
            }
            _giderDal.Add(gider);
            return new SuccessResult("Gider bilgisi sisteme kaydedildi");
        }

        public IResult Delete(Gider gider)
        {
            _giderDal.Delete(gider);
            return new SuccessResult("Gider bilgisi sistemden silindi");
        }

        public IDataResult<List<GiderDetailsDto>> GetAll()
        {
            return new SucessDataResult<List<GiderDetailsDto>>(_giderDal.GetDetailsDto());
        }

        public IDataResult<List<GiderDetailsDto>> GetAll30DayBefore()
        {
            return new SucessDataResult<List<GiderDetailsDto>>(_giderDal.GetDetailsDto(p=>p.Date >= DateTime.Now.AddDays(-30)));
        }

        public IDataResult<List<GiderDetailsDto>> GetAll365DayBefore()
        {
            return new SucessDataResult<List<GiderDetailsDto>>(_giderDal.GetDetailsDto(p => p.Date >= DateTime.Now.AddDays(-365)));
        }

        public IDataResult<List<GiderDetailsDto>> GetAll7DayBefore()
        {
            return new SucessDataResult<List<GiderDetailsDto>>(_giderDal.GetDetailsDto(p => p.Date >= DateTime.Now.AddDays(-7)));
        }

        public IDataResult<List<GiderDetailsDto>> GetAllDay(DateTime date)
        {
            return new SucessDataResult<List<GiderDetailsDto>>(_giderDal.GetDetailsDto(p => p.Date == date));
        }

        public IDataResult<List<GiderDetailsDto>> GetAllMonth(DateTime date)
        {
            return new SucessDataResult<List<GiderDetailsDto>>(_giderDal.GetDetailsDto(p => p.Date.Month == date.Month && p.Date.Year == date.Year));
        }

        public IResult Update(Gider gider)
        {
            if (String.IsNullOrEmpty(gider.Not))
            {
                return new ErrorResult("Not kısmını boş girmeyiniz");
            }
            if (gider.Tutar <= 0)
            {
                return new ErrorResult("Tutar kısmını boş girmeyiniz");
            }
            _giderDal.Update(gider);
            return new SuccessResult("Gider bilgisi sistemde güncellendi");
        }
    }
}
