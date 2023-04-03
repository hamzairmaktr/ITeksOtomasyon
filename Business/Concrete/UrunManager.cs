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
    public class UrunManager:IUrunService
    {
        IUrunDal _urunDal;

        public UrunManager(IUrunDal urunDal)
        {
            _urunDal = urunDal;
        }

        public IResult Add(Urun urun)
        {
            if (String.IsNullOrEmpty(urun.KumasTur))
            {
                return new ErrorResult("Ürün türü boş bırakmayınız");
            }
            else if (String.IsNullOrEmpty(urun.KumasAd))
            {
                return new ErrorResult("Ürün adı boş bırakmayınız");
            }
            else
            {
                _urunDal.Add(urun);
                return new SuccessResult("Ürün başarı ile eklendi");
            }
        }

        public IResult Delete(Urun urun)
        {
            _urunDal.Delete(urun);
            return new SuccessResult("Ürün başarı ile silindi");
        }

        public IDataResult<Urun> Get(int id)
        {
            return new SucessDataResult<Urun>(_urunDal.Get(p=>p.Id == id));
        }

        public IDataResult<List<Urun>> GetAll()
        {
            return new SucessDataResult<List<Urun>>(_urunDal.GetAll());
        }

        public IResult Update(Urun urun)
        {
            if (String.IsNullOrEmpty(urun.KumasTur))
            {
                return new ErrorResult("Ürün türü boş bırakmayınız");
            }
            else if (String.IsNullOrEmpty(urun.KumasAd))
            {
                return new ErrorResult("Ürün adı boş bırakmayınız");
            }
            else
            {
                _urunDal.Update(urun);
                return new SuccessResult("Ürün başarı ile güncellendi");
            }
        }
    }
}
