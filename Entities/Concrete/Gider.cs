using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Gider:IEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime Date { get; set; }
        [Required]
        [StringLength(20)]
        public string Tur { get; set; }
        [Required]
        public int PersonelId { get; set; }
        [Required]
        [StringLength(500)]
        public string Not { get; set; }
        [Required]
        public decimal Tutar { get; set; }
    }
}
