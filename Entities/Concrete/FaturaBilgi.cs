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
        public string SiraNo { get; set; }
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
        public int CariId { get; set; }
        public int PersonelId { get; set; }
        public string TeslimAlan { get; set; }
        public decimal KacOdendi { get; set; }
        public decimal KacOdenecek { get; set; }
        public decimal Tutar { get; set; }
    }
}
