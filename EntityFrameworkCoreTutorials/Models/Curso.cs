using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityFrameworkCoreTutorials.Models
{
    public class Curso
    {
        [Key]
        public int CursoId { get; set; }
        public string Nombre { get; set; }
    }
}
