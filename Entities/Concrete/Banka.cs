using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    //public class Banka:IEntity
    {
        [Key]
        public int Id { get; set; }
        public string BankaAd { get; set; }
        public string Sube { get; set; }
        public string Iban { get; set; }
        public string HesapNo { get; set; }
        public string Yetkili { get; set; }
        public DateTime Tarih { get; set; }
        public string HesapTuru { get; set; }
    }
}
