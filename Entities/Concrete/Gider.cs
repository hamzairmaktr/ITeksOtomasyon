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
        public DateTime Date { get; set; }
        public decimal Elektrik { get; set; }
        public decimal Su { get; set; }
        public decimal DogalGaz { get; set; }
        public decimal Internet { get; set; }
        public decimal Maaslar { get; set; }
        public decimal Ekstra { get; set; }
        public string Not { get; set; }
    }
}
