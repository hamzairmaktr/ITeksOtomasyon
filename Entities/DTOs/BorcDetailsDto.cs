using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class BorcDetailsDto:IDto
    {
        public int Id { get; set; }
        public string Cari { get; set; }
        public string Tur { get; set; }
        public decimal Tutar { get; set; }
        public decimal KacOdendi { get; set; }
        public decimal KacOdenecek { get; set; }
        public DateTime VerilisTarih { get; set; }
        public DateTime TeslimTarih { get; set; }
        public bool Geciktimi { get; set; }
        public bool Odendimi { get; set; }

    }
}
