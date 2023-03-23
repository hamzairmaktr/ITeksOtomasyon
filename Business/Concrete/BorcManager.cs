using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BorcManager : IBorcService
    {
        IBorcDal _borcDal;

        public BorcManager(IBorcDal borcDal)
        {
            _borcDal = borcDal;
        }

        public IResult Add(Borc borc)
        {
            if (borc.Tutar == 0)
            {
                return new ErrorResult("Lütfen tutarı boş girmeyiniz");
            }
            else if (borc.VerilisTarih > borc.TeslimTarih)
            {
                return new ErrorResult("Lütfen veriliş tarihi teslim tarihinden daha sonra olmasın");
            }
            else
            {
                _borcDal.Add(borc);
                return new SuccessResult("Borç bilgisi kaydedildi");
            }
        }

        public IResult Delete(Borc borc)
        {
            _borcDal.Delete(borc);
            return new SuccessResult();
        }

        public IDataResult<List<BorcDetailsDto>> GetBorcDetailAll()
        {
            return new SucessDataResult<List<BorcDetailsDto>>(_borcDal.GetProductDetailsAll(p=>p.Odendimi==false));
        }

        public IDataResult<List<BorcOzetDto>> GetBorcOzetDTOs()
        {
            return new SucessDataResult<List<BorcOzetDto>>(_borcDal.GetBorcOzetDtos(p => p.Odendimi==false));
        }

        public IResult Update(Borc borc)
        {
            if (borc.Tutar == 0)
            {
                return new ErrorResult("Lütfen tutarı boş girmeyiniz");
            }
            else if (borc.VerilisTarih > borc.TeslimTarih)
            {
                return new ErrorResult("Lütfen veriliş tarihi teslim tarihinden daha sonra olmasın");
            }
            else
            {
                _borcDal.Update(borc);
                return new SuccessResult("Borç bilgisi güncellendi");
            }
        }
    }
}
