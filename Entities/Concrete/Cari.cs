using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Cari:IEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(30)]
        public string Ismi { get; set; }
        [Required]
        [StringLength(15)]
        public string CariTur { get; set; }
        [Required]
        [StringLength(35)]
        public string YetkiliAdSoyad { get; set; }
        [Required]
        [StringLength(15)]
        public string YetkiliStatu { get; set; }
        [Required]
        [StringLength(15)]
        public string Telefon1 { get; set; }
        [Required]
        [StringLength(15)]
        public string Telefon2 { get; set; }
        [Required]
        [StringLength(40)]
        public string Mail { get; set; }
        [Required]
        [StringLength(40)]
        public string Fax { get; set; }
        [Required]
        [StringLength(20)]
        public string Il { get; set; }
        [Required]
        [StringLength(30)]
        public string Ilce { get; set; }
        [Required]
        [StringLength(30)]
        public string VergiDaire { get; set; }
        [Required]
        [StringLength(500)]
        public string Adres { get; set; }
    }
}
