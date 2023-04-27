using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Haraket:IEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int CariId { get; set; }
        [Required]
        public int PersonelId { get; set; }
        [Required]
        public int HaraketTur { get; set; }
        [Required]
        [StringLength(250)]
        public string Detay { get; set; }
        [Required]
        public decimal Tutar { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime Tarih { get; set; }
    }
}
