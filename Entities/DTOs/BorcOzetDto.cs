using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class BorcOzetDto:IDto
    {
        public int Id { get; set; }
        public string Cari { get; set; }
        public int CariId { get; set; }
        public string Tur { get; set; }
        public decimal Tutar { get; set; }
        public decimal KacOdenecek { get; set; }
    }
}
