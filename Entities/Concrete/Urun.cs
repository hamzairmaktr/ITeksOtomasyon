using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Urun:IEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string LotNo { get; set; }
        [Required]
        [StringLength(20)]
        public string KumasTur { get; set; }
        [Required]
        [StringLength(30)]
        public string KumasAd { get; set; }
        [Required]
        [StringLength(20)]
        public string Renk { get; set; }
        [Required]
        public decimal Kg { get; set; }
        [Required]
        public int TopAdet { get; set; }
        [Required]
        [StringLength(100)]
        public string Detay { get; set; }
        [Required]
        public decimal AlisFiyat { get; set; }
        [Required]
        public decimal SatisFiyat { get; set; }
        [Required]
        public bool Finish { get; set; }
    }
}
