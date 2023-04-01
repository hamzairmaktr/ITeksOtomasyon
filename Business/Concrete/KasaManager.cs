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
        IKasaDal _kasaDal;

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
            
            _kasaDal.Update(kasa);
            return new SuccessResult("Kasa başarı ile güncellendi");
            
        }

        public IResult UpdateMoney(decimal tutar, int id)
        {
            Kasa kasa1 = new Kasa
            {
                Id = id,
                Bakiye = tutar
            };
            _kasaDal.Update(kasa1);
            return new SuccessResult("Başarı ile bakiye eklendi");
        }
    }
}
