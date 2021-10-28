using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoWorkshop.Library.Models
{
    public class Evento
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Titolo { get; set; }
        [Required]

        public DateTime Data { get; set; }
        [Required]
        public string Localita { get; set; }
    }
}
