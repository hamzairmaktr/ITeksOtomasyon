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
            else if (kasa.Bakiye==0)
            {
                return new ErrorResult("Bakiye kısmını boş bırakmayınız");
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

        public IDataResult<List<KasaDetailsDto>> GetDetailsDto()
        {
            return new SucessDataResult<List<KasaDetailsDto>>(_kasaDal.GetAllDetailsDto());
        }

        public IResult Update(Kasa kasa)
        {
            if (kasa.KasaTur == 0)
            {
                return new ErrorResult("Kasa türünü boş bırakmayınız");
            }
            else if (kasa.Bakiye == 0)
            {
                return new ErrorResult("Bakiye kısmını boş bırakmayınız");
            }
            else
            {
                _kasaDal.Update(kasa);
                return new SuccessResult("Kasa başarı ile güncellendi");
            }
        }
    }
}
