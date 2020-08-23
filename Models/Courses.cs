using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Models
{

    public class Courses
    {
        [Key]
        public int CourseId { get; set; }

        [Required(ErrorMessage = "El campo es requerido")]
        [StringLength(500, ErrorMessage = "Solo se aceptan 500 caracteres")]
        public string CourseName { get; set; }
        public DateTime Date { get; set; }

        public int SpeakerId { get; set; }
        [ForeignKey("SpeakerId")]
        public virtual Speakers Speakers { get; set; }
    }
}
