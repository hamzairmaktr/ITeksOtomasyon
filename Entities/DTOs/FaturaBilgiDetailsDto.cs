using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class FaturaBilgiDetailsDto:IDto
    {
        public int Id { get; set; }
        public string FaturaTuru { get; set; }
        public string SeriNo { get; set; }
        public DateTime Tarih { get; set; }
        public string CariName { get; set; }
        public string PersonelName { get; set; }
        public string TeslimAlan { get; set; }
        public decimal KacOdendi { get; set; }
        public decimal KacOdenecek { get; set; }
        public decimal Tutar { get; set; }
        public bool Odendimi { get; set; }
        public bool FaturaKesildimi { get; set; }
    }
}
