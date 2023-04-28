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
        [StringLength(50)]
        public string AdSoyad { get; set; }
        public decimal Maas { get; set; }
        [StringLength(20)]
        public string Telefon { get; set; }
        [StringLength(50)]
        public string Mail { get; set; }
        [StringLength(20)]
        public string Il { get; set; }
        [StringLength(30)]
        public string Ilce { get; set; }
        [StringLength(500)]
        public string Adres { get; set; }
        [StringLength(25)]
        public string Gorev { get; set; }
    }
}
