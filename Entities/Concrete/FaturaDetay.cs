using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class FaturaDetay:IEntity
    {
        [Key]
        public int Id { get; set; }
        public int FaturaId { get; set; }

        public int UrunId { get; set; }
        public Urun Urun { get; set; }

        public int TopSayisi { get; set; }
        public decimal Kg { get; set; }
        public decimal Fiyat { get; set; }
        public decimal Tutar { get; set; }
    }
}
