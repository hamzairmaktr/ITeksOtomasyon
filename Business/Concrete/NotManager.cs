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
    public class NotManager:INotService
    {
        INotDal _notDal;

        public NotManager(INotDal notDal)
        {
            _notDal = notDal;
        }

        public IResult Add(Not not)
        {
            if (String.IsNullOrEmpty(not.Baslik))
            {
                return new ErrorResult("Lütfen başlık alanını boş geçmeyiniz");
            }
            else
            {
                _notDal.Add(not);
                return new SuccessResult("Not başarı ile eklendi");
            }
        }

        public IResult Delete(Not not)
        {
            _notDal.Delete(not);
            return new SuccessResult("Not başarı ile silindi");
        }

        public IDataResult<Not> Get(int id)
        {
            return new SucessDataResult<Not>(_notDal.Get(p=>p.Id==id));
        }

        public IDataResult<List<NotDetailsDto>> GetAll()
        {
            return new SucessDataResult<List<NotDetailsDto>>(_notDal.GetAllDetailsDto());
        }

        public IResult Update(Not not)
        {
            if (String.IsNullOrEmpty(not.Baslik))
            {
                return new ErrorResult("Lütfen başlık alanını boş geçmeyiniz");
            }
            else
            {
                _notDal.Update(not);
                return new SuccessResult("Not başarı ile güncellendi");
            }
        }
    }
}
