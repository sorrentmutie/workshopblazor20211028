using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoWorkshop.Library.Models
{
    public class Evento
    {
        public int Id { get; set; }
        public string Titolo { get; set; }
        public DateTime Data { get; set; }
        public string Localita { get; set; }
    }
}
