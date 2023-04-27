using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Banka:IEntity
    {
        [Key]
        public int Id { get; set; }

        [StringLength(25)]
        [Required]
        public string BankaAd { get; set; }
        [StringLength(25)]
        [Required]
        public string Sube { get; set; }
        [StringLength(50)]
        [Required]
        public string Iban { get; set; }
        [StringLength(10)]
        [Required]
        public string HesapNo { get; set; }
        [StringLength(35)]
        [Required]
        public string Yetkili { get; set; }
        [Required]  
        public DateTime Tarih { get; set; }
        [StringLength(15)]
        [Required]
        public string HesapTuru { get; set; }
    }
}
