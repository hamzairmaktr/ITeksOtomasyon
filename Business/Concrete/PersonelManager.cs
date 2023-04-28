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
    public class PersonelManager:IPersonelService
    {
        private readonly IPersonelDal _personelDal;

        public PersonelManager(IPersonelDal personelDal)
        {
            _personelDal = personelDal;
        }

        public IResult Add(Personel personel)
        {
            if (String.IsNullOrEmpty(personel.AdSoyad))
            {
                return new ErrorResult("Lütfen isimi boş bırakmayınız");
            }
            else if (personel.AdSoyad.Length <= 5 ||personel.AdSoyad.Length >= 30)
            {
                return new ErrorResult("İsim alanı min 5 max 30 karakter olmalıdır"); 
            }
            else if (String.IsNullOrEmpty(personel.Telefon))
            {
                return new ErrorResult("Lütfen telefon alanını boş bırakmayınız");
            }
            else if (String.IsNullOrEmpty(personel.Gorev))
            {
                return new ErrorResult("Lütfen görev alanını boş bırakmayınız");
            }
            else if (personel.Gorev != "Sahibi")
            {
                if (personel.Maas == 0)
                {
                    return new ErrorResult("Lütfen maaş alanını boş bırakmayınız");
                }
                else
                {
                    _personelDal.Add(personel);
                    return new SuccessResult("Personel başarı ile eklendi");
                }
            }
            else
            {
                _personelDal.Add(personel);
                return new SuccessResult("Personel başarı ile eklendi");
            }
        }

        public IResult Delete(Personel personel)
        {
            _personelDal.Delete(personel);
            return new SuccessResult("Personel başarı ile silindi");
        }

        public IDataResult<List<Personel>> GetAll()
        {
            return new SucessDataResult<List<Personel>>(_personelDal.GetAll());
        }

        public IResult Update(Personel personel)
        {
            if (String.IsNullOrEmpty(personel.AdSoyad))
            {
                return new ErrorResult("Lütfen isimi boş bırakmayınız");
            }
            else if (personel.AdSoyad.Length <= 5 || personel.AdSoyad.Length >= 30)
            {
                return new ErrorResult("İsim alanı min 5 max 30 karakter olmalıdır");
            }
            else if (String.IsNullOrEmpty(personel.Telefon))
            {
                return new ErrorResult("Lütfen telefon alanını boş bırakmayınız");
            }
            else if (String.IsNullOrEmpty(personel.Gorev))
            {
                return new ErrorResult("Lütfen görev alanını boş bırakmayınız");
            }
            else if (personel.Gorev != "Sahibi")
            {
                if (personel.Maas == 0)
                {
                    return new ErrorResult("Lütfen maaş alanını boş bırakmayınız");
                }
                else
                {
                    _personelDal.Update(personel);
                    return new SuccessResult("Personel başarı ile güncellendi");
                }
            }
            else
            {
                _personelDal.Update(personel);
                return new SuccessResult("Personel başarı ile güncellendi");
            }
        }
    }
}
