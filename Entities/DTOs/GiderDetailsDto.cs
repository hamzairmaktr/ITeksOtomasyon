using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class GiderDetailsDto:IDto
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Tur { get; set; }
        public string Personel { get; set; }
        public string Not { get; set; }
        public decimal Tutar { get; set; }
    }
}
