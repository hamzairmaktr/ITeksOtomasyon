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
        public string Ismi { get; set; }
        public string CariTur { get; set; }
        public string YetkiliAdSoyad { get; set; }
        public string YetkiliStatu { get; set; }
        public string Telefon1 { get; set; }
        public string Telefon2 { get; set; }
        public string Mail { get; set; }
        public string Fax { get; set; }
        public string Il { get; set; }
        public string Ilce { get; set; }
        public string VergiDaire { get; set; }
        public string Adres { get; set; }
    }
}
