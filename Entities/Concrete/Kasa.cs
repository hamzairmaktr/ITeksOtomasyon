using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Kasa:IEntity
    {
        public int Id { get; set; }
        public int KasaTur { get; set; }
        public decimal Bakiye { get; set; }
    }
}
