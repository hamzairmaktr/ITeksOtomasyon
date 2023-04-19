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
        public string Not { get; set; }
        public decimal Tutar { get; set; }
    }
}
