using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class MyBorc:IEntity
    {
        [Key]
        public int Id { get; set; }
        public int FirmaId { get; set; }
        public decimal Tutar { get; set; }
        public decimal KacOdendi { get; set; }
        public decimal KacOdenecek { get; set; }
        public DateTime VerilisTarih { get; set; }
        public DateTime TeslimTarih { get; set; }
        public bool Geciktimi { get; set; }
    }
}
