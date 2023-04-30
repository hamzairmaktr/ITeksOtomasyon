using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Borc:IEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int CariId { get; set; }
        [Required]
        [StringLength(10)]
        public string Tur { get; set; }
        [Required]
        public decimal Tutar { get; set; }
        [Required]
        public decimal KacOdendi { get; set; }
        [Required]
        public decimal KacOdenecek { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime VerilisTarih { get; set; }
        [DataType(DataType.DateTime)]
        [Required]
        public DateTime TeslimTarih { get; set; }
        [Required]
        public bool Geciktimi { get; set; }
        [Required]
        public bool Odendimi { get; set; }
    }
}
