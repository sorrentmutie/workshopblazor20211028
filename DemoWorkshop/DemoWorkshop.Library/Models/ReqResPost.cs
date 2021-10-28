using System.ComponentModel.DataAnnotations;

namespace DemoWorkshop.Library.Models
{
    public class ReqResPost
    {
        [Required(ErrorMessage = "Campo Obbligatorio")]
        [StringLength(50, ErrorMessage ="Nome troppo lungo")]
        public string name { get; set; }
        [Required(ErrorMessage = "Job Obbligatorio")]
        public string job { get;  set; }
    }
}
