using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class KasaDetailsDto:IDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int KasaTurId { get; set; }
        public string BankaName { get; set; }
        public decimal Bakiye { get; set; }
    }
}
