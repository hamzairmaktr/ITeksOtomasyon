using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class NotDetailsDto:IDto
    {
        public int Id { get; set; }
        public string Onem { get; set; }
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
        public string Baslik { get; set; }
        public string Detay { get; set; }
        public string PersonelName { get; set; }
        public bool Yapildimi { get; set; }
    }
}
