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
        public string KumasTur { get; set; }
        public string KumasAd { get; set; }
        public string Renk { get; set; }
        public decimal Kg { get; set; }
        public int TopAdet { get; set; }
        public string Detay { get; set; }
        public decimal AlisFiyat { get; set; }
        public decimal SatisFiyat { get; set; }
    }
}
