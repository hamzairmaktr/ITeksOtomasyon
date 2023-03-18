using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Not:IEntity
    {
        [Key]
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
        public string Baslik { get; set; }
        public string Detay { get; set; }
        public int PersonelID { get; set; }
    }
}
