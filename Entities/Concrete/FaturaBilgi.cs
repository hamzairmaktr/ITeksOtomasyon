﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class FaturaBilgi:IEntity
    {
        [Key]
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
        public string VergiDaire { get; set; }
        public int FirmaId { get; set; }
        public int PersonelId { get; set; }
        public string TeslimAlan { get; set; }
    }
}
