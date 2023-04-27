using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class FaturaBilgi:IEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string SiraNo { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        [DataType(DataType.Time)]
        [Required]
        public DateTime Time { get; set; }
        [Required]
        public int CariId { get; set; }
        [Required]
        public int PersonelId { get; set; }
        [Required]
        [StringLength(35)]
        public string TeslimAlan { get; set; }
        [Required]
        public decimal KacOdendi { get; set; }
        [Required]
        public decimal KacOdenecek { get; set; }
        [Required]
        public decimal Tutar { get; set; }
    }
}
