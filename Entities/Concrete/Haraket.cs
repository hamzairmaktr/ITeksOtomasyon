﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Haraket:IEntity
    {
        public int Id { get; set; }
        public int FirmaId { get; set; }
        public int PersonelId { get; set; }
        public int HaraketTur { get; set; }
        public string Description { get; set; }
        public decimal Tutar { get; set; }
        public DateTime Date { get; set; }
    }
}