using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Borc:IEntity
    {
        public int Id { get; set; }
        public int MusteriId { get; set; }
        public decimal Tutar { get; set; }
        public decimal KacOdendi { get; set; }
        public decimal KacOdenecek { get; set; }
    }
}
