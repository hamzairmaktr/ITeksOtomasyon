using Business.Abstract;
using Business.Constants;
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
    public class BankaManager : IBankaService
    {
        private readonly IBankaDal _bankaDal;

        public BankaManager(IBankaDal bankaDal)
        {
            _bankaDal = bankaDal;
        }
        
        public IResult Add(Banka banka)
        {
            if (String.IsNullOrEmpty(banka.BankaAd))
            {
                return new ErrorResult("Lütfen banka adını boş bırakmayınız");
            }
            else if (banka.BankaAd.Length<3)
            {
                return new ErrorResult("Banka adı en az 3 karakter olmalı");
            }
            else if (banka.Sube.Length == 0)
            {
                return new ErrorResult("Lütfen şube adını boş bırakmayınız.");
            }
            else if (banka.BankaAd.Length>50)
            {
                return new ErrorResult("Banka adı en fazla 50 karakter olmalı");
            }
            else if (banka.Sube.Length > 50)
            {
                return new ErrorResult("Sube adı en fazla 50 karakter olmalı");
            }

            else
            {
                _bankaDal.Add(banka);
                return new SuccessResult("Banka Eklendi");
            }
        }

        public IResult Delete(Banka banka)
        {
            if (banka.Id == 0 )
            {
                return new ErrorResult("Banka id boş bırakılmamalı");
            }
            else
            {
                _bankaDal.Delete(banka);
                return new SuccessResult(Messages.BankaSilindi);
            }        
        }

        public IDataResult<List<Banka>> GetAll()
        {
            return new SucessDataResult<List<Banka>>(_bankaDal.GetAll());
        }   

        public IResult Update(Banka banka)
        {
            if (String.IsNullOrEmpty(banka.BankaAd))
            {
                return new ErrorResult("Lütfen banka adını boş bırakmayınız");
            }
            else if (banka.BankaAd.Length < 3)
            {
                return new ErrorResult("Banka adı en az 3 karakter olmalı");
            }
            else if (banka.Sube.Length == 0)
            {
                return new ErrorResult("Lütfen şube adını boş bırakmayınız.");
            }
            else if (banka.BankaAd.Length > 50)
            {
                return new ErrorResult("Banka adı en fazla 50 karakter olmalı");
            }
            else if (banka.Sube.Length > 50)
            {
                return new ErrorResult("Sube adı en fazla 50 karakter olmalı");
            }
            else
            {
                _bankaDal.Update(banka);
                return new SuccessResult(Messages.BankaGuncellendi);
            }
        }
    }
}
