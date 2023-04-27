using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Stok:IEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Tur { get; set; }
        [Required]
        public int TopAdet { get; set; }
        [Required]
        public decimal Kilogram { get; set; }
    }
}
