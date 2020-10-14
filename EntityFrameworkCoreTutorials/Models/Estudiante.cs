using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EntityFrameworkCoreTutorials.Models
{
    public class Estudiante
    {
        [Key]
        public int EstudianteId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int CursoId { get; set; }
        [ForeignKey("CursoId")]
        public virtual Curso Curso { get; set; }
    }
}
