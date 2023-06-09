﻿using Business.Abstract;
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
        private readonly IBorcDal _borcDal;

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

        public IResult AddBorcFatura(Borc borc, FaturaBilgi faturaBilgi)
        {
            if (faturaBilgi.KacOdenecek < 0)
            {
                return new ErrorResult();
            }
            if (faturaBilgi.Tutar < 0)
            {
                return new ErrorResult();
            }
            if (borc.Tutar < 0)
            {
                return new ErrorResult();
            }
            _borcDal.Add(borc);
            return new SuccessResult();
        }

        public IResult Delete(Borc borc)
        {
            _borcDal.Delete(borc);
            return new SuccessResult();
        }

        public IDataResult<List<BorcDetailsDto>> GetBorcDetailAll()
        {
            return new SucessDataResult<List<BorcDetailsDto>>(_borcDal.GetProductDetailsAll());
        }

        public IDataResult<List<BorcOzetDto>> GetBorcOzetDTOs()
        {
            return new SucessDataResult<List<BorcOzetDto>>(_borcDal.GetBorcOzetDtos());
        }

        public IDataResult<List<BorcOzetDto>> GetBorcOzetOdeDTOs()
        {
            return new SucessDataResult<List<BorcOzetDto>>(_borcDal.GetBorcOzetOdeDtos(),"başarılı");
        }

        public IDataResult<List<BorcOzetDto>> GetBorcOzetTahsilDTOs()
        {
            return new SucessDataResult<List<BorcOzetDto>>(_borcDal.GetBorcOzetTahsilDtos(),"başarılı");
        }

        public IDataResult<BorcOzetDto> GetByCariId(int id)
        {
            return new SucessDataResult<BorcOzetDto>(_borcDal.GetByCariId(id));
        }

        public IDataResult<Borc> GetById(int id)
        {
            return new SucessDataResult<Borc>(_borcDal.Get(b=>b.Id==id));
        }

        public IResult Update(Borc borc)
        {
            _borcDal.Update(borc);
            return new SuccessResult("Borç bilgisi güncellendi");        
        }

        public IResult UpdateMoney(Borc borc, FaturaBilgi faturaBilgi)
        {
            if (faturaBilgi.KacOdenecek < 0)
            {
                return new ErrorResult();
            }
            if (faturaBilgi.Tutar < 0)
            {
                return new ErrorResult();
            }
            if (borc.Tutar < 0)
            {
                return new ErrorResult();
            }
            _borcDal.Update(borc);
            return new SuccessResult();
        }
    }
}
