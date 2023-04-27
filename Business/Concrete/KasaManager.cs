using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class KasaManager : IKasaService
    {
        private readonly IKasaDal _kasaDal;
        

        public KasaManager(IKasaDal kasaDal)
        {
            _kasaDal = kasaDal;
            
        }

        public IResult Add(Kasa kasa)
        {
            if (kasa.KasaTur == 0)
            {
                return new ErrorResult("Kasa türünü boş bırakmayınız");
            }
            else
            {
                _kasaDal.Add(kasa);
                return new SuccessResult("Kasa başarı ile kaydedildi");
            }
        }

        public IResult Delete(Kasa kasa)
        {
            _kasaDal.Delete(kasa);
            return new SuccessResult("Kasa başarı ile silindi");
        }

        public IDataResult<Kasa> GetById(int id)
        {
            return new SucessDataResult<Kasa>(_kasaDal.Get(k => k.Id == id));
        }

        public IDataResult<List<KasaDetailsDto>> GetDetailsDto()
        {
            return new SucessDataResult<List<KasaDetailsDto>>(_kasaDal.GetAllDetailsDto());
        }

        public IResult Update(Kasa kasa)
        {
            if (kasa.KasaTur == 0)
            {
                return new ErrorResult("Lütfen kasa ismi giriniz");
            }
            
            _kasaDal.Update(kasa);
            return new SuccessResult("Kasa başarı ile güncellendi");
            
        }

        public IResult UpdateMoney(Kasa kasa,FaturaBilgi faturaBilgi)
        {
            if (kasa.KasaTur == 0)
            {
                return new ErrorResult("Lütfen kasa ismi giriniz");
            }
            if (faturaBilgi.Tutar < 0 || faturaBilgi.KacOdenecek < 0)
            {
                return new ErrorResult("Lütfen geçerli tutar giriniz");
            }
            _kasaDal.Update(kasa);
            return new SuccessResult("Başarı ile bakiye eklendi");
        }

        public IResult UpdateMoneyGider(Kasa kasa, Gider Gider)
        {
            if (kasa.KasaTur == 0)
            {
                return new ErrorResult("Lütfen kasa ismi giriniz");
            }
            if (kasa.Bakiye < 0)
            {
                return new ErrorResult("Kasadaki para yetersiz");
            }
            if (Gider.Tutar < 0)
            {
                return new ErrorResult("Lütfen geçerli tutar giriniz");
            }
            _kasaDal.Update(kasa);
            return new SuccessResult("Başarı ile bakiye eksiltildi");
        }
    }
}
