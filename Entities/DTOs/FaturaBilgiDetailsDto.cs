﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class FaturaBilgiDetailsDto:IDto
    {
        public int Id { get; set; }
        public string SiraNo { get; set; }
        public DateTime Tarih { get; set; }
        public string CariName { get; set; }
        public string PersonelName { get; set; }
        public string TeslimAlan { get; set; }
        public decimal Tutar { get; set; }
    }
}