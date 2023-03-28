using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class KasaTurManager : IKasaTurService
    {
        IKasaTurDal _kasaTurDal;

        public KasaTurManager(IKasaTurDal kasaTurDal)
        {
            _kasaTurDal = kasaTurDal;
        }

        public IResult Add(KasaTur kasaTur)
        {
            if (String.IsNullOrEmpty(kasaTur.Name))
            {
                return new ErrorResult("Lütfen kasa türü ismini boş bırakmayınız");
            }
            else if (kasaTur.Name.Length <= 3 || kasaTur.Name.Length >=20)
            {
                return new ErrorResult("Kasa türü ismi 3 ile 20 karakter arasında olmalıdır");
            }
            else 
            {
                _kasaTurDal.Add(kasaTur);
                return new SuccessResult("Kasa türü başarı ile eklendi");
            }
        }

        public IResult Delete(KasaTur kasaTur)
        {
            _kasaTurDal.Delete(kasaTur);
            return new SuccessResult();
        }

        public IDataResult<List<KasaTur>> GetAll()
        {
            return new SucessDataResult<List<KasaTur>>(_kasaTurDal.GetAll());
        }

        public IResult Update(KasaTur kasaTur)
        {
            if (String.IsNullOrEmpty(kasaTur.Name))
            {
                return new ErrorResult("Lütfen kasa türü ismini boş bırakmayınız");
            }
            else if (kasaTur.Name.Length <= 3 || kasaTur.Name.Length >= 20)
            {
                return new ErrorResult("Kasa türü ismi 3 ile 20 karakter arasında olmalıdır");
            }
            else
            {
                _kasaTurDal.Update(kasaTur);
                return new SuccessResult("Kasa türü başarı ile güncellendi");
            }
        }
    }
}
