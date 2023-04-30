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
        [Required]
        public int FaturaId { get; set; }
        [Required]
        public int UrunId { get; set; }
        [Required]
        public int TopSayisi { get; set; }
        [Required]
        public decimal Kg { get; set; }
        [Required]
        public decimal Fiyat { get; set; }
        [Required]
        public decimal Tutar { get; set; }
    }
}
