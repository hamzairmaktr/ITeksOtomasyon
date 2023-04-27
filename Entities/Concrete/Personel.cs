using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Personel:IEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string AdSoyad { get; set; }
        [Required]
        public decimal Maas { get; set; }
        [Required]
        [StringLength(20)]
        public string Telefon { get; set; }
        [Required]
        [StringLength(50)]
        public string Mail { get; set; }
        [Required]
        [StringLength(20)]
        public string Il { get; set; }
        [Required]
        [StringLength(30)]
        public string Ilce { get; set; }
        [Required]
        [StringLength(500)]
        public string Adres { get; set; }
        [Required]
        [StringLength(25)]
        public string Gorev { get; set; }
    }
}
