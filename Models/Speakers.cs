using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Models
{
    public class Speakers
    {   
        [Key]
        public int SpeakerId { get; set;}

        [Required(ErrorMessage = "El campo es requerido")]
        [StringLength(400, ErrorMessage = "Solo se aceptan 400 caracteres")]
        public string SpeakerName { get; set; }
        
        [Required(ErrorMessage ="El campo es obligatorio")]
        public string Email { get; set; }
        
        [Required(ErrorMessage = "El campo es obligatorio")]
        [StringLength(200, ErrorMessage = "Solo se aceptan 200 caracteres")]
        public string Country { get; set; }
        
        [Required(ErrorMessage ="El campo es obligatorio")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "El campo es requerido")]
        public int Duration { get; set; }
    }
}
