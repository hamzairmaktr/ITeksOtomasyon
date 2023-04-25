using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class FaturaDetayDetailsDto:IDto
    {
        public int Id { get; set; }
        public int FaturaId { get; set; }
        public int UrunId { get; set; }
        public string UrunTur { get; set; }
        public string UrunName { get; set; }
        public string UrunRenk { get; set; }
        public int Adet { get; set; }
        public decimal Kg { get; set; }
        public decimal Fiyat { get; set; }
        public decimal Tutar { get; set; }
    }
}
