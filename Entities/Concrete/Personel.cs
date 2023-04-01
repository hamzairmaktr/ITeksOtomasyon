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
        public string AdSoyad { get; set; }
        public decimal Maas { get; set; }
        public string Telefon { get; set; }
        public string Mail { get; set; }
        public string Il { get; set; }
        public string Ilce { get; set; }
        public string Adres { get; set; }
        public string Gorev { get; set; }
    }
}
