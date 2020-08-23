using Api.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Api.DTOs
{
    public class SpeakersDTO
    {

        public int SpeakerId { get; set; }

        [Required(ErrorMessage ="El campo es requerido")]
        [StringLength(400, ErrorMessage = "Solo se aceptan 400 caracteres")]
        public String SpeakerName { get; set; }

        [Required(ErrorMessage ="El campo es requerido")]
        [EmailAddress(ErrorMessage = "Correo invalido")]
        public string Email { get; set; }

        [Required(ErrorMessage ="El campo es requerido")]
        [StringLength(200, ErrorMessage ="Solo se aceptan 200 caracteres")]
        public string Country { get; set; }

        [Required (ErrorMessage ="El campo es requerido")]
        [Phone(ErrorMessage = "Telefono invalido")]
        public string Phone { get; set; }

        [MinLength(1,ErrorMessage ="El campo requiere un caracter como minimo")]
        public int Duration { get; set; }

        
    }
}