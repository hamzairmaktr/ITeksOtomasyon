using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Not:IEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Onem { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        [DataType(DataType.Time)]
        [Required]
        public DateTime Time { get; set; }
        [Required]
        [StringLength(100)]
        public string Baslik { get; set; }
        [Required]
        [StringLength(2000)]
        public string Detay { get; set; }
        [Required]
        public int PersonelID { get; set; }
        [Required]
        public bool Yapildimi { get; set; }
    }
}
