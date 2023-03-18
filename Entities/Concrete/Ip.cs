using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Ip:IEntity
    {
        [Key]
        public int Id { get; set; }
        public string IpNumarasi { get; set; }
        public string IpRengi { get; set; }
        public decimal IpKilosu { get; set; }
        public string IpDetay { get; set; }
    }
}
