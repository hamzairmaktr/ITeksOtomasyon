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
    public class CariManager : ICariService
    {
        ICariDal _cariDal;

        public CariManager(ICariDal cariDal)
        {
            _cariDal = cariDal;
        }

        public IResult Add(Cari cari)
        {
            if (String.IsNullOrEmpty(cari.Ismi))
            {
                return new ErrorResult("Lütfen ismi boş geçmeyiniz");
            }
            else if (cari.Ismi.Length<3||cari.Ismi.Length>30)
            {
                return new ErrorResult("İsim min 3 max 30 karakter olmalıdır");
            }
            else if (String.IsNullOrEmpty(cari.YetkiliAdSoyad))
            {
                return new ErrorResult("Yetkili ismini boş geçmeyiniz");
            }
            else if (cari.YetkiliAdSoyad.Length < 5 || cari.YetkiliAdSoyad.Length>50)
            {
                return new ErrorResult("Yetkili ismi min 5 max 50 karakter olmalıdır");
            }
            else if (String.IsNullOrEmpty(cari.Telefon1))
            {
                return new ErrorResult("Lütfen telefon 1 kısmını boş bırakmayınız");
            }
            else if (String.IsNullOrEmpty(cari.Il))
            {
                return new ErrorResult("Lütfen İl kısmını boş bırakmayınız");
            }
            else if (String.IsNullOrEmpty(cari.YetkiliStatu))
            {
                return new ErrorResult("Lütfen Yetkili Statu kısmını boş bırakmayınız");
            }
            else
            {
                _cariDal.Add(cari);
                return new SuccessResult("Cari başarı ile kaydedildi");
            }
        }

        public IResult Delete(Cari cari)
        {
            _cariDal.Delete(cari);
            return new SuccessResult("Cari başarı ile güncellendi");
        }

        public IDataResult<List<Cari>> GetAll()
        {
            return new SucessDataResult<List<Cari>>(_cariDal.GetAll());
        }

        public IDataResult<List<CariOzetDtos>> GetCariOzetDtos()
        {
            return new SucessDataResult<List<CariOzetDtos>>(_cariDal.GetCariOzetDtos());
        }

        public IResult Update(Cari cari)
        {
            if (String.IsNullOrEmpty(cari.Ismi))
            {
                return new ErrorResult("Lütfen ismi boş geçmeyiniz");
            }
            else if (cari.Ismi.Length < 3 || cari.Ismi.Length > 30)
            {
                return new ErrorResult("İsim min 3 max 30 karakter olmalıdır");
            }
            else if (String.IsNullOrEmpty(cari.YetkiliAdSoyad))
            {
                return new ErrorResult("Yetkili ismini boş geçmeyiniz");
            }
            else if (cari.YetkiliAdSoyad.Length < 5 || cari.YetkiliAdSoyad.Length > 50)
            {
                return new ErrorResult("Yetkili ismi min 5 max 50 karakter olmalıdır");
            }
            else if (String.IsNullOrEmpty(cari.Telefon1))
            {
                return new ErrorResult("Lütfen telefon 1 kısmını boş bırakmayınız");
            }
            else if (String.IsNullOrEmpty(cari.Il))
            {
                return new ErrorResult("Lütfen İl kısmını boş bırakmayınız");
            }
            else if (String.IsNullOrEmpty(cari.YetkiliStatu))
            {
                return new ErrorResult("Lütfen Yetkili Statu kısmını boş bırakmayınız");
            }
            else
            {
                _cariDal.Update(cari);
                return new SuccessResult("Cari başarı ile güncellendi");
            }
        }
    }
}
