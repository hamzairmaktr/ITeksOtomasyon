using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Kasa:IEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int KasaTur { get; set; }
        [Required]
        public decimal Bakiye { get; set; }
    }
}
